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
            this.lbl_O = new System.Windows.Forms.Label();
            this.ch_box = new System.Windows.Forms.CheckBox();
            this.lbl_dzien = new System.Windows.Forms.Label();
            this.c_box = new System.Windows.Forms.ComboBox();
            this.tBox_nazwa = new System.Windows.Forms.TextBox();
            this.tBox_Link = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ilosc_Sezony = new System.Windows.Forms.NumericUpDown();
            this.ilosc_odcinki = new System.Windows.Forms.NumericUpDown();
            this.Btn_dodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ilosc_Sezony)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilosc_odcinki)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa";
            // 
            // lbl_S
            // 
            this.lbl_S.AutoSize = true;
            this.lbl_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_S.Location = new System.Drawing.Point(10, 150);
            this.lbl_S.Name = "lbl_S";
            this.lbl_S.Size = new System.Drawing.Size(162, 26);
            this.lbl_S.TabIndex = 1;
            this.lbl_S.Text = "Ilość sezonów";
            // 
            // lbl_O
            // 
            this.lbl_O.AutoSize = true;
            this.lbl_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_O.Location = new System.Drawing.Point(476, 150);
            this.lbl_O.Name = "lbl_O";
            this.lbl_O.Size = new System.Drawing.Size(168, 26);
            this.lbl_O.TabIndex = 2;
            this.lbl_O.Text = "Ilość odcinków";
            // 
            // ch_box
            // 
            this.ch_box.AutoSize = true;
            this.ch_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.ch_box.Location = new System.Drawing.Point(738, 55);
            this.ch_box.Name = "ch_box";
            this.ch_box.Size = new System.Drawing.Size(276, 30);
            this.ch_box.TabIndex = 3;
            this.ch_box.Text = "Wychodzi na bieżąco?";
            this.ch_box.UseVisualStyleBackColor = true;
            this.ch_box.CheckStateChanged += new System.EventHandler(this.Ch_box_CheckedChanged);
            // 
            // lbl_dzien
            // 
            this.lbl_dzien.AutoSize = true;
            this.lbl_dzien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_dzien.Location = new System.Drawing.Point(200, 150);
            this.lbl_dzien.Name = "lbl_dzien";
            this.lbl_dzien.Size = new System.Drawing.Size(229, 26);
            this.lbl_dzien.TabIndex = 4;
            this.lbl_dzien.Text = "Jaki dzień tygodnia?";
            this.lbl_dzien.Visible = false;
            // 
            // c_box
            // 
            this.c_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_box.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.c_box.Items.AddRange(new object[] {
            "Poniedziałek",
            "Wtorek",
            "Sroda",
            "Czwartek",
            "Piątek",
            "Sobota",
            "Niedziela"});
            this.c_box.Location = new System.Drawing.Point(205, 195);
            this.c_box.Name = "c_box";
            this.c_box.Size = new System.Drawing.Size(224, 28);
            this.c_box.TabIndex = 5;
            this.c_box.Visible = false;
            // 
            // tBox_nazwa
            // 
            this.tBox_nazwa.AllowDrop = true;
            this.tBox_nazwa.Location = new System.Drawing.Point(15, 84);
            this.tBox_nazwa.Name = "tBox_nazwa";
            this.tBox_nazwa.Size = new System.Drawing.Size(629, 26);
            this.tBox_nazwa.TabIndex = 6;
            // 
            // tBox_Link
            // 
            this.tBox_Link.Location = new System.Drawing.Point(15, 345);
            this.tBox_Link.Name = "tBox_Link";
            this.tBox_Link.Size = new System.Drawing.Size(629, 26);
            this.tBox_Link.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Link";
            // 
            // ilosc_Sezony
            // 
            this.ilosc_Sezony.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ilosc_Sezony.Location = new System.Drawing.Point(54, 192);
            this.ilosc_Sezony.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ilosc_Sezony.Name = "ilosc_Sezony";
            this.ilosc_Sezony.Size = new System.Drawing.Size(69, 30);
            this.ilosc_Sezony.TabIndex = 11;
            this.ilosc_Sezony.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ilosc_Sezony.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ilosc_odcinki
            // 
            this.ilosc_odcinki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ilosc_odcinki.Location = new System.Drawing.Point(522, 193);
            this.ilosc_odcinki.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ilosc_odcinki.Name = "ilosc_odcinki";
            this.ilosc_odcinki.Size = new System.Drawing.Size(69, 30);
            this.ilosc_odcinki.TabIndex = 12;
            this.ilosc_odcinki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ilosc_odcinki.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Btn_dodaj
            // 
            this.Btn_dodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_dodaj.Location = new System.Drawing.Point(738, 396);
            this.Btn_dodaj.Name = "Btn_dodaj";
            this.Btn_dodaj.Size = new System.Drawing.Size(300, 211);
            this.Btn_dodaj.TabIndex = 13;
            this.Btn_dodaj.Text = "Dodaj";
            this.Btn_dodaj.UseVisualStyleBackColor = false;
            this.Btn_dodaj.Click += new System.EventHandler(this.Btn_dodaj_Click);
            // 
            // Dodawanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1078, 640);
            this.Controls.Add(this.Btn_dodaj);
            this.Controls.Add(this.ilosc_odcinki);
            this.Controls.Add(this.ilosc_Sezony);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBox_Link);
            this.Controls.Add(this.tBox_nazwa);
            this.Controls.Add(this.c_box);
            this.Controls.Add(this.lbl_dzien);
            this.Controls.Add(this.ch_box);
            this.Controls.Add(this.lbl_O);
            this.Controls.Add(this.lbl_S);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dodawanie";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ilosc_Sezony)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilosc_odcinki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_S;
        private System.Windows.Forms.Label lbl_O;
        private System.Windows.Forms.CheckBox ch_box;
        private System.Windows.Forms.Label lbl_dzien;
        private System.Windows.Forms.ComboBox c_box;
        private System.Windows.Forms.TextBox tBox_nazwa;
        private System.Windows.Forms.TextBox tBox_Link;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ilosc_Sezony;
        private System.Windows.Forms.NumericUpDown ilosc_odcinki;
        public System.Windows.Forms.Button Btn_dodaj;
    }
}