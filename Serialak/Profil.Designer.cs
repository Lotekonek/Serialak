namespace Serialak
{
    partial class Profil
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
            this.button1 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(572, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 111);
            this.button1.TabIndex = 10;
            this.button1.Text = "Utwórz profil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Btn1
            // 
            this.Btn1.AccessibleName = "B1";
            this.Btn1.Location = new System.Drawing.Point(18, 120);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(225, 180);
            this.Btn1.TabIndex = 1;
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Visible = false;
            // 
            // Btn2
            // 
            this.Btn2.AccessibleName = "B3";
            this.Btn2.BackColor = System.Drawing.Color.White;
            this.Btn2.Location = new System.Drawing.Point(304, 120);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(225, 180);
            this.Btn2.TabIndex = 2;
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Visible = false;
            // 
            // Btn3
            // 
            this.Btn3.AccessibleName = "B2";
            this.Btn3.Location = new System.Drawing.Point(590, 120);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(225, 180);
            this.Btn3.TabIndex = 0;
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(288, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(584, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 3;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.GhostWhite;
            this.Btn_Delete.Location = new System.Drawing.Point(20, 31);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(205, 111);
            this.Btn_Delete.TabIndex = 11;
            this.Btn_Delete.Text = "Usuń profil";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Delete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(18, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 162);
            this.panel1.TabIndex = 12;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(830, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wybór profilu";
            this.Load += new System.EventHandler(this.Profil_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Panel panel1;
    }
}