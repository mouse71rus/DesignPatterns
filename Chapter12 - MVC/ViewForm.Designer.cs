namespace Chapter12.MVC
{
    partial class ViewForm
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
            this.BeatBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentBPM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BeatBar
            // 
            this.BeatBar.Location = new System.Drawing.Point(12, 12);
            this.BeatBar.Name = "BeatBar";
            this.BeatBar.Size = new System.Drawing.Size(336, 26);
            this.BeatBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "BPM:";
            // 
            // CurrentBPM
            // 
            this.CurrentBPM.AutoSize = true;
            this.CurrentBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentBPM.Location = new System.Drawing.Point(82, 51);
            this.CurrentBPM.Name = "CurrentBPM";
            this.CurrentBPM.Size = new System.Drawing.Size(24, 25);
            this.CurrentBPM.TabIndex = 2;
            this.CurrentBPM.Text = "0";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 85);
            this.Controls.Add(this.CurrentBPM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BeatBar);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar BeatBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentBPM;
    }
}