using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Serialak
{
    public partial class Dodawanie : Form
    {
        private readonly DateTime thisDay = DateTime.Today;
        private XDocument xml;
        private bool check = false;
        private bool checkimg = false;
        private static readonly string Seriale = AppDomain.CurrentDomain.BaseDirectory + @"Data\Seriale.xml";
        private static readonly string Image = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Images\";

        public Dodawanie()
        {
            InitializeComponent();
            Serialak series = new Serialak();
            series.Zaladuj(false);
        }

        private void Ch_box_CheckedChanged(object sender, EventArgs e)
        {
            if (!check)
            {
                c_box.SelectedItem = "Poniedziałek";
                lbl_dzien.Visible = true;
                c_box.Visible = true;
                lbl_O.Visible = false;
                lbl_S.Visible = false;
                ilosc_odcinki.Visible = false;
                ilosc_Sezony.Visible = false;
                check = true;
            }
            else
            {
                lbl_dzien.Visible = false;
                c_box.Visible = false;
                lbl_O.Visible = true;
                lbl_S.Visible = true;
                ilosc_odcinki.Visible = true;
                ilosc_Sezony.Visible = true;
                check = false;
            }
        }

        private void Btn_dodaj_Click(object sender, EventArgs e)
        {
            if (cBox_IMG.Checked)
            {
                if(!File.Exists(Image))
                {
                    Directory.CreateDirectory(Image);
                }
                try
                {
                    File.Copy(tBox_IMG.Text, Image + tBox_nazwa.Text.Replace(" ", "_") + ".png");
                }
                catch
                {
                    MessageBox.Show("Nie dodano miniaturki");
                }
            }
            if (tBox_nazwa.Text == "")
            {
                MessageBox.Show("Wpisz nazwę", "Błąd");
                return;
            }
            string sezon = ilosc_Sezony.Value.ToString();
            string odcinek = ilosc_odcinki.Value.ToString();
            string tyg = c_box.Text;
            string link = tBox_Link.Text;

            bool result = Uri.TryCreate(link, UriKind.Absolute, out Uri uriResult)
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
                        link = "";
                        break;
                }
            }

            if (check == true)
            {
                sezon = "";
                odcinek = "";
            }
            else
            {
                tyg = "";
            }
            if (link == "")
            {
                link = "Brak";
            }

            xml = XDocument.Load(Seriale);

            Serialak series = new Serialak();

            foreach (DataGridViewRow row in series.dane_seriale.Rows)
            {
                if (row.Cells[0].Value.ToString() == tBox_nazwa.Text)
                {
                    MessageBox.Show("Taki serial już istnieje!!!");
                    return;
                }
            }

            xml.Element("Spis").Add(
                            new XElement("Serial",
                            new XAttribute("Name", tBox_nazwa.Text),
                            new XElement("Nazwa", tBox_nazwa.Text),
                            new XElement("Aktualny_odcinek", 1),
                            new XElement("Aktualny_sezon", 1),
                            new XElement("Ilość_Odcinków", odcinek),
                             new XElement("Ilość_Sezonów", sezon),
                            new XElement("Dzień_tygodnia", tyg),
                            new XElement("Ostatnio_oglądany", thisDay.ToString("M")),
                            new XElement("Link", link),
                            new XElement("Status")));
            xml.Save(Seriale);

            this.DialogResult = DialogResult.OK;

            Close();
            MessageBox.Show("Poprawnie wczytano serial");
        }

        private void IMAGE_Click(object sender, EventArgs e)
        {
            try {
                using (OpenFileDialog opf = new OpenFileDialog())
                {
                    opf.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    opf.Filter = "PNG files (*.png)|*.png";
                    opf.FilterIndex = 2;
                    opf.RestoreDirectory = true;
                    opf.DefaultExt = "png";
                    opf.Title = "Wczytaj plik";

                    if (opf.ShowDialog() == DialogResult.OK)
                    {
                        tBox_IMG.Text = opf.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex, "Błąd");
            }
}

        private void CBox_IMG_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkimg)
            {
                tBox_IMG.Visible = true;
                label2.Visible = true;
                IMAGE.Visible = true;
                checkimg = true;
            }
            else
            {
                tBox_IMG.Visible = false;
                label2.Visible = false;
                IMAGE.Visible = false;
                checkimg = false;
                tBox_IMG.Text = "";
            }
        }
    }
}