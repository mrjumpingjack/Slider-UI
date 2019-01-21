namespace SliderUI_
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_break = new System.Windows.Forms.TextBox();
            this.tb_speed = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tb_serial = new System.Windows.Forms.TextBox();
            this.btn_serialconnect = new System.Windows.Forms.Button();
            this.cb_serialport = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_max
            // 
            this.btn_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_max.Location = new System.Drawing.Point(252, 15);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(238, 129);
            this.btn_max.TabIndex = 27;
            this.btn_max.Text = "GO MAX";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_min
            // 
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.Location = new System.Drawing.Point(8, 15);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(238, 129);
            this.btn_min.TabIndex = 26;
            this.btn_min.Text = "GO MIN";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 100);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 627);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_break);
            this.tabPage1.Controls.Add(this.tb_speed);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btn_min);
            this.tabPage1.Controls.Add(this.btn_max);
            this.tabPage1.Location = new System.Drawing.Point(4, 104);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1052, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 39);
            this.label2.TabIndex = 78;
            this.label2.Text = "Acceleration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 39);
            this.label1.TabIndex = 77;
            this.label1.Text = "Speed";
            // 
            // tb_break
            // 
            this.tb_break.Location = new System.Drawing.Point(549, 261);
            this.tb_break.Name = "tb_break";
            this.tb_break.Size = new System.Drawing.Size(255, 45);
            this.tb_break.TabIndex = 76;
            this.tb_break.Text = "1000";
            // 
            // tb_speed
            // 
            this.tb_speed.Location = new System.Drawing.Point(549, 93);
            this.tb_speed.Name = "tb_speed";
            this.tb_speed.Size = new System.Drawing.Size(255, 45);
            this.tb_speed.TabIndex = 75;
            this.tb_speed.Text = "10000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 58);
            this.button1.TabIndex = 72;
            this.button1.Text = "v";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 61);
            this.button2.TabIndex = 71;
            this.button2.Text = "^";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 39);
            this.label3.TabIndex = 70;
            this.label3.Text = "Laps";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(24, 275);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(102, 45);
            this.numericUpDown1.TabIndex = 69;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 126);
            this.button3.TabIndex = 68;
            this.button3.Text = "Pendeln";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tb_serial);
            this.tabPage4.Controls.Add(this.btn_serialconnect);
            this.tabPage4.Controls.Add(this.cb_serialport);
            this.tabPage4.Location = new System.Drawing.Point(4, 104);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1052, 519);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tb_serial
            // 
            this.tb_serial.Location = new System.Drawing.Point(9, 151);
            this.tb_serial.Multiline = true;
            this.tb_serial.Name = "tb_serial";
            this.tb_serial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_serial.Size = new System.Drawing.Size(1035, 360);
            this.tb_serial.TabIndex = 3;
            // 
            // btn_serialconnect
            // 
            this.btn_serialconnect.Location = new System.Drawing.Point(706, 19);
            this.btn_serialconnect.Name = "btn_serialconnect";
            this.btn_serialconnect.Size = new System.Drawing.Size(338, 106);
            this.btn_serialconnect.TabIndex = 3;
            this.btn_serialconnect.Text = "Connect";
            this.btn_serialconnect.UseVisualStyleBackColor = true;
            this.btn_serialconnect.Click += new System.EventHandler(this.btn_serialconnect_Click);
            // 
            // cb_serialport
            // 
            this.cb_serialport.FormattingEnabled = true;
            this.cb_serialport.Location = new System.Drawing.Point(9, 50);
            this.cb_serialport.Name = "cb_serialport";
            this.cb_serialport.Size = new System.Drawing.Size(667, 46);
            this.cb_serialport.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 627);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_serialconnect;
        private System.Windows.Forms.ComboBox cb_serialport;
        private System.Windows.Forms.TextBox tb_serial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_break;
        private System.Windows.Forms.TextBox tb_speed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button3;
    }
}

