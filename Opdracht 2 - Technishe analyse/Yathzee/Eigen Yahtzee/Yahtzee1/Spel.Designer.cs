namespace Yahtzee1
{
    partial class Spel
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
            this.buttonAll = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(12, 210);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(116, 39);
            this.buttonAll.TabIndex = 0;
            this.buttonAll.Text = "Roll All!";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(134, 223);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(47, 13);
            this.score.TabIndex = 1;
            this.score.Text = "Score: 0";
            this.score.Click += new System.EventHandler(this.label1_Click);
            // 
            // Spel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.score);
            this.Controls.Add(this.buttonAll);
            this.Name = "Spel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Label score;
    }
}

