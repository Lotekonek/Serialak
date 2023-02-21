namespace Serialak
{
    partial class Lokalizacja
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
            this.tBox_loc = new System.Windows.Forms.TextBox();
            this.b_OK = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.SaveFileDialog();
            this.B_zmien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz lokalizację zapisu danych";
            // 
            // tBox_loc
            // 
            this.tBox_loc.Location = new System.Drawing.Point(19, 105);
            this.tBox_loc.Name = "tBox_loc";
            this.tBox_loc.Size = new System.Drawing.Size(471, 26);
            this.tBox_loc.TabIndex = 1;
            // 
            // b_OK
            // 
            this.b_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.b_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_OK.Location = new System.Drawing.Point(90, 150);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(400, 114);
            this.b_OK.TabIndex = 3;
            this.b_OK.Text = "Zatwierdź";
            this.b_OK.UseVisualStyleBackColor = false;
            this.b_OK.Click += new System.EventHandler(this.B_OK_Click);
            // 
            // B_zmien
            // 
            this.B_zmien.Image = global::Serialak.Properties.Resources.icons8_file_folder_48;
            this.B_zmien.Location = new System.Drawing.Point(496, 98);
            this.B_zmien.Name = "B_zmien";
            this.B_zmien.Size = new System.Drawing.Size(51, 40);
            this.B_zmien.TabIndex = 2;
            this.B_zmien.UseVisualStyleBackColor = true;
            this.B_zmien.Click += new System.EventHandler(this.B_zmien_Click);
            // 
            // Lokalizacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(572, 302);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.B_zmien);
            this.Controls.Add(this.tBox_loc);
            this.Controls.Add(this.label1);
            this.Name = "Lokalizacja";
            this.ShowIcon = false;
            this.Text = "Lokalizacja zapisu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_zmien;
        private System.Windows.Forms.Button b_OK;
        public System.Windows.Forms.TextBox tBox_loc;
        private System.Windows.Forms.SaveFileDialog Save;
    }
}