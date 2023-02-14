using iTextSharp.text;
using iTextSharp.text.pdf;
using Syncfusion.Pdf.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
        private readonly Random rnd = new Random();
        private readonly XDocument xdoc;

        public Serialak(Random rnd)
        {
            this.rnd = rnd;
        }

        private bool check = false;
        private readonly DateTime thisDay = DateTime.Today;
        private readonly XDocument xml;

        public Serialak()
        {
            InitializeComponent();
            if (!File.Exists(@"C:\Seriale\Seriale.xml"))
            {
                Directory.CreateDirectory(@"C:\Seriale");
                xml = new XDocument(
                   new XDeclaration("1.0", "utf-8", "true"),
                   new XElement("Spis"));
                xml.Save(@"C:\Seriale\Seriale.xml");
                xdoc = XDocument.Load(@"C:\Seriale\Seriale.xml");
            }
            Zaladuj();
        }

        private string UppercaseFirst(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }

        public void Zaladuj()
        {
            dane_seriale.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Seriale\Seriale.xml");
            XmlNodeList node = doc.DocumentElement.SelectNodes("/Spis/Serial");
            foreach (XmlNode node2 in node)
            {
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
                Spis.Clear();
            }
            foreach (DataGridViewRow row in dane_seriale.Rows)
            {
                if (row.Cells[8].Value.ToString() == "Skończone")
                {
                    row.DefaultCellStyle.SelectionBackColor = Color.Green;
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.Cells[8].Value = "Oglądane";
                }
                if (row.Cells[5].Value.ToString() == "")
                {
                    row.Cells[5].Value = "Nie";
                }
                if (UppercaseFirst(thisDay.ToString("dddd")) == row.Cells[5].Value.ToString())
                {
                    row.DefaultCellStyle.BackColor = Color.Aqua;
                    row.DefaultCellStyle.SelectionBackColor = Color.Aqua;
                }
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell
                {
                    Value = row.Cells[7].Value
                };
                if (row.Cells[7].Value.ToString() != "Brak")
                {
                    row.Cells[7] = linkCell;
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
                    Zaladuj();
            }
        }

        private void Usuń_Click(object sender, EventArgs e)
        {
            using (Form delete = new Delete())
            {
                if (delete.ShowDialog() == DialogResult.OK)
                    Zaladuj();
            }
        }

        private void Losuj_Click(object sender, EventArgs e)
        {
            Zaladuj();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Seriale\Seriale.xml");
            XmlNodeList node = doc.DocumentElement.SelectNodes("/Spis/Serial/Nazwa");
            foreach (XmlNode node2 in node)
            {
                Losowanie.Add(node2.InnerText);
            }
            int x = rnd.Next(Losowanie.Count());
            var wylosowane = Losowanie.ElementAt(x);
            foreach (DataGridViewRow row in dane_seriale.Rows)
            {
                if (row.Cells[0].Value.ToString() == wylosowane)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                }
            }
            Losowanie.Clear();
        }

        private void Aktualizuj_Click(object sender, EventArgs e)
        {
            using (Form akt = new Update())
            {
                if (akt.ShowDialog() == DialogResult.OK)
                    Zaladuj();
            }
        }

        private void Dane_seriale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;

                if (dane_seriale.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell)
                {
                    System.Diagnostics.Process.Start(dane_seriale.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as string);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błędny link" + ex);
            }
        }

        private void Cbox_ogladane_CheckedChanged(object sender, EventArgs e)
        {
            if (!check)
            {
                dane_seriale.Rows.Clear();
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\Seriale\Seriale.xml");
                XmlNodeList node = doc.DocumentElement.SelectNodes("/Spis/Serial");
                foreach (XmlNode node2 in node)
                {
                    if (node2.SelectSingleNode("Status").InnerText != "Skończone")
                    {
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
                        Spis.Clear();
                    }
                }
                foreach (DataGridViewRow row in dane_seriale.Rows)
                {
                    if (row.Cells[5].Value.ToString() == "")
                    {
                        row.Cells[5].Value = "Nie";
                    }
                    if (UppercaseFirst(thisDay.ToString("dddd")) == row.Cells[5].Value.ToString())
                    {
                        row.DefaultCellStyle.BackColor = Color.Aqua;
                        row.DefaultCellStyle.SelectionBackColor = Color.Aqua;
                    }
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell
                    {
                        Value = row.Cells[7].Value
                    };
                    if (row.Cells[7].Value.ToString() != "Brak")
                    {
                        row.Cells[7] = linkCell;
                    }

                    dane_seriale.DefaultCellStyle.SelectionBackColor
                    = dane_seriale.DefaultCellStyle.BackColor;
                }
                check = true;
            }
            else
            {
                Zaladuj();
                check = false;
            }
        }

        private void CSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            csv.AppendLine("Nazwa\tAktualny odcinek\tAktualny sezon\tIlość odcinków\tIlość sezonów\tWychodzi\tOstatnio oglądany\tLink");
            foreach (DataGridViewRow row in dane_seriale.Rows)
            {
                var first = row.Cells[0].Value;
                var second = row.Cells[1].Value;
                var third = row.Cells[2].Value;
                var fourth = row.Cells[3].Value;
                var fifth = row.Cells[4].Value;
                var sixth = row.Cells[5].Value;
                var seventh = row.Cells[6].Value;
                var eighth = row.Cells[7].Value;
                var newLine = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", first, second, third, fourth, fifth, sixth, seventh, eighth);
                csv.AppendLine(newLine);
            }
            Save.InitialDirectory = @"C:\Seriale";
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

        private void PDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dane_seriale.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "Seriale.pdf"
                };
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dane_seriale.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            PdfStandardFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Italic);

                            foreach (DataGridViewColumn col in dane_seriale.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dane_seriale.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    if (dcell.ColumnIndex == 7 && dcell.Value.ToString() != "Brak")
                                    {
                                        pTable.AddCell("Zawiera");
                                    }
                                    else
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Udało się zapisać plik", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Wystąpił błąd" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie znaleziono danych", "Info");
            }
        }

        private void Btn_end_Click(object sender, EventArgs e)
        {
            btn_end.Visible = false;
            btn_approve.Visible = true;
            dane_seriale.Columns["end"].Visible = true;
            lbl1.Visible = true;
        }

        private void Btn_approve_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            btn_end.Visible = true;
            btn_approve.Visible = false;
            dane_seriale.Columns["end"].Visible = false;

            try
            {
                foreach (DataGridViewRow row in dane_seriale.Rows)
                {
                    var nazwa = row.Cells[0].Value as string;
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
                xdoc.Save(@"C:\Seriale\Seriale.xml");
                Zaladuj();
                MessageBox.Show("Poprawnie zaktualizowano seriale");
            }
        }
    }
}