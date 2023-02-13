using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Serialak
{
    public partial class Delete : Form
    {
        private readonly List<string> Spis = new List<string>();

        public Delete()
        {
            InitializeComponent();

            dane_usuwanie.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Seriale\Seriale.xml");
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
            try
            {
                foreach (DataGridViewRow row in dane_usuwanie.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[choose.Name].Value) == true)
                    {
                        var xDoc = XDocument.Load(@"C:\Seriale\Seriale.xml");

                        xDoc.Root?.Descendants("Serial")
                            .Where(f => f.Attribute("Name")?.Value == row.Cells[0].Value.ToString())
                            .Remove();
                        xDoc.Save(@"C:\Seriale\Seriale.xml");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd" + ex);
            }
            finally
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dane_usuwanie_CellClick(object sender, DataGridViewCellEventArgs e)
        { if (Convert.ToBoolean(dane_usuwanie.CurrentRow.Cells[choose.Name].Value) == false)
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
 
