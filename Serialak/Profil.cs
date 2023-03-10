using Serialak.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Serialak
{
    public partial class Profil : Form
    {
        private static readonly string Seriale = AppDomain.CurrentDomain.BaseDirectory + @"Data\";
        private List<string> files = new List<string>();
        private readonly Button[] buton = new Button[3];
        private readonly Label[] label = new Label[3];
        private int i = 0;

        public Profil()
        {
            InitializeComponent();
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Data\"))
            {
                Directory.CreateDirectory(Seriale);
            }
            Ladowanie();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (ProfilAdd add = new ProfilAdd())
            {
                if (add.ShowDialog() == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
        }

        public static Image ResizeImage(Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }

        private void BtnClick(object sender, EventArgs e)
        {
            Settings.Default.Nazwa = (sender as Button).Tag.ToString();
            DialogResult = DialogResult.OK;
            this.Close();
        }


        private void Ladowanie()
        {
            var profiles = Directory.GetDirectories(Seriale);
            foreach (var profil in profiles)
            {
                var pliki = Directory.GetFiles(profil);
                foreach (var p in pliki)
                {
                    files.Add(p);
                }
            }

            foreach (Label lbl in this.Controls.OfType<Label>())
            {
                switch (lbl.TabIndex)
                {
                    case 4:

                        label[0] = lbl;
                        break;

                    case 3:
                        label[1] = lbl;
                        break;

                    case 5:
                        label[2] = lbl;
                        break;
                }
            }
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                switch (btn.AccessibleName)
                {
                    case "B1":
                        buton[0] = btn;
                        break;

                    case "B2":
                        buton[1] = btn;
                        break;

                    case "B3":
                        buton[2] = btn;
                        break;
                }
            }
            for (int i = 0; i < files.Count; i = i+2)
            {

                buton[i].Tag = files[i + 1];
                string img = files[i];
                MessageBox.Show(files[i]);
                using (Image myimage = Image.FromFile(img))

                {
                    var image = ResizeImage(myimage, new Size(150, 150));
                    buton[i].Image = image;
                }
                buton[i].Click += new EventHandler(BtnClick);
                buton[i].Visible = true;
                string toBeSearched = "Seriale_";
                string code = files[i].ToString().Substring(files[i].ToString().IndexOf(toBeSearched) + toBeSearched.Length);
                string name = code.Remove(code.Length - 4);
                label[i].Text = name;
            }
        }
    

        private void Profil_Load(object sender, EventArgs e)
        {
            if(Directory.GetFiles(Seriale, "*.xml").Length > 2)
            {
                button1.Visible = false;
            }
            Settings.Default.Nazwa = "";
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            using (Deletpro delete = new Deletpro())
            {
                if (delete.ShowDialog() == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
        }
    }
}