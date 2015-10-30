namespace Yahtzee_5
{
    partial class ScoreboardView
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
            this.aantalWorpenLabel = new System.Windows.Forms.Label();
            this.aantalWorpenValueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maxWorpenLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aantalWorpenLabel
            // 
            this.aantalWorpenLabel.AutoSize = true;
            this.aantalWorpenLabel.Location = new System.Drawing.Point(14, 36);
            this.aantalWorpenLabel.Name = "aantalWorpenLabel";
            this.aantalWorpenLabel.Size = new System.Drawing.Size(78, 13);
            this.aantalWorpenLabel.TabIndex = 1;
            this.aantalWorpenLabel.Text = "Aantal worpen:";
            // 
            // aantalWorpenValueLabel
            // 
            this.aantalWorpenValueLabel.AutoSize = true;
            this.aantalWorpenValueLabel.Location = new System.Drawing.Point(94, 36);
            this.aantalWorpenValueLabel.Name = "aantalWorpenValueLabel";
            this.aantalWorpenValueLabel.Size = new System.Drawing.Size(13, 13);
            this.aantalWorpenValueLabel.TabIndex = 3;
            this.aantalWorpenValueLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "/";
            // 
            // maxWorpenLabel
            // 
            this.maxWorpenLabel.AutoSize = true;
            this.maxWorpenLabel.Location = new System.Drawing.Point(115, 36);
            this.maxWorpenLabel.Name = "maxWorpenLabel";
            this.maxWorpenLabel.Size = new System.Drawing.Size(13, 13);
            this.maxWorpenLabel.TabIndex = 5;
            this.maxWorpenLabel.Text = "0";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(14, 8);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(84, 20);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "YAHTZEE";
            // 
            // ScoreboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maxWorpenLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aantalWorpenValueLabel);
            this.Controls.Add(this.aantalWorpenLabel);
            this.Controls.Add(this.scoreLabel);
            this.Name = "ScoreboardView";
            this.Size = new System.Drawing.Size(150, 62);
            this.Load += new System.EventHandler(this.ScoreboardView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aantalWorpenLabel;
        private System.Windows.Forms.Label aantalWorpenValueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maxWorpenLabel;
        private System.Windows.Forms.Label scoreLabel;
    }
}
