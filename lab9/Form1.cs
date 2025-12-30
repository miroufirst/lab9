using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        private CompositeUnit _truck;

        public Form1()
        {
            InitializeComponent();
            AttachEvents();
        }

        private void AttachEvents()
        {
            btnBuild.Click += (s, e) => BuildTruck();
            btnAddTrailer.Click += (s, e) => AddTrailer();
        }

        private void BuildTruck()
        {
            _truck = new CompositeUnit("MAN Truck (Base)");

            CompositeUnit chassis = new CompositeUnit("Chassis");
            chassis.Add(new TruckPart("Axle Front", 500));
            chassis.Add(new TruckPart("Axle Rear", 500));
            chassis.Add(new TruckPart("Wheel FL", 200));
            chassis.Add(new TruckPart("Wheel FR", 200));
            chassis.Add(new TruckPart("Wheel RL", 200));
            chassis.Add(new TruckPart("Wheel RR", 200));

            CompositeUnit engine = new CompositeUnit("Engine V8");
            engine.Add(new TruckPart("Block", 2000));
            engine.Add(new TruckPart("Piston x8", 800));
            engine.Add(new TruckPart("Turbo", 1500));

            CompositeUnit cabin = new CompositeUnit("Cabin");
            cabin.Add(new TruckPart("Seat Driver", 300));
            cabin.Add(new TruckPart("Seat Passenger", 250));
            cabin.Add(new TruckPart("Dashboard", 600));

            _truck.Add(chassis);
            _truck.Add(engine);
            _truck.Add(cabin);

            UpdateView();
        }

        private void AddTrailer()
        {
            if (_truck == null)
            {
                MessageBox.Show("Build the truck first!");
                return;
            }

            CompositeUnit trailer = new CompositeUnit("Big Trailer");
            trailer.Add(new TruckPart("Trailer Frame", 1000));
            trailer.Add(new TruckPart("Extra Wheel 1", 200));
            trailer.Add(new TruckPart("Extra Wheel 2", 200));
            trailer.Add(new TruckPart("Container", 3000));

            _truck.Add(trailer);
            UpdateView();
        }

        private void UpdateView()
        {
            treeView1.Nodes.Clear();

            TreeNode rootNode = new TreeNode($"{_truck.Name} - {_truck.GetPrice()}$");
            treeView1.Nodes.Add(rootNode);

            PrintNodesRecursive(rootNode, _truck);

            treeView1.ExpandAll();
            lblPrice.Text = $"Total Price: {_truck.GetPrice()} $";
        }

        private void PrintNodesRecursive(TreeNode treeNode, CompositeUnit composite)
        {
            foreach (var component in composite.GetChildren())
            {
                TreeNode newNode = new TreeNode($"{component.Name} - {component.GetPrice()}$");
                treeNode.Nodes.Add(newNode);

                if (component is CompositeUnit childComposite)
                {
                    PrintNodesRecursive(newNode, childComposite);
                }
            }
        }
    }

    public abstract class TruckComponent
    {
        public string Name { get; protected set; }
        public abstract int GetPrice();
    }

    public class TruckPart : TruckComponent
    {
        private int _price;

        public TruckPart(string name, int price)
        {
            Name = name;
            _price = price;
        }

        public override int GetPrice()
        {
            return _price;
        }
    }

    public class CompositeUnit : TruckComponent
    {
        private List<TruckComponent> _children = new List<TruckComponent>();

        public CompositeUnit(string name)
        {
            Name = name;
        }

        public void Add(TruckComponent component)
        {
            _children.Add(component);
        }

        public void Remove(TruckComponent component)
        {
            _children.Remove(component);
        }

        public override int GetPrice()
        {
            int total = 0;
            foreach (var child in _children)
            {
                total += child.GetPrice();
            }
            return total;
        }

        public List<TruckComponent> GetChildren()
        {
            return _children;
        }
    }
}
