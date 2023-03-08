using Serialak.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Serialak
{
    public partial class Deletpro : Form
    {
        private static readonly string Seriale = AppDomain.CurrentDomain.BaseDirectory + @"Data\";

        public Deletpro()
        {
            InitializeComponent();
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
                        File.Delete(Seriale  + "Seriale_" + row.Cells[0].Value.ToString().Replace(" ", "_") + ".png");
                        File.Delete(Seriale  + "Seriale_" + row.Cells[0].Value.ToString().Replace(" ", "_") + ".xml");
                    }
                }
            }
            catch
            {
            }
            finally
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Deletpro_Load(object sender, EventArgs e)
        {
            dane_usuwanie.Rows.Clear();
            var files = Directory.GetFiles(Seriale, "*.xml");
            foreach (var file in files)
            {
                string toBeSearched = "Seriale_";
                string code = file.Substring(file.IndexOf(toBeSearched) + toBeSearched.Length);
                string name = code.Remove(code.Length - 4);
                dane_usuwanie.Rows.Add(name);
            }
        }
    }
}