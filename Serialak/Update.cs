using System;
using System.Collections.Generic;
using System.Configuration;
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
        private readonly string sAttr;
        private readonly XDocument xdoc;
        private readonly List<string> Seriale = new List<string>();
        private readonly DateTime thisDay = DateTime.Today;

        public Update()
        {
            sAttr = ConfigurationManager.AppSettings.Get("Lokalizacja");
            xdoc = XDocument.Load(sAttr);
            InitializeComponent();
            Laduj();
        }

        private void Laduj()
        {
            Seriale.Clear();
            cBox.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(sAttr);
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
            elSezon.Value = n_sez.Value.ToString();
            elOdcinek.Value = n_odc.Value.ToString();
            elLast.Value = thisDay.ToString("M");

            xdoc.Save(sAttr);
            this.DialogResult = DialogResult.OK;
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