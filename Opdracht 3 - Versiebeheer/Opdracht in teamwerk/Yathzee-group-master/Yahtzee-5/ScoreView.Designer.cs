namespace Yahtzee_5
{
    partial class ScoreView
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
            this.labelScore = new System.Windows.Forms.Label();
            this.LabelTotalScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(3, 10);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "label1";
            this.labelScore.Click += new System.EventHandler(this.labelScore_Click);
            // 
            // LabelTotalScore
            // 
            this.LabelTotalScore.AutoSize = true;
            this.LabelTotalScore.Location = new System.Drawing.Point(3, 128);
            this.LabelTotalScore.Name = "LabelTotalScore";
            this.LabelTotalScore.Size = new System.Drawing.Size(35, 13);
            this.LabelTotalScore.TabIndex = 1;
            this.LabelTotalScore.Text = "label1";
            // 
            // ScoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelTotalScore);
            this.Controls.Add(this.labelScore);
            this.Name = "ScoreView";
            this.Load += new System.EventHandler(this.ScoreView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label LabelTotalScore;
    }
}
