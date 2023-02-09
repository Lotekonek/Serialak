using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Serialak
{
    public partial class Delete : Form
    {
        private readonly List<string> Seriale = new List<string>();

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

        private void Btn_delete_Click(object sender, EventArgs e)
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

            Close();
        }
    }
}