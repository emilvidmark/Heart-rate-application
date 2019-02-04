namespace HeartRateApp
{
    partial class TrainingSessionControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.zonesControl1 = new HeartRateApp.ZonesControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(483, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // zonesControl1
            // 
            this.zonesControl1.Location = new System.Drawing.Point(427, 81);
            this.zonesControl1.Name = "zonesControl1";
            this.zonesControl1.Size = new System.Drawing.Size(264, 256);
            this.zonesControl1.TabIndex = 4;
            // 
            // TrainingSessionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.zonesControl1);
            this.Controls.Add(this.label1);
            this.Name = "TrainingSessionControl";
            this.Size = new System.Drawing.Size(1203, 782);
            this.Load += new System.EventHandler(this.TrainingSessionControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ZonesControl zonesControl1;
    }
}
