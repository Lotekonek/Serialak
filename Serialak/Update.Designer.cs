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
            ((System.ComponentModel.ISupportInitialize)(this.n_odc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_sez)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(31, 92);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(185, 29);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Który odcinek?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(326, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Który sezon?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(36, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(452, 58);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(175, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wybierz serial";
            // 
            // cBox
            // 
            this.cBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox.FormattingEnabled = true;
            this.cBox.Location = new System.Drawing.Point(36, 45);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(452, 28);
            this.cBox.TabIndex = 6;
            this.cBox.SelectedIndexChanged += new System.EventHandler(this.CBox_SelectedIndexChanged);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(526, 250);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_sez);
            this.Controls.Add(this.n_odc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Update";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.n_odc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_sez)).EndInit();
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
    }
}