using Serialak.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Serialak
{
    public partial class Delete : Form
    {
        private readonly List<string> Spis = new List<string>();
        private static readonly string Seriale = Directory.GetFiles(Settings.Default.Nazwa, "*.xml")[0];
        private static readonly string Image = Settings.Default.Nazwa + @"\Images\";

        public Delete()
        {
            InitializeComponent();

            dane_usuwanie.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(Seriale);
            XmlNodeList node = doc.DocumentElement.SelectNodes("/Spis/Serial");
            foreach (XmlNode node2 in node)
            {
                Spis.Add(node2.SelectSingleNode("Nazwa").InnerText);

                dane_usuwanie.Rows.Add(Spis.ToArray());
                Spis.Clear();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy na pewno chcesz usunąć wybrane seriale?",
                  "Potwierdzenie", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    break;

                case DialogResult.No:
                    return;
            }

            try
            {
                foreach (DataGridViewRow row in dane_usuwanie.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[choose.Name].Value) == true)
                    {
                        var xDoc = XDocument.Load(Seriale);

                        xDoc.Root?.Descendants("Serial")
                            .Where(f => f.Attribute("Name")?.Value == row.Cells[0].Value.ToString())
                            .Remove();
                        xDoc.Save(Seriale);


                        File.Delete(Image + row.Cells[0].Value.ToString().Replace(" ", "_") + ".png");
                    }
                }
            }
            catch 
            {
            }
            finally
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Dane_usuwanie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(dane_usuwanie.CurrentRow.Cells[choose.Name].Value) == false)
            {
                dane_usuwanie.CurrentRow.Cells[choose.Name].Value = true;
            }
            else
            {
                dane_usuwanie.CurrentRow.Cells[choose.Name].Value = false;
            }
        }
    }
}