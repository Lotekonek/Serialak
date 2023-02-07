using Serialak;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Serialak
{
    public partial class Dodawanie : Form
    {
        DateTime thisDay = DateTime.Today;
        XDocument xml;

        bool check = false;
        public Dodawanie()
        {

            InitializeComponent();
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
            string sezon = ilosc_Sezony.Value.ToString();
            string odcinek = ilosc_odcinki.Value.ToString();
            string tyg = ch_box.Text;

            if (check == true)
            {
                sezon = "";
                odcinek = "";
            }
            else
            {
                tyg = "";
            }

            if (!File.Exists(@"C:\Seriale\Seriale.xml"))
            {
                Directory.CreateDirectory(@"C:\Seriale");
                xml = new XDocument(
                   new XDeclaration("1.0", "utf-8", "true"),
                   new XElement("Spis"));
            }

            else
            {
                xml = XDocument.Load(@"C:\Seriale\Seriale.xml");
            }

            xml.Element("Spis").Add(
                            new XElement("Serial",
                            new XAttribute("Name", tBox_nazwa.Text),
                            new XElement("Nazwa", tBox_nazwa.Text),
                            new XElement("Aktualny_odcinek",1),
                            new XElement("Aktualny_sezon",1),
                            new XElement("Ilość_Odcinków", odcinek),
                             new XElement("Ilość_Sezonów", sezon),
                            new XElement("Dzień_tygodnia", tyg),
                            new XElement("Ostatnio_oglądany", thisDay.ToString("M")),
                            new XElement("Link", tBox_Link.Text),
                            new XElement("Status")));
           xml.Save(@"C:\Seriale\Seriale.xml");
           

            this.Close();
            MessageBox.Show("Poprawnie wczytano serial");

            

        }

    } 
    }
  
