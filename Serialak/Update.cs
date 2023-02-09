using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Serialak
{
    public partial class Update : Form
    {
        private string nazwa;
        private readonly XDocument xdoc = XDocument.Load(@"C:\Seriale\Seriale.xml");
        private readonly List<string> Seriale = new List<string>();
        private readonly DateTime thisDay = DateTime.Today;

        public Update()
        {
            InitializeComponent();
            Laduj();
        }

        private void Laduj()
        {
            Seriale.Clear();
            cBox.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Seriale\Seriale.xml");
            XmlNodeList node = doc.DocumentElement.SelectNodes("/Spis/Serial/Nazwa");
            foreach (XmlNode node2 in node)
            {
                Seriale.Add(node2.InnerText);
            }
            cBox.Items.AddRange(Seriale.ToArray());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nazwa = cBox.SelectedItem.ToString();

            var elStatus = xdoc.Descendants()?.
            Elements("Nazwa")?.
            Where(x => x.Value == nazwa)?.
            Ancestors("Serial");
            var elOdcinek = elStatus.Elements("Aktualny_odcinek").FirstOrDefault();
            var elSezon = elStatus.Elements("Aktualny_sezon").FirstOrDefault();
            var elLast = elStatus.Elements("Ostatnio_oglądany").FirstOrDefault();

            if (elSezon != null || elOdcinek != null)
            {
                elSezon.Value = n_sez.Value.ToString();
                elOdcinek.Value = n_odc.Value.ToString();
                elLast.Value = thisDay.ToString("D");
            }
            xdoc.Save(@"C:\Seriale\Seriale.xml");
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

            var elOdcinek = elStatus.Elements("Aktualny_odcinek").FirstOrDefault();
            var elSezon = elStatus.Elements("Aktualny_sezon").FirstOrDefault();

            if (elSezon != null || elOdcinek != null)
            {
                n_odc.Value = (decimal)elOdcinek;
                n_sez.Value = (decimal)elSezon;
            }
        }
    }
}