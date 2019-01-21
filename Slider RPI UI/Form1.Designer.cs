namespace Slider_RPI_UI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_goto = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.tbstop = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.tbstart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.l_connstat = new System.Windows.Forms.Label();
            this.tb_delaytime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_manuel = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 507);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.tb_goto);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 60);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Goto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cb_manuel);
            this.tabPage2.Controls.Add(this.tb_delaytime);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.trackBar2);
            this.tabPage2.Controls.Add(this.tbstart);
            this.tabPage2.Controls.Add(this.tbstop);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Location = new System.Drawing.Point(4, 60);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Timelapse";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.l_connstat);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Location = new System.Drawing.Point(4, 60);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(919, 443);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Extra";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button1.Location = new System.Drawing.Point(330, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 105);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_goto
            // 
            this.tb_goto.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.tb_goto.Location = new System.Drawing.Point(18, 37);
            this.tb_goto.Name = "tb_goto";
            this.tb_goto.Size = new System.Drawing.Size(296, 56);
            this.tb_goto.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(18, 203);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(888, 45);
            this.trackBar1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(18, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Speed";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button2.Location = new System.Drawing.Point(533, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 105);
            this.button2.TabIndex = 7;
            this.button2.Text = "MIN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button3.Location = new System.Drawing.Point(727, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 105);
            this.button3.TabIndex = 8;
            this.button3.Text = "MAX";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button4.Location = new System.Drawing.Point(481, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 57);
            this.button4.TabIndex = 14;
            this.button4.Text = "MAX";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button5.Location = new System.Drawing.Point(68, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 57);
            this.button5.TabIndex = 13;
            this.button5.Text = "MIN";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(8, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Speed";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(15, 378);
            this.trackBar2.Maximum = 50;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(855, 45);
            this.trackBar2.TabIndex = 11;
            // 
            // tbstop
            // 
            this.tbstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.tbstop.Location = new System.Drawing.Point(409, 29);
            this.tbstop.Name = "tbstop";
            this.tbstop.Size = new System.Drawing.Size(296, 56);
            this.tbstop.TabIndex = 10;
            this.tbstop.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button6.Location = new System.Drawing.Point(732, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 105);
            this.button6.TabIndex = 9;
            this.button6.Text = "Go";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tbstart
            // 
            this.tbstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.tbstart.Location = new System.Drawing.Point(15, 29);
            this.tbstart.Name = "tbstart";
            this.tbstart.Size = new System.Drawing.Size(296, 56);
            this.tbstart.TabIndex = 10;
            this.tbstart.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.Location = new System.Drawing.Point(332, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "->";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.textBox5.Location = new System.Drawing.Point(21, 13);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(694, 56);
            this.textBox5.TabIndex = 18;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button9.Location = new System.Drawing.Point(721, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(179, 75);
            this.button9.TabIndex = 16;
            this.button9.Text = "SEND";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button7.Location = new System.Drawing.Point(631, 336);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(269, 75);
            this.button7.TabIndex = 19;
            this.button7.Text = "GET BOUNDS";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.textBox4.Location = new System.Drawing.Point(21, 142);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(360, 56);
            this.textBox4.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.textBox6.Location = new System.Drawing.Point(401, 142);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(306, 56);
            this.textBox6.TabIndex = 21;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button8.Location = new System.Drawing.Point(721, 129);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(179, 75);
            this.button8.TabIndex = 16;
            this.button8.Text = "SEND";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // l_connstat
            // 
            this.l_connstat.AutoSize = true;
            this.l_connstat.Location = new System.Drawing.Point(12, 374);
            this.l_connstat.Name = "l_connstat";
            this.l_connstat.Size = new System.Drawing.Size(145, 51);
            this.l_connstat.TabIndex = 22;
            this.l_connstat.Text = "Status";
            this.l_connstat.Click += new System.EventHandler(this.l_connstat_Click);
            // 
            // tb_delaytime
            // 
            this.tb_delaytime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.tb_delaytime.Location = new System.Drawing.Point(15, 241);
            this.tb_delaytime.Name = "tb_delaytime";
            this.tb_delaytime.Size = new System.Drawing.Size(296, 56);
            this.tb_delaytime.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.Location = new System.Drawing.Point(8, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Delay";
            // 
            // cb_manuel
            // 
            this.cb_manuel.AutoSize = true;
            this.cb_manuel.Location = new System.Drawing.Point(361, 241);
            this.cb_manuel.Name = "cb_manuel";
            this.cb_manuel.Size = new System.Drawing.Size(183, 55);
            this.cb_manuel.TabIndex = 17;
            this.cb_manuel.Text = "Manuel";
            this.cb_manuel.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(377, 59);
            this.comboBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_goto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox tbstop;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbstart;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label l_connstat;
        private System.Windows.Forms.TextBox tb_delaytime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_manuel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

