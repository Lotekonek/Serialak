namespace Serialak
{
    partial class Dodawanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_S = new System.Windows.Forms.Label();
            this.ch_box = new System.Windows.Forms.CheckBox();
            this.lbl_dzien = new System.Windows.Forms.Label();
            this.c_box = new System.Windows.Forms.ComboBox();
            this.tBox_nazwa = new System.Windows.Forms.TextBox();
            this.tBox_Link = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ilosc_Sezony = new System.Windows.Forms.NumericUpDown();
            this.Btn_dodaj = new System.Windows.Forms.Button();
            this.cBox_IMG = new System.Windows.Forms.CheckBox();
            this.tBox_IMG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Loadfile = new System.Windows.Forms.OpenFileDialog();
            this.IMAGE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ilosc_Sezony)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa";
            // 
            // lbl_S
            // 
            this.lbl_S.AutoSize = true;
            this.lbl_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_S.Location = new System.Drawing.Point(227, 150);
            this.lbl_S.Name = "lbl_S";
            this.lbl_S.Size = new System.Drawing.Size(162, 26);
            this.lbl_S.TabIndex = 1;
            this.lbl_S.Text = "Ilość sezonów";
            // 
            // ch_box
            // 
            this.ch_box.AutoSize = true;
            this.ch_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ch_box.Location = new System.Drawing.Point(722, 55);
            this.ch_box.Name = "ch_box";
            this.ch_box.Size = new System.Drawing.Size(344, 36);
            this.ch_box.TabIndex = 3;
            this.ch_box.Text = "Wychodzi na bieżąco?";
            this.ch_box.UseVisualStyleBackColor = true;
            this.ch_box.CheckStateChanged += new System.EventHandler(this.Ch_box_CheckedChanged);
            // 
            // lbl_dzien
            // 
            this.lbl_dzien.AutoSize = true;
            this.lbl_dzien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_dzien.Location = new System.Drawing.Point(161, 150);
            this.lbl_dzien.Name = "lbl_dzien";
            this.lbl_dzien.Size = new System.Drawing.Size(293, 32);
            this.lbl_dzien.TabIndex = 4;
            this.lbl_dzien.Text = "Jaki dzień tygodnia?";
            this.lbl_dzien.Visible = false;
            // 
            // c_box
            // 
            this.c_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c_box.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.c_box.Items.AddRange(new object[] {
            "Poniedziałek",
            "Wtorek",
            "Środa",
            "Czwartek",
            "Piątek",
            "Sobota",
            "Niedziela"});
            this.c_box.Location = new System.Drawing.Point(192, 192);
            this.c_box.Name = "c_box";
            this.c_box.Size = new System.Drawing.Size(224, 40);
            this.c_box.TabIndex = 5;
            this.c_box.Visible = false;
            // 
            // tBox_nazwa
            // 
            this.tBox_nazwa.AllowDrop = true;
            this.tBox_nazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBox_nazwa.Location = new System.Drawing.Point(15, 84);
            this.tBox_nazwa.Name = "tBox_nazwa";
            this.tBox_nazwa.Size = new System.Drawing.Size(629, 39);
            this.tBox_nazwa.TabIndex = 6;
            // 
            // tBox_Link
            // 
            this.tBox_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBox_Link.Location = new System.Drawing.Point(15, 345);
            this.tBox_Link.Name = "tBox_Link";
            this.tBox_Link.Size = new System.Drawing.Size(629, 39);
            this.tBox_Link.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(10, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Link";
            // 
            // ilosc_Sezony
            // 
            this.ilosc_Sezony.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ilosc_Sezony.Location = new System.Drawing.Point(278, 192);
            this.ilosc_Sezony.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ilosc_Sezony.Name = "ilosc_Sezony";
            this.ilosc_Sezony.Size = new System.Drawing.Size(69, 39);
            this.ilosc_Sezony.TabIndex = 11;
            this.ilosc_Sezony.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ilosc_Sezony.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Btn_dodaj
            // 
            this.Btn_dodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Btn_dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_dodaj.Location = new System.Drawing.Point(766, 408);
            this.Btn_dodaj.Name = "Btn_dodaj";
            this.Btn_dodaj.Size = new System.Drawing.Size(300, 211);
            this.Btn_dodaj.TabIndex = 13;
            this.Btn_dodaj.Text = "Dodaj";
            this.Btn_dodaj.UseVisualStyleBackColor = false;
            this.Btn_dodaj.Click += new System.EventHandler(this.Btn_dodaj_Click);
            // 
            // cBox_IMG
            // 
            this.cBox_IMG.AutoSize = true;
            this.cBox_IMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBox_IMG.Location = new System.Drawing.Point(722, 146);
            this.cBox_IMG.Name = "cBox_IMG";
            this.cBox_IMG.Size = new System.Drawing.Size(270, 36);
            this.cBox_IMG.TabIndex = 14;
            this.cBox_IMG.Text = "Dodaj miniatrukę";
            this.cBox_IMG.UseVisualStyleBackColor = true;
            this.cBox_IMG.CheckedChanged += new System.EventHandler(this.CBox_IMG_CheckedChanged);
            // 
            // tBox_IMG
            // 
            this.tBox_IMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBox_IMG.Location = new System.Drawing.Point(15, 518);
            this.tBox_IMG.Name = "tBox_IMG";
            this.tBox_IMG.Size = new System.Drawing.Size(629, 39);
            this.tBox_IMG.TabIndex = 15;
            this.tBox_IMG.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Miniaturka (Link albo lokalizacja)";
            this.label2.Visible = false;
            // 
            // IMAGE
            // 
            this.IMAGE.Image = global::Serialak.Properties.Resources.icons8_file_folder_481;
            this.IMAGE.Location = new System.Drawing.Point(650, 517);
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.Size = new System.Drawing.Size(63, 49);
            this.IMAGE.TabIndex = 17;
            this.IMAGE.UseVisualStyleBackColor = true;
            this.IMAGE.Visible = false;
            this.IMAGE.Click += new System.EventHandler(this.IMAGE_Click);
            // 
            // Dodawanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1078, 640);
            this.Controls.Add(this.IMAGE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBox_IMG);
            this.Controls.Add(this.cBox_IMG);
            this.Controls.Add(this.Btn_dodaj);
            this.Controls.Add(this.ilosc_Sezony);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBox_Link);
            this.Controls.Add(this.tBox_nazwa);
            this.Controls.Add(this.c_box);
            this.Controls.Add(this.lbl_dzien);
            this.Controls.Add(this.ch_box);
            this.Controls.Add(this.lbl_S);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dodawanie";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ilosc_Sezony)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_S;
        private System.Windows.Forms.CheckBox ch_box;
        private System.Windows.Forms.Label lbl_dzien;
        private System.Windows.Forms.ComboBox c_box;
        private System.Windows.Forms.TextBox tBox_nazwa;
        private System.Windows.Forms.TextBox tBox_Link;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ilosc_Sezony;
        public System.Windows.Forms.Button Btn_dodaj;
        private System.Windows.Forms.CheckBox cBox_IMG;
        private System.Windows.Forms.TextBox tBox_IMG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IMAGE;
        private System.Windows.Forms.OpenFileDialog Loadfile;
    }
}