using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Serialak.Properties;

namespace Serialak
{
    public partial class Update : Form
    {
        private string nazwa;
        private static readonly string Series = Directory.GetFiles(Settings.Default.Nazwa, "*.xml")[0];
        private static readonly string Image = Settings.Default.Nazwa + @"\Images\";
        private readonly XDocument xdoc;
        private readonly List<string> Seriale = new List<string>();
        private readonly DateTime thisDay = DateTime.Today;
        private bool checkIMG = false;
        private bool checkLink = false;
        private bool checkStatus = false;
        private bool checkout = false;
        private bool checksez = false;

        public Update()
        {
            xdoc = XDocument.Load(Series);
            InitializeComponent();
            Laduj();
        }

        private void Laduj()
        {
            Seriale.Clear();
            cBox.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(Series);
            XmlNodeList node = doc.DocumentElement.SelectNodes("/Spis/Serial/Nazwa");
            foreach (XmlNode node2 in node)
            {
                Seriale.Add(node2.InnerText);
            }
            cBox.Items.AddRange(Seriale.ToArray());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cBox.SelectedItem != null)
            {
                string nazwa = cBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Wybierz serial z listy!!!");
                return;
            }

            var elStatus = xdoc.Descendants()?.
            Elements("Nazwa")?.
            Where(x => x.Value == nazwa)?.
            Ancestors("Serial");
            var elOdcinek = elStatus.Elements("Aktualny_odcinek").FirstOrDefault();
            var elSezon = elStatus.Elements("Aktualny_sezon").FirstOrDefault();
            var elLast = elStatus.Elements("Ostatnio_oglądany").FirstOrDefault();
            var elEnded = elStatus.Elements("Status").FirstOrDefault();
            var elLink = elStatus.Elements("Link").FirstOrDefault();
            var elSezonil = elStatus.Elements("Ilość_sezonów").FirstOrDefault();
            var elTyg = elStatus.Elements("Dzień_tygodnia").FirstOrDefault();
            if (elOdcinek != null || elSezon != null || elLast != null || elEnded != null)
            {
                if (cBox_sezony.Checked)
                {
                    elSezonil.Value = num_sez.Value.ToString();
                }
                if (Radio_end.Checked)
                {
                    elEnded.Value = "Skończone";
                    elLast.Value = thisDay.ToString("M");
                    elSezonil.Value = elSezon.Value.ToString();
                    elTyg.Value = "";
                    elOdcinek.Value = "";
                    elSezon.Value = "";
                }
                else
                {
                    elEnded.Value = "";
                    elOdcinek.Value = n_odc.Value.ToString();
                    elSezon.Value = n_sez.Value.ToString();
                }
                if (Cbox_IMG.Checked)
                {
                    if (!File.Exists(Image))
                    {
                        Directory.CreateDirectory(Image);
                    }
                    try
                    {
                        bool result1 = Uri.TryCreate(Tbox_IMG.Text, UriKind.Absolute, out Uri uriResult1)
                    && (uriResult1.Scheme == Uri.UriSchemeHttp || uriResult1.Scheme == Uri.UriSchemeHttps);
                        if (!result1)
                        {
                            File.Copy(Tbox_IMG.Text, Image + nazwa.Replace(" ", "_") + ".png");
                        }
                        else
                        {
                            WebClient webClient = new WebClient();
                            webClient.DownloadFile(uriResult1, Image + nazwa.Replace(" ", "_") + ".png");
                            webClient.Dispose();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Nie zaktualizowano miniaturki");
                    }
                }

                if (Check_out.Checked)
                {
                    elSezonil.Value = "";
                    elTyg.Value = c_box.Text;
                    if (elEnded.Value == "Skończone")
                    {
                        elEnded.Value = "";
                    }
                }
                if (Cbox_Link.Checked)
                {
                    bool result = Uri.TryCreate(Tbox_Link.Text, UriKind.Absolute, out Uri uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
                    if (!result)
                    {
                        DialogResult dr = MessageBox.Show("Nie wykryto linku, czy chcesz kontynuować?",
                              "Błędny link!!!", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.No:
                                return;

                            case DialogResult.Yes:
                                elLink.Value = "Brak";
                                break;
                        }
                    }
                    else
                    {
                        elLink.Value = Tbox_Link.Text;
                    }
                }

                //if (elEnded.Value != "Skończone")
                //{
                //    elSezon.Value = n_sez.Value.ToString();
                //    elOdcinek.Value = n_odc.Value.ToString();
                //    
                //}
                //else
                //{
                //    MessageBox.Show("Musisz zmienić status serialu");
                //    return;
                //}
            }

            xdoc.Save(Series);

            DialogResult = DialogResult.OK;
            MessageBox.Show("Poprawnie zaktualizowano serial");
            Close();
        }

        private void CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox.SelectedItem != null)
            {
                nazwa = cBox.SelectedItem.ToString();
            }

            var elStatus = xdoc.Descendants()?.
            Elements("Nazwa")?.
            Where(x => x.Value == nazwa)?.
            Ancestors("Serial");
            var elEnded = elStatus.Elements("Status").FirstOrDefault();
            var elOdcinek = elStatus.Elements("Aktualny_odcinek").FirstOrDefault();
            var elSezon = elStatus.Elements("Aktualny_sezon").FirstOrDefault();

            if (elSezon != null || elOdcinek != null || elEnded != null)
            {
                if (elEnded.Value != "Skończone")
                {
                    try
                    {
                        Radio_watch.Checked = true;
                        n_odc.Value = (decimal)elOdcinek;
                        n_sez.Value = (decimal)elSezon;
                    }
                    catch { }
                }
                else
                {
                    Radio_end.Checked = true;
                }
            }
        }

        private void Cbox_IMG_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkIMG)
            {
                label3.Visible = true;
                Tbox_IMG.Visible = true;
                checkIMG = true;
                button2.Visible = true;
            }
            else
            {
                label3.Visible = false;
                Tbox_IMG.Visible = false;
                checkIMG = false;
                button2.Visible = false;
            }
        }

        private void Cbox_Link_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkLink)
            {
                label4.Visible = true;
                Tbox_Link.Visible = true;
                checkLink = true;
            }
            else
            {
                label4.Visible = false;
                Tbox_Link.Visible = false;
                checkLink = false;
            }
        }

        private void Cbox_status_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkStatus)
            {
                label5.Visible = true;
                Radio_end.Visible = true;
                Radio_watch.Visible = true;
                checkStatus = true;
            }
            else
            {
                label5.Visible = false;
                Radio_end.Visible = false;
                Radio_watch.Visible = false;
                checkStatus = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
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
                        Tbox_IMG.Text = opf.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex, "Błąd");
            }
        }

        private void Check_out_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkout)
            {
                label6.Visible = true;
                c_box.Visible = true;
                checkout = true;
            }
            else
            {
                label6.Visible = false;
                c_box.Visible = false;
                checkout = false;
            }
        }

        private void CBox_sezony_CheckedChanged(object sender, EventArgs e)
        {
            if (!checksez)
            {
                label7.Visible = true;
                num_sez.Visible = true;
                checksez = true;
            }
            else
            {
                label7.Visible = false;
                num_sez.Visible = false;
                checksez = false;
            }
        }
    }
}