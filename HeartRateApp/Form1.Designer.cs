namespace HeartRateApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.import_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.training_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalsControl1 = new HeartRateApp.TotalsControl();
            this.manualRegistration1 = new HeartRateApp.ManualRegistration();
            this.training1 = new HeartRateApp.training();
            this.importHrm1 = new HeartRateApp.ImportHrm();
            this.startsida = new HeartRateApp.Start();
            this.label1 = new System.Windows.Forms.Label();
            this.picker = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.picker);
            this.panel1.Controls.Add(this.import_button);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.training_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 859);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 59);
            this.button3.TabIndex = 7;
            this.button3.Text = "Registrera träning";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 797);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Avsluta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // import_button
            // 
            this.import_button.FlatAppearance.BorderSize = 0;
            this.import_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_button.ForeColor = System.Drawing.Color.White;
            this.import_button.Location = new System.Drawing.Point(0, 272);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(200, 59);
            this.import_button.TabIndex = 5;
            this.import_button.Text = "Importera fil";
            this.import_button.UseVisualStyleBackColor = true;
            this.import_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "Totaler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // training_button
            // 
            this.training_button.FlatAppearance.BorderSize = 0;
            this.training_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.training_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.training_button.ForeColor = System.Drawing.Color.White;
            this.training_button.Location = new System.Drawing.Point(0, 77);
            this.training_button.Name = "training_button";
            this.training_button.Size = new System.Drawing.Size(200, 59);
            this.training_button.TabIndex = 3;
            this.training_button.Text = "Träning";
            this.training_button.UseVisualStyleBackColor = true;
            this.training_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1203, 16);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.totalsControl1);
            this.panel3.Controls.Add(this.manualRegistration1);
            this.panel3.Controls.Add(this.training1);
            this.panel3.Controls.Add(this.importHrm1);
            this.panel3.Controls.Add(this.startsida);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1203, 782);
            this.panel3.TabIndex = 5;
            // 
            // totalsControl1
            // 
            this.totalsControl1.Location = new System.Drawing.Point(0, -14);
            this.totalsControl1.Name = "totalsControl1";
            this.totalsControl1.Size = new System.Drawing.Size(1203, 796);
            this.totalsControl1.TabIndex = 4;
            // 
            // manualRegistration1
            // 
            this.manualRegistration1.Location = new System.Drawing.Point(0, -12);
            this.manualRegistration1.Name = "manualRegistration1";
            this.manualRegistration1.Size = new System.Drawing.Size(1203, 796);
            this.manualRegistration1.TabIndex = 3;
            // 
            // training1
            // 
            this.training1.AutoScroll = true;
            this.training1.Location = new System.Drawing.Point(0, -12);
            this.training1.Name = "training1";
            this.training1.Size = new System.Drawing.Size(1203, 794);
            this.training1.TabIndex = 2;
            // 
            // importHrm1
            // 
            this.importHrm1.Location = new System.Drawing.Point(-3, -12);
            this.importHrm1.Name = "importHrm1";
            this.importHrm1.Size = new System.Drawing.Size(1203, 794);
            this.importHrm1.TabIndex = 1;
            // 
            // startsida
            // 
            this.startsida.BackColor = System.Drawing.Color.White;
            this.startsida.Location = new System.Drawing.Point(0, -12);
            this.startsida.Name = "startsida";
            this.startsida.Size = new System.Drawing.Size(1203, 794);
            this.startsida.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(631, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Träningsdata: Emil Vidmark";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picker
            // 
            this.picker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.picker.Location = new System.Drawing.Point(0, 77);
            this.picker.Name = "picker";
            this.picker.Size = new System.Drawing.Size(10, 59);
            this.picker.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1403, 859);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button training_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Start startsida;
        private System.Windows.Forms.Button import_button;
        private ImportHrm importHrm1;
        private training training1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private ManualRegistration manualRegistration1;
        private TotalsControl totalsControl1;
        private System.Windows.Forms.Panel picker;
    }
}

