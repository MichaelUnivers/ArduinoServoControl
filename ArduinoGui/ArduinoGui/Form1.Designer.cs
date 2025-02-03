namespace ArduinoGui
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pokretlo1 = new KnobControl.KnobControl();
            this.label1 = new System.Windows.Forms.Label();
            this.zadajbox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.RtsEnable = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ArduinoGui.Properties.Resources.Adobe_Express___file__6_;
            this.pictureBox2.Location = new System.Drawing.Point(856, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 352);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pokretlo1
            // 
            this.pokretlo1.EndAngle = 330F;
            this.pokretlo1.ForeColor = System.Drawing.Color.Lime;
            this.pokretlo1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pokretlo1.KnobBackColor = System.Drawing.Color.DarkCyan;
            this.pokretlo1.KnobPointerStyle = KnobControl.KnobControl.KnobPointerStyles.circle;
            this.pokretlo1.LargeChange = 5;
            this.pokretlo1.Location = new System.Drawing.Point(452, 278);
            this.pokretlo1.Maximum = 60;
            this.pokretlo1.Minimum = -60;
            this.pokretlo1.MouseWheelBarPartitions = 120;
            this.pokretlo1.Name = "pokretlo1";
            this.pokretlo1.PointerColor = System.Drawing.Color.GhostWhite;
            this.pokretlo1.ScaleColor = System.Drawing.Color.Lime;
            this.pokretlo1.ScaleDivisions = 9;
            this.pokretlo1.ScaleFont = new System.Drawing.Font("Razer Header Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokretlo1.ScaleFontAutoSize = false;
            this.pokretlo1.ScaleSubDivisions = 4;
            this.pokretlo1.ShowLargeScale = true;
            this.pokretlo1.ShowSmallScale = true;
            this.pokretlo1.Size = new System.Drawing.Size(267, 267);
            this.pokretlo1.SmallChange = 1;
            this.pokretlo1.StartAngle = 210F;
            this.pokretlo1.TabIndex = 2;
            this.pokretlo1.UseWaitCursor = true;
            this.pokretlo1.Value = 0;
            this.pokretlo1.Load += new System.EventHandler(this.knobControl1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Razer Header Regular", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(463, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Orientacja serwa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // zadajbox1
            // 
            this.zadajbox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.zadajbox1.Font = new System.Drawing.Font("Razer Header Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zadajbox1.ForeColor = System.Drawing.Color.Lime;
            this.zadajbox1.Location = new System.Drawing.Point(213, 421);
            this.zadajbox1.MaxLength = 3;
            this.zadajbox1.Name = "zadajbox1";
            this.zadajbox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zadajbox1.Size = new System.Drawing.Size(41, 27);
            this.zadajbox1.TabIndex = 4;
            this.zadajbox1.TextChanged += new System.EventHandler(this.zadajbox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(260, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "°";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Razer Header Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(31, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kat zadany serwa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(32, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "ARDUINO servo control\r\n\r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(1164, 709);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "v1.0.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(32, 104);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "WCZYTAJ PORT SZEREGOWY...\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(32, 146);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "SUKCES...";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(205, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Wykonaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(32, 117);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "USTANOWIONO COM3...\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(32, 133);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(246, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "TEST POŁĄCZENIA PORTU SZEREGOWEGO...";
            this.label9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1207, 731);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zadajbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pokretlo1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zadajbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private KnobControl.KnobControl pokretlo1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

