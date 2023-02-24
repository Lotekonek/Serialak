using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using Serialak.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Serialak
{
    public partial class Serialak : Form
    {
        private readonly List<string> Losowanie = new List<string>();
        private readonly List<string> Spis = new List<string>();
        private readonly List<string> Link = new List<string>();
        private readonly Random rnd = new Random();
        private static readonly string Seriale = AppDomain.CurrentDomain.BaseDirectory + @"Data\Seriale.xml";
        private static readonly string Imagepng = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Images\";
        private bool check = false;
        private bool checkimg = false;
        private readonly DateTime thisDay = DateTime.Today;
        private readonly XDocument xml;
        private readonly iTextSharp.text.Font fontTinyItalic = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1257, 18, iTextSharp.text.Font.BOLD);
        private readonly iTextSharp.text.Font fontCell = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, 15);

        public Serialak()
        {
            InitializeComponent();

            if (!File.Exists(Seriale))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data");
                xml = new XDocument(
                   new XDeclaration("1.0", "utf-8", "true"),
                   new XElement("Spis"));
                xml.Save(Seriale);
            }

            
            Zaladuj(false);
        }



        private string UppercaseFirst(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }

        public static System.Drawing.Image ResizeImage(System.Drawing.Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }
     
        
   
public void Zaladuj(bool ended)
        {
            dane_seriale.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(Seriale);
            XmlNodeList node = doc.DocumentElement.SelectNodes("/Spis/Serial");
            foreach (XmlNode node2 in node)
            {
                if (ended == false && cbox_ogladane.Checked == true)
                {
                    Spis.Add("");
                    Spis.Add(node2.SelectSingleNode("Nazwa").InnerText);
                    Spis.Add(node2.SelectSingleNode("Aktualny_odcinek").InnerText);
                    Spis.Add(node2.SelectSingleNode("Aktualny_sezon").InnerText);
                    Spis.Add(node2.SelectSingleNode("Ilość_Odcinków").InnerText);
                    Spis.Add(node2.SelectSingleNode("Ilość_Sezonów").InnerText);
                    Spis.Add(node2.SelectSingleNode("Dzień_tygodnia").InnerText);
                    Spis.Add(node2.SelectSingleNode("Ostatnio_oglądany").InnerText);
                    Spis.Add(node2.SelectSingleNode("Link").InnerText);
                    Spis.Add(node2.SelectSingleNode("Status").InnerText);
                    dane_seriale.Rows.Add(Spis.ToArray());
                    Link.Add(node2.SelectSingleNode("Link").InnerText);
                    Spis.Clear();
                }
                else
                {
                    if (node2.SelectSingleNode("Status").InnerText != "Skończone")
                    {
                        Spis.Add("");
                        Spis.Add(node2.SelectSingleNode("Nazwa").InnerText);
                        Spis.Add(node2.SelectSingleNode("Aktualny_odcinek").InnerText);
                        Spis.Add(node2.SelectSingleNode("Aktualny_sezon").InnerText);
                        Spis.Add(node2.SelectSingleNode("Ilość_Odcinków").InnerText);
                        Spis.Add(node2.SelectSingleNode("Ilość_Sezonów").InnerText);
                        Spis.Add(node2.SelectSingleNode("Dzień_tygodnia").InnerText);
                        Spis.Add(node2.SelectSingleNode("Ostatnio_oglądany").InnerText);
                        Spis.Add(node2.SelectSingleNode("Link").InnerText);
                        Spis.Add(node2.SelectSingleNode("Status").InnerText);
                        dane_seriale.Rows.Add(Spis.ToArray());
                        Link.Add(node2.SelectSingleNode("Link").InnerText);
                        Spis.Clear();
                    }
                }
                
            }

            foreach (DataGridViewRow row in dane_seriale.Rows)
            {
                if (cBox_IMG.Checked)
                {
                    row.Height = 150;
                }
                else
                {
                    row.Height = 22;
                }
                if (row.Cells[9].Value.ToString() == "Skończone")
                {
                    row.DefaultCellStyle.SelectionBackColor = Color.Green;
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.Cells[9].Value = "Oglądane";
                }
                if (row.Cells[6].Value.ToString() == "")
                {
                    row.Cells[6].Value = "Nie";
                }
                if (UppercaseFirst(thisDay.ToString("dddd")) == row.Cells[6].Value.ToString())
                {
                    row.DefaultCellStyle.BackColor = Color.Aqua;
                    row.DefaultCellStyle.SelectionBackColor = Color.Aqua;
                }
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                if (row.Cells[8].Value.ToString() != "Brak")
                {
                    row.Cells[8] = linkCell;
                    row.Cells[8].Value = "LINK";
                }
                DataGridViewImageCell imgcell = new DataGridViewImageCell();
                row.Cells[0] = imgcell;
                try
                {
                    System.Drawing.Image myimage = System.Drawing.Image.FromFile(Imagepng + row.Cells[1].Value.ToString().Replace(" ","_") + ".png");
                    var image = ResizeImage(myimage, new Size(150, 150));
                    row.Cells[0].Value = image;
                }
                catch {
                    System.Drawing.Image myimage = Resources.no_image_icon_6;
                    var image = ResizeImage(myimage, new Size(150, 150));
                    row.Cells[0].Value = image;
                }
            }

            dane_seriale.DefaultCellStyle.SelectionBackColor
            = dane_seriale.DefaultCellStyle.BackColor;
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            using (Form ADD = new Dodawanie())
            {
                if (ADD.ShowDialog() == DialogResult.OK)
                    Zaladuj(false);
            }
        }

        private void Usuń_Click(object sender, EventArgs e)
        {
            if (dane_seriale.Rows.Count > 0)
            {
                using (Form delete = new Delete())
                {
                    if (delete.ShowDialog() == DialogResult.OK)
                        Zaladuj(false);
                }
            }
            else
            {
                MessageBox.Show("Brak seriali do usunięcia", "Błąd!");
            }
        }

        private void Losuj_Click(object sender, EventArgs e)
        {
            try
            {
                Zaladuj(false);
                XmlDocument doc = new XmlDocument();
                doc.Load(Seriale);
                XmlNodeList node = doc.DocumentElement.SelectNodes("/Spis/Serial/Nazwa");
                foreach (XmlNode node2 in node)
                {
                    Losowanie.Add(node2.InnerText);
                }
                int x = rnd.Next(Losowanie.Count());
                var wylosowane = Losowanie.ElementAt(x);
                foreach (DataGridViewRow row in dane_seriale.Rows)
                {
                    if (row.Cells[1].Value.ToString() == wylosowane)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    }
                }
                Losowanie.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Brak seriali do wylosowania", "Błąd!");
            }
        }

        private void Aktualizuj_Click(object sender, EventArgs e)
        {
            if (dane_seriale.Rows.Count > 0)
            {
                using (Form akt = new Update())
                {
                    if (akt.ShowDialog() == DialogResult.OK)
                        Zaladuj(false);
                }
            }
            else
            {
                MessageBox.Show("Brak seriali do modyfikacji", "Błąd!");
            }
        }

        private void Dane_seriale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;

                if (dane_seriale.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell)
                {
                    System.Diagnostics.Process.Start(Link[e.RowIndex]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błędny link" + ex, "Błąd!");
            }
        }

        private void Cbox_ogladane_CheckedChanged(object sender, EventArgs e)
        {
            if (!check)
            {
                Zaladuj(false);
                check = true;
            }
            else
            {
                Zaladuj(true);
                check = false;
            }
        }

        private void CSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dane_seriale.Rows.Count > 0)
                {
                    var csv = new StringBuilder();
                    csv.AppendLine("Nazwa\tAktualny odcinek\tAktualny sezon\tIlość odcinków\tIlość sezonów\tWychodzi\tOstatnio oglądany\tLink");
                    foreach (DataGridViewRow row in dane_seriale.Rows)
                    {
                        var first = row.Cells[1].Value;
                        var second = row.Cells[2].Value;
                        var third = row.Cells[3].Value;
                        var fourth = row.Cells[4].Value;
                        var fifth = row.Cells[5].Value;
                        var sixth = row.Cells[6].Value;
                        var seventh = row.Cells[7].Value;
                        var eighth = row.Cells[8].Value;
                        var newLine = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", first, second, third, fourth, fifth, sixth, seventh, eighth);
                        csv.AppendLine(newLine);
                    }
                    Save.InitialDirectory = @"C:\";
                    Save.FileName = "Seriale.csv";
                    Save.FilterIndex = 0;
                    Save.Title = "Zapisz plik";
                    Save.CheckFileExists = false;
                    Save.CheckPathExists = true;
                    Save.DefaultExt = "csv";
                    Save.Filter = "CSV files (*.csv)|*.csv";

                    if (Save.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(Save.FileName, csv.ToString());
                        MessageBox.Show("Pomyślnie zapisano plik");
                    }
                }
                else
                {
                    MessageBox.Show("Nie znaleziono danych", "Błąd!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd " + ex, "Błąd!");
            }
        }

        private void PDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dane_seriale.Rows.Count > 0)
            {
                Save.Filter = "PDF (*.pdf)|*.pdf";
                Save.FileName = "Seriale.pdf";
                bool fileError = false;
                if (Save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(Save.FileName))
                    {
                        try
                        {
                            File.Delete(Save.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Nie udało się zapisać pliku na dysku." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dane_seriale.ColumnCount - 1);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            pdfTable.DefaultCell.BorderWidth = 1;
                            pdfTable.WidthPercentage = 100;

                            foreach (DataGridViewColumn column in dane_seriale.Columns)
                            {
                                if (column.Name != "end")
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontTinyItalic));

                                    pdfTable.AddCell(cell);
                                }
                            }

                            foreach (DataGridViewRow row in dane_seriale.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.ColumnIndex != 10)
                                    {
                                        PdfPCell cell1 = new PdfPCell(new Phrase(cell.Value.ToString(), fontCell));
                                        if (cell.Value.ToString() != "Brak" && cell.ColumnIndex == 8)
                                        {
                                            PdfPCell cell2 = new PdfPCell(new Phrase("Zawiera", fontCell));
                                            pdfTable.AddCell(cell2);
                                        }
                                        else
                                            pdfTable.AddCell(cell1);
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(Save.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Udało się zapisać plik");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Błąd: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Brak danych", "Błąd!");
            }
        }

        private void Btn_end_Click(object sender, EventArgs e)
        {
            cbox_ogladane.Checked = false;
            cbox_ogladane.Enabled = false;
            if (dane_seriale.Rows.Count > 0)
            {
                btn_end.Visible = false;
                btn_approve.Visible = true;
                dane_seriale.Columns["end"].Visible = true;
                lbl1.Visible = true;
            }
            else
            {
                MessageBox.Show("Brak seriali do zakończenia", "Błąd!");
            }
        }

        private void Btn_approve_Click(object sender, EventArgs e)
        {
            cbox_ogladane.Enabled = true;
            bool zmiana = false;
            lbl1.Visible = false;
            btn_end.Visible = true;
            btn_approve.Visible = false;
            dane_seriale.Columns["end"].Visible = false;
            XDocument xdoc = XDocument.Load(Seriale);
 

            try
            {
                foreach (DataGridViewRow row in dane_seriale.Rows)
                {
                    var nazwa = row.Cells[1].Value as string;
                    if (Convert.ToBoolean(row.Cells[end.Name].Value) == true)
                    {
                        var elStatus = xdoc.Descendants()?.
                        Elements("Nazwa")?.
                        Where(x => x.Value == nazwa)?.
                        Ancestors("Serial");

                        var elOdcinek = elStatus.Elements("Aktualny_odcinek").FirstOrDefault();
                        var elSezon = elStatus.Elements("Aktualny_sezon").FirstOrDefault();
                        var elOdcineki = elStatus.Elements("Ilość_Odcinków").FirstOrDefault();
                        var elSezoni = elStatus.Elements("Ilość_Sezonów").FirstOrDefault();
                        var elEnded = elStatus.Elements("Status").FirstOrDefault();
                        var elTyg = elStatus.Elements("Dzień_tygodnia").FirstOrDefault();
                        if (elOdcinek != null || elSezon != null || elEnded != null || elOdcineki != null || elSezoni != null || elTyg != null)
                        {
                            elOdcineki.Value = elOdcinek.Value;
                            elSezoni.Value = elSezon.Value;
                            elOdcinek.Value = "";
                            elSezon.Value = "";
                            elEnded.Value = "Skończone";
                            elTyg.Value = "";
                            zmiana = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex);
            }
            finally
            {
                if (zmiana)
                {
                    if (dane_seriale.Rows.Count <= 0)
                    {
                        MessageBox.Show("Nie wybrano żadnego serialu!!!", "Błąd");
                    }
                    else
                    {
                        xdoc.Save(Seriale);
                        Zaladuj(false);
                        MessageBox.Show("Poprawnie zaktualizowano seriale");
                    }
                }
            }
        }

        private void ZapiszDoPlikuXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dane_seriale.Rows.Count > 0)
                {
                    Save.InitialDirectory = Seriale;
                    Save.FileName = "Seriale.xml";
                    Save.FilterIndex = 0;
                    Save.Title = "Zapisz plik";
                    Save.CheckFileExists = false;
                    Save.CheckPathExists = true;
                    Save.DefaultExt = "xml";
                    Save.Filter = "XML files (*.xml)|*.xml";

                    if (Save.ShowDialog() == DialogResult.OK)
                    {
                        File.Copy(Seriale, Save.FileName, true);
                        MessageBox.Show("Pomyślnie zapisano plik");
                    }
                }
                else
                {
                    MessageBox.Show("Nie znaleziono danych", "Błąd!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd " + ex, "Błąd!");
            }
        }

        private void ZapiszBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bak = AppDomain.CurrentDomain.BaseDirectory + @"\Backup\";
            try
            {
                if (dane_seriale.Rows.Count > 0)
                {
                    if (!Directory.Exists(bak))
                    {
                        Directory.CreateDirectory(bak);
                    }
                    File.Copy(Seriale, bak + "Seriale.bak", true);
                    MessageBox.Show("Pomyślnie zrobiono backup");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd " + ex, "Błąd!");
            }
        }

        private void WczytajZPlikuXMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog opf = new OpenFileDialog())
                {
                    opf.Filter = "XML files (*.xml)|*.xml";
                    opf.FilterIndex = 2;
                    opf.RestoreDirectory = true;
                    opf.DefaultExt = "xml";
                    opf.Title = "Wczytaj plik";

                    if (opf.ShowDialog() == DialogResult.OK)
                    {
                        File.Copy(opf.FileName, Seriale, true);
                        MessageBox.Show("Pomyślnie wczytano plik");
                        Zaladuj(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex, "Błąd");
            }
        }

        private void WczytajbackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog opf = new OpenFileDialog())
                {
                    opf.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    opf.Filter = "BAK files (*.bak)|*.bak";
                    opf.FilterIndex = 2;
                    opf.RestoreDirectory = true;
                    opf.DefaultExt = "bak";
                    opf.Title = "Wczytaj plik";

                    if (opf.ShowDialog() == DialogResult.OK)
                    {
                        File.Copy(opf.FileName, Seriale, true);
                        MessageBox.Show("Pomyślnie wczytano backup");
                        Zaladuj(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex, "Błąd");
            }
        }

        private void Serialak_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Ended = cbox_ogladane.Checked;
            Properties.Settings.Default.IMG = cBox_IMG.Checked;
            Properties.Settings.Default.Save();
        }

        private void Serialak_Load(object sender, EventArgs e)
        {

            cbox_ogladane.Checked = Properties.Settings.Default.Ended;
            cBox_IMG.Checked = Properties.Settings.Default.IMG;
        }

        private void CBox_IMG_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkimg)
            {
                dane_seriale.Columns[0].Visible = true;
                dane_seriale.Columns[0].Width = 150;
                foreach (DataGridViewRow row in dane_seriale.Rows) { 
                row.Height = 150;
                    }
                checkimg = true;
            }
            else
            {
                dane_seriale.Columns[0].Visible = false;
                foreach (DataGridViewRow row in dane_seriale.Rows)
                {
                    row.Height = 22;
                }


                checkimg = false;
            }
        }
    }
}