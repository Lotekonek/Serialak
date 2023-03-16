using Serialak.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Serialak
{
    public partial class Deletpro : Form
    {
        private static readonly string Seriale = AppDomain.CurrentDomain.BaseDirectory + @"Data\";
        private readonly List<string> files = new List<string>();
        private string[] profiles;

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

                        Directory.Delete(profiles[row.Index],true);
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

        private void Deletpro_Load(object sender, EventArgs e)
        {
            dane_usuwanie.Rows.Clear();
            profiles = Directory.GetDirectories(Seriale);
            foreach (var profil in profiles)
            {
                var pliki = Directory.GetFiles(profil,"*.xml");
                foreach (var p in pliki)
                {
                    files.Add(p);
                }
            }
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