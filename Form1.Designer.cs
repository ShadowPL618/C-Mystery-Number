namespace MysteryNumberJkra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btgStartGameJkra = new System.Windows.Forms.Button();
            this.cbxNoOfAttempstJkra = new System.Windows.Forms.ComboBox();
            this.tbxEndAtJkra = new System.Windows.Forms.TextBox();
            this.tbxStartAtJkra = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.GroupBox();
            this.btnGuessJkra = new System.Windows.Forms.Button();
            this.pgbAttemptsLeftJkra = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trbHotColdJkra = new System.Windows.Forms.TrackBar();
            this.tbxMyGuessJkra = new System.Windows.Forms.TextBox();
            this.lblWrongJkra = new System.Windows.Forms.Label();
            this.lbl0001 = new System.Windows.Forms.Label();
            this.lblAttemptsLeftJkra = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearJkra = new System.Windows.Forms.Button();
            this.btnSheatJkra = new System.Windows.Forms.Button();
            this.btnLocateJkra = new System.Windows.Forms.Button();
            this.btnAboutJkra = new System.Windows.Forms.Button();
            this.rtbInfoJkra = new System.Windows.Forms.RichTextBox();
            this.pbxStartScreenJkra = new System.Windows.Forms.PictureBox();
            this.btnShowGameJkra = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.Play.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbHotColdJkra)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStartScreenJkra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btgStartGameJkra);
            this.groupBox1.Controls.Add(this.cbxNoOfAttempstJkra);
            this.groupBox1.Controls.Add(this.tbxEndAtJkra);
            this.groupBox1.Controls.Add(this.tbxStartAtJkra);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(392, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set up";
            // 
            // btgStartGameJkra
            // 
            this.btgStartGameJkra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgStartGameJkra.Location = new System.Drawing.Point(308, 11);
            this.btgStartGameJkra.Margin = new System.Windows.Forms.Padding(4);
            this.btgStartGameJkra.Name = "btgStartGameJkra";
            this.btgStartGameJkra.Size = new System.Drawing.Size(73, 62);
            this.btgStartGameJkra.TabIndex = 7;
            this.btgStartGameJkra.Text = "GO!";
            this.btgStartGameJkra.UseVisualStyleBackColor = true;
            this.btgStartGameJkra.Click += new System.EventHandler(this.btgStartGameJkra_Click);
            // 
            // cbxNoOfAttempstJkra
            // 
            this.cbxNoOfAttempstJkra.FormattingEnabled = true;
            this.cbxNoOfAttempstJkra.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxNoOfAttempstJkra.Location = new System.Drawing.Point(167, 89);
            this.cbxNoOfAttempstJkra.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNoOfAttempstJkra.Name = "cbxNoOfAttempstJkra";
            this.cbxNoOfAttempstJkra.Size = new System.Drawing.Size(132, 24);
            this.cbxNoOfAttempstJkra.TabIndex = 6;
            // 
            // tbxEndAtJkra
            // 
            this.tbxEndAtJkra.Location = new System.Drawing.Point(167, 48);
            this.tbxEndAtJkra.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEndAtJkra.Name = "tbxEndAtJkra";
            this.tbxEndAtJkra.Size = new System.Drawing.Size(132, 22);
            this.tbxEndAtJkra.TabIndex = 5;
            // 
            // tbxStartAtJkra
            // 
            this.tbxStartAtJkra.Location = new System.Drawing.Point(167, 15);
            this.tbxStartAtJkra.Margin = new System.Windows.Forms.Padding(4);
            this.tbxStartAtJkra.Name = "tbxStartAtJkra";
            this.tbxStartAtJkra.Size = new System.Drawing.Size(132, 22);
            this.tbxStartAtJkra.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(75, 0);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of attempts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stop at:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start at:";
            // 
            // Play
            // 
            this.Play.Controls.Add(this.btnGuessJkra);
            this.Play.Controls.Add(this.pgbAttemptsLeftJkra);
            this.Play.Controls.Add(this.label9);
            this.Play.Controls.Add(this.label8);
            this.Play.Controls.Add(this.trbHotColdJkra);
            this.Play.Controls.Add(this.tbxMyGuessJkra);
            this.Play.Controls.Add(this.lblWrongJkra);
            this.Play.Controls.Add(this.lbl0001);
            this.Play.Controls.Add(this.lblAttemptsLeftJkra);
            this.Play.Controls.Add(this.label7);
            this.Play.Controls.Add(this.label6);
            this.Play.Controls.Add(this.label5);
            this.Play.Controls.Add(this.label4);
            this.Play.Location = new System.Drawing.Point(17, 148);
            this.Play.Margin = new System.Windows.Forms.Padding(4);
            this.Play.Name = "Play";
            this.Play.Padding = new System.Windows.Forms.Padding(4);
            this.Play.Size = new System.Drawing.Size(392, 187);
            this.Play.TabIndex = 1;
            this.Play.TabStop = false;
            this.Play.Text = "Play";
            // 
            // btnGuessJkra
            // 
            this.btnGuessJkra.Location = new System.Drawing.Point(167, 66);
            this.btnGuessJkra.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuessJkra.Name = "btnGuessJkra";
            this.btnGuessJkra.Size = new System.Drawing.Size(139, 28);
            this.btnGuessJkra.TabIndex = 12;
            this.btnGuessJkra.Text = "Guess";
            this.btnGuessJkra.UseVisualStyleBackColor = true;
            this.btnGuessJkra.Click += new System.EventHandler(this.btnGuessJkra_Click);
            // 
            // pgbAttemptsLeftJkra
            // 
            this.pgbAttemptsLeftJkra.Location = new System.Drawing.Point(116, 105);
            this.pgbAttemptsLeftJkra.Margin = new System.Windows.Forms.Padding(4);
            this.pgbAttemptsLeftJkra.Name = "pgbAttemptsLeftJkra";
            this.pgbAttemptsLeftJkra.Size = new System.Drawing.Size(184, 28);
            this.pgbAttemptsLeftJkra.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(297, 153);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "COLD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(308, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "HOT";
            // 
            // trbHotColdJkra
            // 
            this.trbHotColdJkra.Location = new System.Drawing.Point(313, 44);
            this.trbHotColdJkra.Margin = new System.Windows.Forms.Padding(4);
            this.trbHotColdJkra.Name = "trbHotColdJkra";
            this.trbHotColdJkra.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbHotColdJkra.Size = new System.Drawing.Size(56, 105);
            this.trbHotColdJkra.TabIndex = 8;
            // 
            // tbxMyGuessJkra
            // 
            this.tbxMyGuessJkra.Location = new System.Drawing.Point(167, 25);
            this.tbxMyGuessJkra.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMyGuessJkra.Name = "tbxMyGuessJkra";
            this.tbxMyGuessJkra.Size = new System.Drawing.Size(132, 22);
            this.tbxMyGuessJkra.TabIndex = 7;
            this.tbxMyGuessJkra.TextChanged += new System.EventHandler(this.tbxMyGuessJkra_TextChanged);
            // 
            // lblWrongJkra
            // 
            this.lblWrongJkra.AutoSize = true;
            this.lblWrongJkra.Location = new System.Drawing.Point(249, 153);
            this.lblWrongJkra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWrongJkra.Name = "lblWrongJkra";
            this.lblWrongJkra.Size = new System.Drawing.Size(15, 16);
            this.lblWrongJkra.TabIndex = 6;
            this.lblWrongJkra.Text = "--";
            // 
            // lbl0001
            // 
            this.lbl0001.AutoSize = true;
            this.lbl0001.Location = new System.Drawing.Point(193, 153);
            this.lbl0001.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl0001.Name = "lbl0001";
            this.lbl0001.Size = new System.Drawing.Size(43, 16);
            this.lbl0001.TabIndex = 5;
            this.lbl0001.Text = "wrong";
            // 
            // lblAttemptsLeftJkra
            // 
            this.lblAttemptsLeftJkra.AutoSize = true;
            this.lblAttemptsLeftJkra.Location = new System.Drawing.Point(59, 153);
            this.lblAttemptsLeftJkra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttemptsLeftJkra.Name = "lblAttemptsLeftJkra";
            this.lblAttemptsLeftJkra.Size = new System.Drawing.Size(15, 16);
            this.lblAttemptsLeftJkra.TabIndex = 4;
            this.lblAttemptsLeftJkra.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Left";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Attempts left:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "My Guess:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearJkra);
            this.groupBox2.Controls.Add(this.btnSheatJkra);
            this.groupBox2.Controls.Add(this.btnLocateJkra);
            this.groupBox2.Controls.Add(this.btnAboutJkra);
            this.groupBox2.Controls.Add(this.rtbInfoJkra);
            this.groupBox2.Location = new System.Drawing.Point(17, 343);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(392, 196);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // btnClearJkra
            // 
            this.btnClearJkra.Location = new System.Drawing.Point(263, 155);
            this.btnClearJkra.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearJkra.Name = "btnClearJkra";
            this.btnClearJkra.Size = new System.Drawing.Size(77, 28);
            this.btnClearJkra.TabIndex = 4;
            this.btnClearJkra.Text = "Clear";
            this.btnClearJkra.UseVisualStyleBackColor = true;
            this.btnClearJkra.Click += new System.EventHandler(this.btnClearJkra_Click);
            // 
            // btnSheatJkra
            // 
            this.btnSheatJkra.Location = new System.Drawing.Point(177, 155);
            this.btnSheatJkra.Margin = new System.Windows.Forms.Padding(4);
            this.btnSheatJkra.Name = "btnSheatJkra";
            this.btnSheatJkra.Size = new System.Drawing.Size(77, 28);
            this.btnSheatJkra.TabIndex = 3;
            this.btnSheatJkra.Text = "Cheat";
            this.btnSheatJkra.UseVisualStyleBackColor = true;
            this.btnSheatJkra.Click += new System.EventHandler(this.btnSheatJkra_Click);
            // 
            // btnLocateJkra
            // 
            this.btnLocateJkra.Location = new System.Drawing.Point(92, 155);
            this.btnLocateJkra.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocateJkra.Name = "btnLocateJkra";
            this.btnLocateJkra.Size = new System.Drawing.Size(77, 28);
            this.btnLocateJkra.TabIndex = 2;
            this.btnLocateJkra.Text = "Locate";
            this.btnLocateJkra.UseVisualStyleBackColor = true;
            // 
            // btnAboutJkra
            // 
            this.btnAboutJkra.Location = new System.Drawing.Point(7, 155);
            this.btnAboutJkra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAboutJkra.Name = "btnAboutJkra";
            this.btnAboutJkra.Size = new System.Drawing.Size(77, 28);
            this.btnAboutJkra.TabIndex = 1;
            this.btnAboutJkra.Text = "About";
            this.btnAboutJkra.UseVisualStyleBackColor = true;
            this.btnAboutJkra.Click += new System.EventHandler(this.btnAboutJkra_Click);
            // 
            // rtbInfoJkra
            // 
            this.rtbInfoJkra.Location = new System.Drawing.Point(0, 25);
            this.rtbInfoJkra.Margin = new System.Windows.Forms.Padding(4);
            this.rtbInfoJkra.Name = "rtbInfoJkra";
            this.rtbInfoJkra.Size = new System.Drawing.Size(383, 122);
            this.rtbInfoJkra.TabIndex = 0;
            this.rtbInfoJkra.Text = "";
            // 
            // pbxStartScreenJkra
            // 
            this.pbxStartScreenJkra.Image = ((System.Drawing.Image)(resources.GetObject("pbxStartScreenJkra.Image")));
            this.pbxStartScreenJkra.Location = new System.Drawing.Point(417, 16);
            this.pbxStartScreenJkra.Margin = new System.Windows.Forms.Padding(4);
            this.pbxStartScreenJkra.Name = "pbxStartScreenJkra";
            this.pbxStartScreenJkra.Size = new System.Drawing.Size(404, 523);
            this.pbxStartScreenJkra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxStartScreenJkra.TabIndex = 3;
            this.pbxStartScreenJkra.TabStop = false;
            // 
            // btnShowGameJkra
            // 
            this.btnShowGameJkra.Location = new System.Drawing.Point(549, 481);
            this.btnShowGameJkra.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowGameJkra.Name = "btnShowGameJkra";
            this.btnShowGameJkra.Size = new System.Drawing.Size(144, 46);
            this.btnShowGameJkra.TabIndex = 4;
            this.btnShowGameJkra.Text = "Show the game!";
            this.btnShowGameJkra.UseVisualStyleBackColor = true;
            this.btnShowGameJkra.Click += new System.EventHandler(this.btnShowGameSgem_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 554);
            this.Controls.Add(this.btnShowGameJkra);
            this.Controls.Add(this.pbxStartScreenJkra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MysteryNumber Juliusz Krajewski";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Play.ResumeLayout(false);
            this.Play.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbHotColdJkra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxStartScreenJkra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btgStartGameJkra;
        private System.Windows.Forms.ComboBox cbxNoOfAttempstJkra;
        private System.Windows.Forms.TextBox tbxEndAtJkra;
        private System.Windows.Forms.TextBox tbxStartAtJkra;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Play;
        private System.Windows.Forms.TrackBar trbHotColdJkra;
        private System.Windows.Forms.TextBox tbxMyGuessJkra;
        private System.Windows.Forms.Label lblWrongJkra;
        private System.Windows.Forms.Label lbl0001;
        private System.Windows.Forms.Label lblAttemptsLeftJkra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearJkra;
        private System.Windows.Forms.Button btnSheatJkra;
        private System.Windows.Forms.Button btnLocateJkra;
        private System.Windows.Forms.Button btnAboutJkra;
        private System.Windows.Forms.RichTextBox rtbInfoJkra;
        private System.Windows.Forms.PictureBox pbxStartScreenJkra;
        private System.Windows.Forms.Button btnShowGameJkra;
        private System.Windows.Forms.Button btnGuessJkra;
        private System.Windows.Forms.ProgressBar pgbAttemptsLeftJkra;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

