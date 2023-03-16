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
        private readonly List<string> files = new List<string>();
        private readonly Button[] buton = new Button[3];
        private readonly Label[] label = new Label[3];
        private string[] profiles;
        private int x=0;

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
            var wartosc = (sender as Button).Tag.ToString();
            Settings.Default.Nazwa = profiles[int.Parse(wartosc)];
            DialogResult = DialogResult.OK;
            Close();
        }


        private void Ladowanie()
        {
            profiles = Directory.GetDirectories(Seriale);
            foreach (var profil in profiles)
            {
                var pliki = Directory.GetFiles(profil);
                foreach (var p in pliki)
                {
                    files.Add(p);
                }
            }

            foreach (Label lbl in Controls.OfType<Label>())
            {
                lbl.UseMnemonic = false;
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
            foreach (Button btn in Controls.OfType<Button>())
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
            for (int i = 0; i < files.Count; i += 2)
            {

                buton[x].Tag = x;
                string img = files[i];
                using (Image myimage = Image.FromFile(img))

                {
                    var image = ResizeImage(myimage, new Size(150, 150));
                    buton[x].Image = image;
                }
                buton[x].Click += new EventHandler(BtnClick);
                buton[x].Visible = true;
                string toBeSearched = "Seriale_";
                string code = files[i].ToString().Substring(files[i].ToString().IndexOf(toBeSearched) + toBeSearched.Length);
                string name = code.Remove(code.Length - 4);
                label[x++].Text = name;
            }
        }
    

        private void Profil_Load(object sender, EventArgs e)
        {
            Settings.Default.Nr = Directory.GetDirectories(Seriale).Length+1;
            if (Directory.GetDirectories(Seriale).Length > 2)
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