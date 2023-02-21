using System;
using System.Windows.Forms;

namespace Serialak
{
    public partial class Lokalizacja : Form
    {
        public Lokalizacja()
        {
            InitializeComponent();
        }

        private void B_zmien_Click(object sender, EventArgs e)
        {
            Save.InitialDirectory = @"C:\";
            Save.FileName = "Seriale.xml";
            Save.FilterIndex = 0;
            Save.Title = "Wybór lokalizacji";
            Save.CheckFileExists = false;
            Save.CheckPathExists = true;
            Save.DefaultExt = "xml";
            Save.Filter = "XML files (*.xml)|*.xml";
            if (Save.ShowDialog() == DialogResult.OK)
            {
                tBox_loc.Text = Save.FileName;
            }
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}