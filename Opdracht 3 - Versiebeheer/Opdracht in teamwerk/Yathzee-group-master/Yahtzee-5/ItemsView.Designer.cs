namespace Yahtzee_5
{
    partial class ItemsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemName = new System.Windows.Forms.Label();
            this.Price1 = new System.Windows.Forms.Label();
            this.buy1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Price2 = new System.Windows.Forms.Label();
            this.Price3 = new System.Windows.Forms.Label();
            this.buy2 = new System.Windows.Forms.Button();
            this.buy3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Location = new System.Drawing.Point(1, 7);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(54, 13);
            this.ItemName.TabIndex = 0;
            this.ItemName.Text = "Extra dice";
            this.ItemName.Click += new System.EventHandler(this.ItemName_Click);
            // 
            // Price1
            // 
            this.Price1.AutoSize = true;
            this.Price1.Location = new System.Drawing.Point(86, 7);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(48, 13);
            this.Price1.TabIndex = 1;
            this.Price1.Text = "price: 10";
            // 
            // buy1
            // 
            this.buy1.Location = new System.Drawing.Point(152, 3);
            this.buy1.Name = "buy1";
            this.buy1.Size = new System.Drawing.Size(19, 20);
            this.buy1.TabIndex = 2;
            this.buy1.Text = "+";
            this.buy1.UseVisualStyleBackColor = true;
            this.buy1.Click += new System.EventHandler(this.buy1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "min points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "max points";
            // 
            // Price2
            // 
            this.Price2.AutoSize = true;
            this.Price2.Location = new System.Drawing.Point(86, 32);
            this.Price2.Name = "Price2";
            this.Price2.Size = new System.Drawing.Size(42, 13);
            this.Price2.TabIndex = 5;
            this.Price2.Text = "price: 5";
            // 
            // Price3
            // 
            this.Price3.AutoSize = true;
            this.Price3.Location = new System.Drawing.Point(86, 55);
            this.Price3.Name = "Price3";
            this.Price3.Size = new System.Drawing.Size(42, 13);
            this.Price3.TabIndex = 6;
            this.Price3.Text = "price: 5";
            // 
            // buy2
            // 
            this.buy2.Location = new System.Drawing.Point(152, 29);
            this.buy2.Name = "buy2";
            this.buy2.Size = new System.Drawing.Size(19, 20);
            this.buy2.TabIndex = 7;
            this.buy2.Text = "+";
            this.buy2.UseVisualStyleBackColor = true;
            this.buy2.Click += new System.EventHandler(this.buy2_Click);
            // 
            // buy3
            // 
            this.buy3.Location = new System.Drawing.Point(152, 55);
            this.buy3.Name = "buy3";
            this.buy3.Size = new System.Drawing.Size(19, 20);
            this.buy3.TabIndex = 8;
            this.buy3.Text = "+";
            this.buy3.UseVisualStyleBackColor = true;
            this.buy3.Click += new System.EventHandler(this.buy3_Click);
            // 
            // ItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buy3);
            this.Controls.Add(this.buy2);
            this.Controls.Add(this.Price3);
            this.Controls.Add(this.Price2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buy1);
            this.Controls.Add(this.Price1);
            this.Controls.Add(this.ItemName);
            this.Name = "ItemsView";
            this.Size = new System.Drawing.Size(174, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Label Price1;
        private System.Windows.Forms.Button buy1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Price2;
        private System.Windows.Forms.Label Price3;
        private System.Windows.Forms.Button buy2;
        private System.Windows.Forms.Button buy3;
    }
}
