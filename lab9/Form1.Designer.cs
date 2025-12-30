namespace lab9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnAddTrailer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(382, 549);
            this.treeView1.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(399, 36);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(159, 25);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Total Price: 0 $";
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(404, 104);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(154, 29);
            this.btnBuild.TabIndex = 2;
            this.btnBuild.Text = "Build Standard Truck";
            this.btnBuild.UseVisualStyleBackColor = true;
            // 
            // btnAddTrailer
            // 
            this.btnAddTrailer.Location = new System.Drawing.Point(404, 158);
            this.btnAddTrailer.Name = "btnAddTrailer";
            this.btnAddTrailer.Size = new System.Drawing.Size(154, 27);
            this.btnAddTrailer.TabIndex = 3;
            this.btnAddTrailer.Text = "Add Trailer (+Parts)";
            this.btnAddTrailer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 549);
            this.Controls.Add(this.btnAddTrailer);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnAddTrailer;
    }
}

