namespace Serialak
{
    partial class ProfilAdd
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
            this.Tbox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_Link = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Loadfile = new System.Windows.Forms.OpenFileDialog();
            this.IMAGE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa";
            // 
            // Tbox_name
            // 
            this.Tbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tbox_name.Location = new System.Drawing.Point(19, 48);
            this.Tbox_name.Name = "Tbox_name";
            this.Tbox_name.Size = new System.Drawing.Size(251, 39);
            this.Tbox_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Awatar (Link albo lokalizacja)";
            // 
            // tBox_Link
            // 
            this.tBox_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBox_Link.Location = new System.Drawing.Point(19, 134);
            this.tBox_Link.Name = "tBox_Link";
            this.tBox_Link.Size = new System.Drawing.Size(424, 39);
            this.tBox_Link.TabIndex = 3;
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Add.ForeColor = System.Drawing.Color.GhostWhite;
            this.Btn_Add.Location = new System.Drawing.Point(584, 48);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(152, 93);
            this.Btn_Add.TabIndex = 4;
            this.Btn_Add.Text = "Dodaj";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // IMAGE
            // 
            this.IMAGE.Image = global::Serialak.Properties.Resources.icons8_file_folder_481;
            this.IMAGE.Location = new System.Drawing.Point(464, 134);
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.Size = new System.Drawing.Size(63, 49);
            this.IMAGE.TabIndex = 18;
            this.IMAGE.UseVisualStyleBackColor = true;
            this.IMAGE.Click += new System.EventHandler(this.IMAGE_Click);
            // 
            // ProfilAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(767, 194);
            this.Controls.Add(this.IMAGE);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.tBox_Link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tbox_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ProfilAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox_Link;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.OpenFileDialog Loadfile;
        private System.Windows.Forms.Button IMAGE;
    }
}