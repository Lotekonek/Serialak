namespace Serialak
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serialak));
            this.dane_seriale = new System.Windows.Forms.DataGridView();
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
            this.btn_end = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_approve = new System.Windows.Forms.Button();
            this.Loadfile = new System.Windows.Forms.OpenFileDialog();
            this.cBox_IMG = new System.Windows.Forms.CheckBox();
            this.obrazek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosc_odc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosc_sez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkcell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dane_seriale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dane_seriale.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dane_seriale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dane_seriale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dane_seriale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dane_seriale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dane_seriale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.obrazek,
            this.Nazwa,
            this.odc,
            this.sez,
            this.ilosc_odc,
            this.ilosc_sez,
            this.when,
            this.last,
            this.linkcell,
            this.status,
            this.end});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dane_seriale.DefaultCellStyle = dataGridViewCellStyle29;
            this.dane_seriale.EnableHeadersVisualStyles = false;
            this.dane_seriale.GridColor = System.Drawing.Color.Black;
            this.dane_seriale.Location = new System.Drawing.Point(0, 35);
            this.dane_seriale.Name = "dane_seriale";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dane_seriale.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dane_seriale.RowHeadersVisible = false;
            this.dane_seriale.RowHeadersWidth = 62;
            this.dane_seriale.Size = new System.Drawing.Size(2275, 1226);
            this.dane_seriale.TabIndex = 0;
            this.dane_seriale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dane_seriale_CellContentClick);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
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
            this.Menu.Size = new System.Drawing.Size(2275, 33);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            // 
            // Dodaj
            // 
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(76, 29);
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Usuń
            // 
            this.Usuń.Name = "Usuń";
            this.Usuń.Size = new System.Drawing.Size(68, 29);
            this.Usuń.Text = "Usuń";
            this.Usuń.Click += new System.EventHandler(this.Usuń_Click);
            // 
            // Aktualizuj
            // 
            this.Aktualizuj.Name = "Aktualizuj";
            this.Aktualizuj.Size = new System.Drawing.Size(104, 29);
            this.Aktualizuj.Text = "Aktualizuj";
            this.Aktualizuj.Click += new System.EventHandler(this.Aktualizuj_Click);
            // 
            // Losuj
            // 
            this.Losuj.Name = "Losuj";
            this.Losuj.Size = new System.Drawing.Size(69, 29);
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
            this.zapiszDoPlikuToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.zapiszDoPlikuToolStripMenuItem.Text = "Zapisz do pliku";
            // 
            // zapiszDoPlikuCSVToolStripMenuItem
            // 
            this.zapiszDoPlikuCSVToolStripMenuItem.Name = "zapiszDoPlikuCSVToolStripMenuItem";
            this.zapiszDoPlikuCSVToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.zapiszDoPlikuCSVToolStripMenuItem.Text = "Zapisz do pliku CSV";
            this.zapiszDoPlikuCSVToolStripMenuItem.Click += new System.EventHandler(this.CSVToolStripMenuItem_Click);
            // 
            // zapisDoPlikuPDFToolStripMenuItem
            // 
            this.zapisDoPlikuPDFToolStripMenuItem.Name = "zapisDoPlikuPDFToolStripMenuItem";
            this.zapisDoPlikuPDFToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.zapisDoPlikuPDFToolStripMenuItem.Text = "Zapis do pliku PDF";
            this.zapisDoPlikuPDFToolStripMenuItem.Click += new System.EventHandler(this.PDFToolStripMenuItem_Click);
            // 
            // zapiszDoPlikuXMLToolStripMenuItem
            // 
            this.zapiszDoPlikuXMLToolStripMenuItem.Name = "zapiszDoPlikuXMLToolStripMenuItem";
            this.zapiszDoPlikuXMLToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.zapiszDoPlikuXMLToolStripMenuItem.Text = "Zapisz do pliku XML";
            this.zapiszDoPlikuXMLToolStripMenuItem.Click += new System.EventHandler(this.ZapiszDoPlikuXMLToolStripMenuItem_Click);
            // 
            // zapiszBackupToolStripMenuItem
            // 
            this.zapiszBackupToolStripMenuItem.Name = "zapiszBackupToolStripMenuItem";
            this.zapiszBackupToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.zapiszBackupToolStripMenuItem.Text = "Stwórz backup";
            this.zapiszBackupToolStripMenuItem.Click += new System.EventHandler(this.ZapiszBackupToolStripMenuItem_Click);
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajZPlikuXMLToolStripMenuItem1,
            this.WczytajbackupToolStripMenuItem});
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.wczytajToolStripMenuItem.Text = "Wczytaj z pliku";
            // 
            // wczytajZPlikuXMLToolStripMenuItem1
            // 
            this.wczytajZPlikuXMLToolStripMenuItem1.Name = "wczytajZPlikuXMLToolStripMenuItem1";
            this.wczytajZPlikuXMLToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.wczytajZPlikuXMLToolStripMenuItem1.Text = "Wczytaj z pliku XML";
            this.wczytajZPlikuXMLToolStripMenuItem1.Click += new System.EventHandler(this.WczytajZPlikuXMLToolStripMenuItem1_Click);
            // 
            // WczytajbackupToolStripMenuItem
            // 
            this.WczytajbackupToolStripMenuItem.Name = "WczytajbackupToolStripMenuItem";
            this.WczytajbackupToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.WczytajbackupToolStripMenuItem.Text = "Wczytaj backup";
            this.WczytajbackupToolStripMenuItem.Click += new System.EventHandler(this.WczytajbackupToolStripMenuItem_Click);
            // 
            // cbox_ogladane
            // 
            this.cbox_ogladane.AutoSize = true;
            this.cbox_ogladane.Location = new System.Drawing.Point(667, 7);
            this.cbox_ogladane.Name = "cbox_ogladane";
            this.cbox_ogladane.Size = new System.Drawing.Size(203, 24);
            this.cbox_ogladane.TabIndex = 4;
            this.cbox_ogladane.Text = "Pokaż obejrzane seriale";
            this.cbox_ogladane.UseVisualStyleBackColor = true;
            this.cbox_ogladane.CheckedChanged += new System.EventHandler(this.Cbox_ogladane_CheckedChanged);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(2012, 0);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(130, 32);
            this.btn_end.TabIndex = 5;
            this.btn_end.Text = "Zakończ serial";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.Btn_end_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(1610, 4);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(384, 25);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Wybierz serial który chcesz zakończyć";
            this.lbl1.Visible = false;
            // 
            // btn_approve
            // 
            this.btn_approve.Location = new System.Drawing.Point(2012, 0);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(130, 33);
            this.btn_approve.TabIndex = 7;
            this.btn_approve.Text = "Potwierdź";
            this.btn_approve.UseVisualStyleBackColor = true;
            this.btn_approve.Visible = false;
            this.btn_approve.Click += new System.EventHandler(this.Btn_approve_Click);
            // 
            // Loadfile
            // 
            this.Loadfile.FileName = "openFileDialog1";
            // 
            // cBox_IMG
            // 
            this.cBox_IMG.AutoSize = true;
            this.cBox_IMG.Location = new System.Drawing.Point(910, 7);
            this.cBox_IMG.Name = "cBox_IMG";
            this.cBox_IMG.Size = new System.Drawing.Size(150, 24);
            this.cBox_IMG.TabIndex = 8;
            this.cBox_IMG.Text = "Pokaż miniaturki";
            this.cBox_IMG.UseVisualStyleBackColor = true;
            this.cBox_IMG.CheckedChanged += new System.EventHandler(this.CBox_IMG_CheckedChanged);
            // 
            // obrazek
            // 
            this.obrazek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.obrazek.HeaderText = "";
            this.obrazek.MinimumWidth = 8;
            this.obrazek.Name = "obrazek";
            this.obrazek.ReadOnly = true;
            this.obrazek.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.obrazek.Visible = false;
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.MinimumWidth = 8;
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // odc
            // 
            this.odc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.odc.DefaultCellStyle = dataGridViewCellStyle23;
            this.odc.FillWeight = 25F;
            this.odc.HeaderText = "Aktualny odcinek";
            this.odc.MinimumWidth = 8;
            this.odc.Name = "odc";
            this.odc.ReadOnly = true;
            // 
            // sez
            // 
            this.sez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sez.DefaultCellStyle = dataGridViewCellStyle24;
            this.sez.FillWeight = 25F;
            this.sez.HeaderText = "Aktualny Sezon";
            this.sez.MinimumWidth = 8;
            this.sez.Name = "sez";
            this.sez.ReadOnly = true;
            // 
            // ilosc_odc
            // 
            this.ilosc_odc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ilosc_odc.DefaultCellStyle = dataGridViewCellStyle25;
            this.ilosc_odc.FillWeight = 25F;
            this.ilosc_odc.HeaderText = "Odcinki";
            this.ilosc_odc.MinimumWidth = 8;
            this.ilosc_odc.Name = "ilosc_odc";
            this.ilosc_odc.ReadOnly = true;
            // 
            // ilosc_sez
            // 
            this.ilosc_sez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ilosc_sez.DefaultCellStyle = dataGridViewCellStyle26;
            this.ilosc_sez.FillWeight = 25F;
            this.ilosc_sez.HeaderText = "Sezony";
            this.ilosc_sez.MinimumWidth = 8;
            this.ilosc_sez.Name = "ilosc_sez";
            this.ilosc_sez.ReadOnly = true;
            // 
            // when
            // 
            this.when.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.when.DefaultCellStyle = dataGridViewCellStyle27;
            this.when.FillWeight = 40F;
            this.when.HeaderText = "Wychodzi";
            this.when.MinimumWidth = 8;
            this.when.Name = "when";
            this.when.ReadOnly = true;
            // 
            // last
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.last.DefaultCellStyle = dataGridViewCellStyle28;
            this.last.HeaderText = "Ostatnio oglądany";
            this.last.MinimumWidth = 8;
            this.last.Name = "last";
            this.last.ReadOnly = true;
            this.last.Width = 150;
            // 
            // linkcell
            // 
            this.linkcell.HeaderText = "Link";
            this.linkcell.MinimumWidth = 8;
            this.linkcell.Name = "linkcell";
            this.linkcell.Width = 150;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            // 
            // end
            // 
            this.end.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.end.FillWeight = 25F;
            this.end.HeaderText = "Wybierz";
            this.end.MinimumWidth = 8;
            this.end.Name = "end";
            this.end.Visible = false;
            // 
            // Serialak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(2275, 1260);
            this.Controls.Add(this.cBox_IMG);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_end);
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
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.ToolStripMenuItem zapiszDoPlikuXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog Loadfile;
        private System.Windows.Forms.ToolStripMenuItem zapiszBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajZPlikuXMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem WczytajbackupToolStripMenuItem;
        private System.Windows.Forms.CheckBox cBox_IMG;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrazek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn odc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sez;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc_odc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc_sez;
        private System.Windows.Forms.DataGridViewTextBoxColumn when;
        private System.Windows.Forms.DataGridViewTextBoxColumn last;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkcell;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn end;
    }
}

