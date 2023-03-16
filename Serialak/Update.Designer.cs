namespace Serialak
{
    partial class Update
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.n_odc = new System.Windows.Forms.NumericUpDown();
            this.n_sez = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cBox = new System.Windows.Forms.ComboBox();
            this.Cbox_IMG = new System.Windows.Forms.CheckBox();
            this.Cbox_Link = new System.Windows.Forms.CheckBox();
            this.Cbox_status = new System.Windows.Forms.CheckBox();
            this.Tbox_IMG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbox_Link = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Radio_end = new System.Windows.Forms.RadioButton();
            this.Radio_watch = new System.Windows.Forms.RadioButton();
            this.Loadfile = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.Check_out = new System.Windows.Forms.CheckBox();
            this.c_box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBox_sezony = new System.Windows.Forms.CheckBox();
            this.num_sez = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.n_odc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_sez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sez)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(12, 92);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(216, 32);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Który odcinek?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(317, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Który sezon?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(662, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aktualizuj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // n_odc
            // 
            this.n_odc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.n_odc.Location = new System.Drawing.Point(36, 134);
            this.n_odc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_odc.Name = "n_odc";
            this.n_odc.Size = new System.Drawing.Size(180, 35);
            this.n_odc.TabIndex = 3;
            this.n_odc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // n_sez
            // 
            this.n_sez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.n_sez.Location = new System.Drawing.Point(308, 134);
            this.n_sez.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_sez.Name = "n_sez";
            this.n_sez.Size = new System.Drawing.Size(180, 35);
            this.n_sez.TabIndex = 4;
            this.n_sez.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(167, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wybierz serial";
            // 
            // cBox
            // 
            this.cBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cBox.FormattingEnabled = true;
            this.cBox.Location = new System.Drawing.Point(36, 45);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(452, 40);
            this.cBox.TabIndex = 6;
            this.cBox.SelectedIndexChanged += new System.EventHandler(this.CBox_SelectedIndexChanged);
            // 
            // Cbox_IMG
            // 
            this.Cbox_IMG.AutoSize = true;
            this.Cbox_IMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Cbox_IMG.Location = new System.Drawing.Point(669, 12);
            this.Cbox_IMG.Name = "Cbox_IMG";
            this.Cbox_IMG.Size = new System.Drawing.Size(274, 36);
            this.Cbox_IMG.TabIndex = 7;
            this.Cbox_IMG.Text = "Zmień miniaturkę";
            this.Cbox_IMG.UseVisualStyleBackColor = true;
            this.Cbox_IMG.CheckedChanged += new System.EventHandler(this.Cbox_IMG_CheckedChanged);
            // 
            // Cbox_Link
            // 
            this.Cbox_Link.AutoSize = true;
            this.Cbox_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Cbox_Link.Location = new System.Drawing.Point(669, 54);
            this.Cbox_Link.Name = "Cbox_Link";
            this.Cbox_Link.Size = new System.Drawing.Size(180, 36);
            this.Cbox_Link.TabIndex = 8;
            this.Cbox_Link.Text = "Zmień link";
            this.Cbox_Link.UseVisualStyleBackColor = true;
            this.Cbox_Link.CheckedChanged += new System.EventHandler(this.Cbox_Link_CheckedChanged);
            // 
            // Cbox_status
            // 
            this.Cbox_status.AutoSize = true;
            this.Cbox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Cbox_status.Location = new System.Drawing.Point(670, 96);
            this.Cbox_status.Name = "Cbox_status";
            this.Cbox_status.Size = new System.Drawing.Size(214, 36);
            this.Cbox_status.TabIndex = 9;
            this.Cbox_status.Text = "Zmień status";
            this.Cbox_status.UseVisualStyleBackColor = true;
            this.Cbox_status.CheckedChanged += new System.EventHandler(this.Cbox_status_CheckedChanged);
            // 
            // Tbox_IMG
            // 
            this.Tbox_IMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Tbox_IMG.Location = new System.Drawing.Point(33, 240);
            this.Tbox_IMG.Name = "Tbox_IMG";
            this.Tbox_IMG.Size = new System.Drawing.Size(452, 39);
            this.Tbox_IMG.TabIndex = 10;
            this.Tbox_IMG.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Miniaturka (Link albo lokalizacja)";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Link";
            this.label4.Visible = false;
            // 
            // Tbox_Link
            // 
            this.Tbox_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Tbox_Link.Location = new System.Drawing.Point(36, 342);
            this.Tbox_Link.Name = "Tbox_Link";
            this.Tbox_Link.Size = new System.Drawing.Size(452, 39);
            this.Tbox_Link.TabIndex = 19;
            this.Tbox_Link.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(663, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Status";
            this.label5.Visible = false;
            // 
            // Radio_end
            // 
            this.Radio_end.AutoSize = true;
            this.Radio_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Radio_end.Location = new System.Drawing.Point(669, 253);
            this.Radio_end.Name = "Radio_end";
            this.Radio_end.Size = new System.Drawing.Size(189, 36);
            this.Radio_end.TabIndex = 21;
            this.Radio_end.TabStop = true;
            this.Radio_end.Text = "Skończone";
            this.Radio_end.UseVisualStyleBackColor = true;
            this.Radio_end.Visible = false;
            // 
            // Radio_watch
            // 
            this.Radio_watch.AutoSize = true;
            this.Radio_watch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Radio_watch.Location = new System.Drawing.Point(894, 253);
            this.Radio_watch.Name = "Radio_watch";
            this.Radio_watch.Size = new System.Drawing.Size(172, 36);
            this.Radio_watch.TabIndex = 22;
            this.Radio_watch.TabStop = true;
            this.Radio_watch.Text = "Oglądane";
            this.Radio_watch.UseVisualStyleBackColor = true;
            this.Radio_watch.Visible = false;
            // 
            // button2
            // 
            this.button2.Image = global::Serialak.Properties.Resources.icons8_file_folder_481;
            this.button2.Location = new System.Drawing.Point(491, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 49);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Check_out
            // 
            this.Check_out.AutoSize = true;
            this.Check_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Check_out.Location = new System.Drawing.Point(669, 132);
            this.Check_out.Name = "Check_out";
            this.Check_out.Size = new System.Drawing.Size(301, 36);
            this.Check_out.TabIndex = 24;
            this.Check_out.Text = "Aktualnie wychodzi";
            this.Check_out.UseVisualStyleBackColor = true;
            this.Check_out.CheckedChanged += new System.EventHandler(this.Check_out_CheckedChanged);
            // 
            // c_box
            // 
            this.c_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.c_box.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.c_box.Items.AddRange(new object[] {
            "Poniedziałek",
            "Wtorek",
            "Środa",
            "Czwartek",
            "Piątek",
            "Sobota",
            "Niedziela"});
            this.c_box.Location = new System.Drawing.Point(734, 342);
            this.c_box.Name = "c_box";
            this.c_box.Size = new System.Drawing.Size(224, 40);
            this.c_box.TabIndex = 25;
            this.c_box.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(791, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "Kiedy?";
            this.label6.Visible = false;
            // 
            // cBox_sezony
            // 
            this.cBox_sezony.AutoSize = true;
            this.cBox_sezony.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cBox_sezony.Location = new System.Drawing.Point(669, 174);
            this.cBox_sezony.Name = "cBox_sezony";
            this.cBox_sezony.Size = new System.Drawing.Size(322, 36);
            this.cBox_sezony.TabIndex = 27;
            this.cBox_sezony.Text = "Zmień ilość sezonów";
            this.cBox_sezony.UseVisualStyleBackColor = true;
            this.cBox_sezony.CheckedChanged += new System.EventHandler(this.CBox_sezony_CheckedChanged);
            // 
            // num_sez
            // 
            this.num_sez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_sez.Location = new System.Drawing.Point(173, 450);
            this.num_sez.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_sez.Name = "num_sez";
            this.num_sez.Size = new System.Drawing.Size(180, 35);
            this.num_sez.TabIndex = 28;
            this.num_sez.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_sez.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(169, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 32);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ilość sezonów";
            this.label7.Visible = false;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1058, 520);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.num_sez);
            this.Controls.Add(this.cBox_sezony);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.c_box);
            this.Controls.Add(this.Check_out);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Radio_watch);
            this.Controls.Add(this.Radio_end);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tbox_Link);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tbox_IMG);
            this.Controls.Add(this.Cbox_status);
            this.Controls.Add(this.Cbox_Link);
            this.Controls.Add(this.Cbox_IMG);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_sez);
            this.Controls.Add(this.n_odc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.ForeColor = System.Drawing.Color.GhostWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Update";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.n_odc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_sez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown n_odc;
        private System.Windows.Forms.NumericUpDown n_sez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBox;
        private System.Windows.Forms.CheckBox Cbox_IMG;
        private System.Windows.Forms.CheckBox Cbox_Link;
        private System.Windows.Forms.CheckBox Cbox_status;
        private System.Windows.Forms.TextBox Tbox_IMG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tbox_Link;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Radio_end;
        private System.Windows.Forms.RadioButton Radio_watch;
        private System.Windows.Forms.OpenFileDialog Loadfile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox Check_out;
        private System.Windows.Forms.ComboBox c_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cBox_sezony;
        private System.Windows.Forms.NumericUpDown num_sez;
        private System.Windows.Forms.Label label7;
    }
}