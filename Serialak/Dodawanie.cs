using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Serialak
{
    public partial class Dodawanie : Form
    {
        private readonly DateTime thisDay = DateTime.Today;
        private XDocument xml;
        private bool check = false;

        public Dodawanie()
        {
            InitializeComponent();
            Serialak series = new Serialak();
            series.Zaladuj();
        }

        private void Ch_box_CheckedChanged(object sender, EventArgs e)
        {
            if (check == false)
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
            if (tBox_nazwa.Text == "")
            {
                MessageBox.Show("Wpisz nazwę");
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
                DialogResult dr = MessageBox.Show("Wykryto błędny link, czy chcesz go poprawić?",
                      "Błędny link!!!", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        return;
                    case DialogResult.No:
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

            xml = XDocument.Load(@"C:\Seriale\Seriale.xml");

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
            xml.Save(@"C:\Seriale\Seriale.xml");

            
            
            this.DialogResult = DialogResult.OK;



            Close();
            MessageBox.Show("Poprawnie wczytano serial");
        }
    }
}