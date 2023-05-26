using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using Serialak.Properties;

namespace Serialak
{
    public partial class ProfilAdd : Form
    {
        private static readonly string Seriale = AppDomain.CurrentDomain.BaseDirectory + @"Data\";
        private readonly int nr = Settings.Default.Nr;
        private XDocument xml;

        public ProfilAdd()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (tBox_Link.Text != "" && Tbox_name.Text != "")
            {
                Tbox_name.Text = Tbox_name.Text.Replace(" ", "_");
                if (!File.Exists(Seriale + nr + Tbox_name + @"\Seriale_" + Tbox_name.Text + ".xml"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data\" + nr + Tbox_name.Text.Replace(" ", "_"));

                    xml = new XDocument(
                       new XDeclaration("1.0", "utf-8", "true"),
                       new XElement("Spis"));
                    xml.Save(Seriale + nr + Tbox_name.Text + @"\Seriale_" + Tbox_name.Text + ".xml");
                }
                try
                {
                    bool result1 = Uri.TryCreate(tBox_Link.Text, UriKind.Absolute, out Uri uriResult1)
                && (uriResult1.Scheme == Uri.UriSchemeHttp || uriResult1.Scheme == Uri.UriSchemeHttps);
                    if (!result1)
                    {
                        File.Copy(tBox_Link.Text, Seriale + nr + Tbox_name.Text + @"\Seriale_" + Tbox_name.Text + ".png");
                    }
                    else
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile(uriResult1, Seriale + nr + Tbox_name.Text + @"\Seriale_" + Tbox_name.Text + ".png");
                        webClient.Dispose();
                    }
                    Settings.Default.Nr++;
                    DialogResult = DialogResult.OK;
                    Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie dodano miniaturki\n\t" + ex);
                }
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola");
            }
        }

        private void IMAGE_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog opf = new OpenFileDialog())
                {
                    opf.Filter = "PNG files (*.png)|*.png";
                    opf.FilterIndex = 2;
                    opf.RestoreDirectory = true;
                    opf.DefaultExt = "png";
                    opf.Title = "Wczytaj plik";

                    if (opf.ShowDialog() == DialogResult.OK)
                    {
                        tBox_Link.Text = opf.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex, "Błąd");
            }
        }
    }
}