﻿namespace Serialak
{
    partial class Serialak
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serialak));
            this.dane_seriale = new System.Windows.Forms.DataGridView();
            this.obrazek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosc_sez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkcell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Dodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuń = new System.Windows.Forms.ToolStripMenuItem();
            this.Aktualizuj = new System.Windows.Forms.ToolStripMenuItem();
            this.Losuj = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDoPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDoPlikuCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapisDoPlikuPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDoPlikuXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajZPlikuXMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.WczytajbackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.SaveFileDialog();
            this.cbox_ogladane = new System.Windows.Forms.CheckBox();
            this.Loadfile = new System.Windows.Forms.OpenFileDialog();
            this.cBox_IMG = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_profil = new System.Windows.Forms.Label();
            this.Btn_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dane_seriale)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dane_seriale
            // 
            this.dane_seriale.AllowUserToAddRows = false;
            this.dane_seriale.AllowUserToDeleteRows = false;
            this.dane_seriale.AllowUserToResizeColumns = false;
            this.dane_seriale.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dane_seriale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dane_seriale.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dane_seriale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dane_seriale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dane_seriale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dane_seriale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dane_seriale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.obrazek,
            this.Nazwa,
            this.odc,
            this.sez,
            this.ilosc_sez,
            this.when,
            this.last,
            this.linkcell,
            this.status});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dane_seriale.DefaultCellStyle = dataGridViewCellStyle10;
            this.dane_seriale.EnableHeadersVisualStyles = false;
            this.dane_seriale.GridColor = System.Drawing.Color.DimGray;
            this.dane_seriale.Location = new System.Drawing.Point(-6, 35);
            this.dane_seriale.Name = "dane_seriale";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dane_seriale.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dane_seriale.RowHeadersVisible = false;
            this.dane_seriale.RowHeadersWidth = 62;
            this.dane_seriale.Size = new System.Drawing.Size(2285, 1226);
            this.dane_seriale.TabIndex = 0;
            this.dane_seriale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dane_seriale_CellContentClick);
            // 
            // obrazek
            // 
            this.obrazek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.obrazek.HeaderText = "";
            this.obrazek.MinimumWidth = 8;
            this.obrazek.Name = "obrazek";
            this.obrazek.ReadOnly = true;
            this.obrazek.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.obrazek.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.obrazek.Visible = false;
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Nazwa.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nazwa.HeaderText = "   Nazwa";
            this.Nazwa.MinimumWidth = 8;
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            this.Nazwa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // odc
            // 
            this.odc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.odc.DefaultCellStyle = dataGridViewCellStyle4;
            this.odc.FillWeight = 45F;
            this.odc.HeaderText = "Aktualny odcinek";
            this.odc.MinimumWidth = 8;
            this.odc.Name = "odc";
            this.odc.ReadOnly = true;
            this.odc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sez
            // 
            this.sez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sez.DefaultCellStyle = dataGridViewCellStyle5;
            this.sez.FillWeight = 45F;
            this.sez.HeaderText = "Aktualny Sezon";
            this.sez.MinimumWidth = 8;
            this.sez.Name = "sez";
            this.sez.ReadOnly = true;
            this.sez.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ilosc_sez
            // 
            this.ilosc_sez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ilosc_sez.DefaultCellStyle = dataGridViewCellStyle6;
            this.ilosc_sez.FillWeight = 25F;
            this.ilosc_sez.HeaderText = "Sezony";
            this.ilosc_sez.MinimumWidth = 8;
            this.ilosc_sez.Name = "ilosc_sez";
            this.ilosc_sez.ReadOnly = true;
            this.ilosc_sez.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // when
            // 
            this.when.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.when.DefaultCellStyle = dataGridViewCellStyle7;
            this.when.FillWeight = 40F;
            this.when.HeaderText = "Wychodzi";
            this.when.MinimumWidth = 8;
            this.when.Name = "when";
            this.when.ReadOnly = true;
            this.when.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // last
            // 
            this.last.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.last.DefaultCellStyle = dataGridViewCellStyle8;
            this.last.FillWeight = 50F;
            this.last.HeaderText = "   Ostatnio oglądany";
            this.last.MinimumWidth = 8;
            this.last.Name = "last";
            this.last.ReadOnly = true;
            // 
            // linkcell
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.linkcell.DefaultCellStyle = dataGridViewCellStyle9;
            this.linkcell.HeaderText = "Link";
            this.linkcell.MinimumWidth = 8;
            this.linkcell.Name = "linkcell";
            this.linkcell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.linkcell.Width = 150;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.status.Visible = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dodaj,
            this.Usuń,
            this.Aktualizuj,
            this.Losuj,
            this.zapiszDoPlikuToolStripMenuItem,
            this.wczytajToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(2275, 36);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            // 
            // Dodaj
            // 
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(76, 32);
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Usuń
            // 
            this.Usuń.Name = "Usuń";
            this.Usuń.Size = new System.Drawing.Size(68, 32);
            this.Usuń.Text = "Usuń";
            this.Usuń.Click += new System.EventHandler(this.Usuń_Click);
            // 
            // Aktualizuj
            // 
            this.Aktualizuj.Name = "Aktualizuj";
            this.Aktualizuj.Size = new System.Drawing.Size(104, 32);
            this.Aktualizuj.Text = "Aktualizuj";
            this.Aktualizuj.Click += new System.EventHandler(this.Aktualizuj_Click);
            // 
            // Losuj
            // 
            this.Losuj.Name = "Losuj";
            this.Losuj.Size = new System.Drawing.Size(69, 32);
            this.Losuj.Text = "Losuj";
            this.Losuj.Click += new System.EventHandler(this.Losuj_Click);
            // 
            // zapiszDoPlikuToolStripMenuItem
            // 
            this.zapiszDoPlikuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszDoPlikuCSVToolStripMenuItem,
            this.zapisDoPlikuPDFToolStripMenuItem,
            this.zapiszDoPlikuXMLToolStripMenuItem,
            this.zapiszBackupToolStripMenuItem});
            this.zapiszDoPlikuToolStripMenuItem.Name = "zapiszDoPlikuToolStripMenuItem";
            this.zapiszDoPlikuToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.zapiszDoPlikuToolStripMenuItem.Text = "Zapisz do pliku";
            // 
            // zapiszDoPlikuCSVToolStripMenuItem
            // 
            this.zapiszDoPlikuCSVToolStripMenuItem.Name = "zapiszDoPlikuCSVToolStripMenuItem";
            this.zapiszDoPlikuCSVToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.zapiszDoPlikuCSVToolStripMenuItem.Text = "Zapisz do pliku CSV";
            this.zapiszDoPlikuCSVToolStripMenuItem.Click += new System.EventHandler(this.CSVToolStripMenuItem_Click);
            // 
            // zapisDoPlikuPDFToolStripMenuItem
            // 
            this.zapisDoPlikuPDFToolStripMenuItem.Name = "zapisDoPlikuPDFToolStripMenuItem";
            this.zapisDoPlikuPDFToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.zapisDoPlikuPDFToolStripMenuItem.Text = "Zapis do pliku PDF";
            this.zapisDoPlikuPDFToolStripMenuItem.Click += new System.EventHandler(this.PDFToolStripMenuItem_Click);
            // 
            // zapiszDoPlikuXMLToolStripMenuItem
            // 
            this.zapiszDoPlikuXMLToolStripMenuItem.Name = "zapiszDoPlikuXMLToolStripMenuItem";
            this.zapiszDoPlikuXMLToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.zapiszDoPlikuXMLToolStripMenuItem.Text = "Zapisz profil";
            this.zapiszDoPlikuXMLToolStripMenuItem.Click += new System.EventHandler(this.ZapiszDoPlikuXMLToolStripMenuItem_Click);
            // 
            // zapiszBackupToolStripMenuItem
            // 
            this.zapiszBackupToolStripMenuItem.Name = "zapiszBackupToolStripMenuItem";
            this.zapiszBackupToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.zapiszBackupToolStripMenuItem.Text = "Stwórz backup";
            this.zapiszBackupToolStripMenuItem.Click += new System.EventHandler(this.ZapiszBackupToolStripMenuItem_Click);
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajZPlikuXMLToolStripMenuItem1,
            this.WczytajbackupToolStripMenuItem});
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(144, 32);
            this.wczytajToolStripMenuItem.Text = "Wczytaj z pliku";
            // 
            // wczytajZPlikuXMLToolStripMenuItem1
            // 
            this.wczytajZPlikuXMLToolStripMenuItem1.Name = "wczytajZPlikuXMLToolStripMenuItem1";
            this.wczytajZPlikuXMLToolStripMenuItem1.Size = new System.Drawing.Size(237, 34);
            this.wczytajZPlikuXMLToolStripMenuItem1.Text = "Wczytaj profil";
            this.wczytajZPlikuXMLToolStripMenuItem1.Click += new System.EventHandler(this.WczytajZPlikuXMLToolStripMenuItem1_Click);
            // 
            // WczytajbackupToolStripMenuItem
            // 
            this.WczytajbackupToolStripMenuItem.Name = "WczytajbackupToolStripMenuItem";
            this.WczytajbackupToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.WczytajbackupToolStripMenuItem.Text = "Wczytaj backup";
            this.WczytajbackupToolStripMenuItem.Click += new System.EventHandler(this.WczytajbackupToolStripMenuItem_Click);
            // 
            // cbox_ogladane
            // 
            this.cbox_ogladane.AutoSize = true;
            this.cbox_ogladane.BackColor = System.Drawing.Color.White;
            this.cbox_ogladane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbox_ogladane.Location = new System.Drawing.Point(632, 3);
            this.cbox_ogladane.Name = "cbox_ogladane";
            this.cbox_ogladane.Size = new System.Drawing.Size(246, 29);
            this.cbox_ogladane.TabIndex = 4;
            this.cbox_ogladane.Text = "Pokaż obejrzane seriale";
            this.cbox_ogladane.UseVisualStyleBackColor = false;
            this.cbox_ogladane.CheckedChanged += new System.EventHandler(this.Cbox_ogladane_CheckedChanged);
            // 
            // Loadfile
            // 
            this.Loadfile.FileName = "openFileDialog1";
            // 
            // cBox_IMG
            // 
            this.cBox_IMG.AutoSize = true;
            this.cBox_IMG.BackColor = System.Drawing.Color.White;
            this.cBox_IMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBox_IMG.Location = new System.Drawing.Point(896, 3);
            this.cBox_IMG.Name = "cBox_IMG";
            this.cBox_IMG.Size = new System.Drawing.Size(180, 29);
            this.cBox_IMG.TabIndex = 8;
            this.cBox_IMG.Text = "Pokaż miniaturki";
            this.cBox_IMG.UseVisualStyleBackColor = false;
            this.cBox_IMG.CheckedChanged += new System.EventHandler(this.CBox_IMG_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1725, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Profil: ";
            // 
            // Lbl_profil
            // 
            this.Lbl_profil.AutoSize = true;
            this.Lbl_profil.BackColor = System.Drawing.Color.White;
            this.Lbl_profil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_profil.Location = new System.Drawing.Point(1799, 4);
            this.Lbl_profil.Name = "Lbl_profil";
            this.Lbl_profil.Size = new System.Drawing.Size(0, 25);
            this.Lbl_profil.TabIndex = 10;
            // 
            // Btn_logout
            // 
            this.Btn_logout.Location = new System.Drawing.Point(2149, -2);
            this.Btn_logout.Name = "Btn_logout";
            this.Btn_logout.Size = new System.Drawing.Size(130, 35);
            this.Btn_logout.TabIndex = 11;
            this.Btn_logout.Text = "Wyloguj";
            this.Btn_logout.UseVisualStyleBackColor = true;
            this.Btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // Serialak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(2275, 1260);
            this.Controls.Add(this.Btn_logout);
            this.Controls.Add(this.Lbl_profil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_IMG);
            this.Controls.Add(this.cbox_ogladane);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.dane_seriale);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "Serialak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serialak";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Serialak_FormClosing);
            this.Load += new System.EventHandler(this.Serialak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dane_seriale)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Aktualizuj;
        private System.Windows.Forms.ToolStripMenuItem Dodaj;
        private System.Windows.Forms.ToolStripMenuItem Usuń;
        private System.Windows.Forms.ToolStripMenuItem Losuj;
        public System.Windows.Forms.DataGridView dane_seriale;
        private System.Windows.Forms.ToolStripMenuItem zapiszDoPlikuToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog Save;
        private System.Windows.Forms.CheckBox cbox_ogladane;
        private System.Windows.Forms.ToolStripMenuItem zapiszDoPlikuCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapisDoPlikuPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszDoPlikuXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog Loadfile;
        private System.Windows.Forms.ToolStripMenuItem zapiszBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajZPlikuXMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem WczytajbackupToolStripMenuItem;
        private System.Windows.Forms.CheckBox cBox_IMG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_profil;
        private System.Windows.Forms.Button Btn_logout;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrazek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn odc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sez;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc_sez;
        private System.Windows.Forms.DataGridViewTextBoxColumn when;
        private System.Windows.Forms.DataGridViewTextBoxColumn last;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkcell;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

