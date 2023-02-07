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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serialak));
            this.dane_seriale = new System.Windows.Forms.DataGridView();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosc_odc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosc_sez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Dodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuń = new System.Windows.Forms.ToolStripMenuItem();
            this.Aktualizuj = new System.Windows.Forms.ToolStripMenuItem();
            this.Losuj = new System.Windows.Forms.ToolStripMenuItem();
            this.Odśwież = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dane_seriale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dane_seriale.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dane_seriale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dane_seriale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dane_seriale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dane_seriale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dane_seriale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.odc,
            this.sez,
            this.ilosc_odc,
            this.ilosc_sez,
            this.when,
            this.last,
            this.link,
            this.status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dane_seriale.DefaultCellStyle = dataGridViewCellStyle3;
            this.dane_seriale.EnableHeadersVisualStyles = false;
            this.dane_seriale.GridColor = System.Drawing.Color.Black;
            this.dane_seriale.Location = new System.Drawing.Point(-7, 34);
            this.dane_seriale.Name = "dane_seriale";
            this.dane_seriale.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dane_seriale.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dane_seriale.RowHeadersVisible = false;
            this.dane_seriale.RowHeadersWidth = 62;
            this.dane_seriale.Size = new System.Drawing.Size(1759, 979);
            this.dane_seriale.TabIndex = 0;
            this.dane_seriale.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dane_seriale_CellMouseDoubleClick);
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
            this.odc.FillWeight = 25F;
            this.odc.HeaderText = "Aktualny odcinek";
            this.odc.MinimumWidth = 8;
            this.odc.Name = "odc";
            this.odc.ReadOnly = true;
            // 
            // sez
            // 
            this.sez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sez.FillWeight = 25F;
            this.sez.HeaderText = "Aktualny Sezon";
            this.sez.MinimumWidth = 8;
            this.sez.Name = "sez";
            this.sez.ReadOnly = true;
            // 
            // ilosc_odc
            // 
            this.ilosc_odc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ilosc_odc.FillWeight = 25F;
            this.ilosc_odc.HeaderText = "Ilość odcinków";
            this.ilosc_odc.MinimumWidth = 8;
            this.ilosc_odc.Name = "ilosc_odc";
            this.ilosc_odc.ReadOnly = true;
            // 
            // ilosc_sez
            // 
            this.ilosc_sez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ilosc_sez.FillWeight = 25F;
            this.ilosc_sez.HeaderText = "Ilość sezonów";
            this.ilosc_sez.MinimumWidth = 8;
            this.ilosc_sez.Name = "ilosc_sez";
            this.ilosc_sez.ReadOnly = true;
            // 
            // when
            // 
            this.when.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.when.FillWeight = 40F;
            this.when.HeaderText = "Wychodzi";
            this.when.MinimumWidth = 8;
            this.when.Name = "when";
            this.when.ReadOnly = true;
            // 
            // last
            // 
            this.last.HeaderText = "Ostatnio oglądany";
            this.last.MinimumWidth = 8;
            this.last.Name = "last";
            this.last.ReadOnly = true;
            this.last.Width = 150;
            // 
            // link
            // 
            this.link.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.link.HeaderText = "Link";
            this.link.MinimumWidth = 8;
            this.link.Name = "link";
            this.link.ReadOnly = true;
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
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dodaj,
            this.Usuń,
            this.Aktualizuj,
            this.Losuj});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1744, 33);
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
            // Odśwież
            // 
            this.Odśwież.BackColor = System.Drawing.Color.White;
            this.Odśwież.BackgroundImage = global::Serialak.Properties.Resources.refresh1;
            this.Odśwież.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Odśwież.Location = new System.Drawing.Point(1685, 45);
            this.Odśwież.Name = "Odśwież";
            this.Odśwież.Size = new System.Drawing.Size(47, 47);
            this.Odśwież.TabIndex = 3;
            this.Odśwież.UseVisualStyleBackColor = false;
            this.Odśwież.Click += new System.EventHandler(this.Odśwież_Click);
            // 
            // Serialak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1744, 1013);
            this.Controls.Add(this.Odśwież);
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
            this.TransparencyKey = System.Drawing.Color.Red;
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
        private System.Windows.Forms.Button Odśwież;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn odc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sez;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc_odc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc_sez;
        private System.Windows.Forms.DataGridViewTextBoxColumn when;
        private System.Windows.Forms.DataGridViewTextBoxColumn last;
        private System.Windows.Forms.DataGridViewTextBoxColumn link;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        public System.Windows.Forms.DataGridView dane_seriale;
    }
}

