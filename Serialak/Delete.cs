using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Serialak
{
    public partial class Delete : Form
    {
        List<string> Seriale = new List<string>();
        public Delete()
        {
            InitializeComponent();
            Seriale.Clear();
            c_seriale.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Seriale\Seriale.xml");
            XmlNodeList node = doc.DocumentElement.SelectNodes("/Spis/Serial/Nazwa");
            foreach (XmlNode node2 in node)
            {
                Seriale.Add(node2.InnerText);

            }
            c_seriale.Items.AddRange(Seriale.ToArray());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (c_seriale.Items.Count == 0)
            {
                c_seriale.Visible = false;
                btn_delete.Visible = false;
            }
            else
            {
                var xDoc = XDocument.Load(@"C:\Seriale\Seriale.xml");
                var source = xDoc.Root?.Descendants("Serial")
                    .Where(f => f.Attribute("Name")?.Value == c_seriale.Text)
                    .First();
                xDoc.Root?.Descendants("Serial")
                    .Where(f => f.Attribute("Name")?.Value == c_seriale.Text)
                    .Remove();
                xDoc.Save(@"C:\Seriale\Seriale.xml");
                c_seriale.Text = null;
                c_seriale.Items.Clear();
            }
            
            this.Close();
        }

        private void Delete_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialak series = new Serialak();
            series.Zaladuj();
        }
    }
}
