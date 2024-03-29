﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.xmp.impl.xpath;
using Org.BouncyCastle.Asn1.Ocsp;
using Serialak.Properties;

namespace Serialak
{
    public partial class Serialak : Form
    {
        private readonly List<string> Losowanie = new List<string>();
        private readonly List<string> Spis = new List<string>();
        private readonly List<string> Link = new List<string>();
        private readonly List<string> pliki = new List<string>();
        private readonly Random rnd = new Random();
        private string Seriale;
        private static readonly string Imagepng = Settings.Default.Nazwa + @"\Images\";
        private bool check = false;
        private bool checkimg = false;
        private bool correct = false;
        private readonly DateTime thisDay = DateTime.Today;
        private readonly iTextSharp.text.Font fontTinyItalic = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1257, 18, iTextSharp.text.Font.BOLD);
        private readonly iTextSharp.text.Font fontCell = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, 15);
        public static string Wybrany;

        private const string UploadFileName = "Kopia.rar";
        private const string DirectoryId = "1CghG8xIM4kLoabsIsA-FhBLXSPDkFkrB";
        
        private readonly string PathToServiceAccountKeyFile = AppDomain.CurrentDomain.BaseDirectory + @"\Key.json";

        private static string fileid;
        private bool error = true;

        public Serialak()
        {
            InitializeComponent();
            Width = 1537;
            Height = 862;
            dane_seriale.DefaultCellStyle.Font = FontFam(14);
            dane_seriale.AlternatingRowsDefaultCellStyle.Font = FontFam(14);
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
                    Spis.Add(node2.SelectSingleNode("Ilość_sezonów").InnerText);
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
                        Spis.Add(node2.SelectSingleNode("Ilość_sezonów").InnerText);
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
                    row.Height = 45;
                }
                if (row.Cells[8].Value.ToString() == "Skończone")
                {
                    row.DefaultCellStyle.SelectionBackColor = Color.Teal;
                    row.DefaultCellStyle.BackColor = Color.Teal;
                    row.DefaultCellStyle.ForeColor = Color.White;
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
                    row.DefaultCellStyle.BackColor = Color.MediumAquamarine;
                    row.DefaultCellStyle.SelectionBackColor = Color.MediumAquamarine;
                }
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell
                {
                    LinkColor = Color.Green,
                    TrackVisitedState = false,
                    ActiveLinkColor = Color.GreenYellow
                };
                if (row.Cells[7].Value.ToString() != "Brak")
                {
                    row.Cells[7] = linkCell;
                    row.Cells[7].Value = "LINK";
                }
                DataGridViewImageCell imgcell = new DataGridViewImageCell();
                row.Cells[0] = imgcell;
                try
                {
                    using (System.Drawing.Image myimage = System.Drawing.Image.FromFile(Imagepng + row.Cells[1].Value.ToString().Replace(" ", "_") + ".png"))
                    {
                        var image = ResizeImage(myimage, new Size(150, 150));
                        row.Cells[0].Value = image;
                    }
                }
                catch
                {
                    System.Drawing.Image myimage = Resources.no_image_icon_6;
                    var image = ResizeImage(myimage, new Size(150, 150));
                    row.Cells[0].Value = image;
                }
            }

            dane_seriale.DefaultCellStyle.SelectionBackColor
            = dane_seriale.DefaultCellStyle.BackColor;
            string toBeSearched = "Seriale_";
            string code = Seriale.Substring(Seriale.IndexOf(toBeSearched) + toBeSearched.Length);
            string name = code.Remove(code.Length - 4);
            Lbl_profil.UseMnemonic = false;
            Lbl_profil.Text = name;
            dane_seriale.ClearSelection();
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
                do
                {
                    foreach (DataGridViewRow row in dane_seriale.Rows)
                    {
                        if (row.Cells[1].Value.ToString() == wylosowane)
                        {
                            if (row.Cells[8].Value.ToString() != "Skończone")
                            {
                                row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                                row.DefaultCellStyle.SelectionBackColor = Color.DarkSeaGreen;
                                correct = true;
                            }
                            else
                            {
                                x = rnd.Next(Losowanie.Count());

                                wylosowane = Losowanie.ElementAt(x);
                                correct = false;
                            }
                        }
                    }
                } while (!correct);

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
                    csv.AppendLine("Nazwa\tAktualny odcinek\tAktualny sezon\tIlość sezonów\tWychodzi\tOstatnio oglądany\tLink");
                    foreach (DataGridViewRow row in dane_seriale.Rows)
                    {
                        var first = row.Cells[1].Value;
                        var second = row.Cells[2].Value;
                        var third = row.Cells[3].Value;
                        var fourth = row.Cells[4].Value;
                        var fifth = row.Cells[5].Value;
                        var sixth = row.Cells[6].Value;
                        var seventh = row.Cells[7].Value;
                        var newLine = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", first, second, third, fourth, fifth, sixth, seventh);
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
                            PdfPTable pdfTable = new PdfPTable(dane_seriale.ColumnCount - 2);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            pdfTable.DefaultCell.BorderWidth = 1;
                            pdfTable.WidthPercentage = 100;

                            foreach (DataGridViewColumn column in dane_seriale.Columns)
                            {
                                if (column.Name != "end" && column.Name != "obrazek")
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontTinyItalic));

                                    pdfTable.AddCell(cell);
                                }
                            }

                            foreach (DataGridViewRow row in dane_seriale.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.ColumnIndex != 9 && cell.ColumnIndex != 0)
                                    {
                                        PdfPCell cell1 = new PdfPCell(new Phrase(cell.Value.ToString(), fontCell));
                                        if (cell.Value.ToString() != "Brak" && cell.ColumnIndex == 7)
                                        {
                                            PdfPCell cell2 = new PdfPCell(new Phrase("Zawiera", fontCell));
                                            pdfTable.AddCell(cell2);
                                        }
                                        else
                                        {
                                            pdfTable.AddCell(cell1);
                                        }
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


        protected System.Drawing.Font FontFam(int size)
        {
            FontFamily fontFamily = new FontFamily("Comic Sans MS");
            System.Drawing.Font font = new System.Drawing.Font(
               fontFamily,
               size,
               FontStyle.Bold);
            return font;
        }

        private void ZapiszDoPlikuXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dane_seriale.Rows.Count > 0)
                {
                    Save.InitialDirectory = Seriale;
                    Save.FileName = "Seriale.rar";
                    Save.FilterIndex = 0;
                    Save.Title = "Zapisz plik";
                    Save.CheckFileExists = false;
                    Save.CheckPathExists = true;
                    Save.DefaultExt = "rar";
                    Save.Filter = "RAR files (*.rar)|*.rar";

                    if (Save.ShowDialog() == DialogResult.OK)
                    {
                        string startPath = Settings.Default.Nazwa;
                        string zipPath = Save.FileName;
                        try
                        {
                            ZipFile.CreateFromDirectory(startPath, zipPath);
                        }
                        catch
                        {
                            File.Delete(zipPath);
                            ZipFile.CreateFromDirectory(startPath, zipPath);
                        }
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
                    string startPath = AppDomain.CurrentDomain.BaseDirectory + @"\Data\";
                    string zipPath = bak + "backup.zip";
                    ZipFile.CreateFromDirectory(startPath, zipPath);
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
                    opf.Filter = "RAR files (*.rar)|*.rar";
                    opf.FilterIndex = 2;
                    opf.RestoreDirectory = true;
                    opf.DefaultExt = "rar";
                    opf.Title = "Wczytaj plik";

                    if (opf.ShowDialog() == DialogResult.OK)
                    {
                        if (!Directory.Exists(Settings.Default.Nazwa + @"\Images\"))
                        {
                            Directory.CreateDirectory(Settings.Default.Nazwa + @"\Images\");
                        }
                        pliki.Add(Directory.GetFiles(Settings.Default.Nazwa, "*.xml")[0]);
                        File.Delete(Directory.GetFiles(Settings.Default.Nazwa, "*.xml")[0]);

                        var files = Directory.GetFiles(Settings.Default.Nazwa + @"\Images\", "*.png");
                        foreach (var f in files)
                        {
                            File.Delete(f);
                        }
                        ZipFile.ExtractToDirectory(opf.FileName, Settings.Default.Nazwa);
                        files = Directory.GetFiles(Settings.Default.Nazwa, "*.xml");
                        var i = 0;
                        foreach (var f in files)
                        {
                            MessageBox.Show(f);
                            FileInfo fi = new FileInfo(f);
                            fi.MoveTo(pliki[i++]);
                        }
                        files = Directory.GetFiles(Settings.Default.Nazwa, "*.png");
                        foreach (var f in files)
                        {
                            string name = f.Remove(f.Length - 4) + ".xml";
                            if (name != Seriale)
                            {
                                File.Delete(f);
                            }
                        }

                        MessageBox.Show("Pomyślnie wczytano plik");
                        Zaladuj(false);
                    }
                    else
                    {
                        MessageBox.Show("Za dużo profili");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nie udało się wczytać profilu", "Błąd");
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
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Kopia.rar");
            ZipFile.CreateFromDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data", AppDomain.CurrentDomain.BaseDirectory+@"\Kopia.rar");
            Task listenerTask = Task.Run(() => ToReadAsync());
            listenerTask.Wait();
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Kopia.rar");
            Settings.Default.Ended = cbox_ogladane.Checked;
            Settings.Default.IMG = cBox_IMG.Checked;
            Settings.Default.Save();
        }

        private void Serialak_Load(object sender, EventArgs e)
        {
            Task listenerTaskOpen = Task.Run(() => ToReadAsyncOpen());
            listenerTaskOpen.Wait();

            using (Profil profil = new Profil())
            {
                if (profil.ShowDialog() == DialogResult.OK)
                {
                    Seriale = Directory.GetFiles(Settings.Default.Nazwa, "*.xml")[0];
                    Zaladuj(false);
                }
                else
                {
                    MessageBox.Show("Nie znaleziono profilu!!");
                    Application.Exit();
                }
            }
            cbox_ogladane.Checked = Settings.Default.Ended;
            cBox_IMG.Checked = Settings.Default.IMG;
        }

        private void CBox_IMG_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkimg)
            {
                dane_seriale.Columns[0].Visible = true;
                dane_seriale.Columns[0].Width = 150;
                foreach (DataGridViewRow row in dane_seriale.Rows)
                {
                    row.Height = 150;
                }
                dane_seriale.DefaultCellStyle.Font = FontFam(20);
                dane_seriale.AlternatingRowsDefaultCellStyle.Font = FontFam(20);

                checkimg = true;
            }
            else
            {
                dane_seriale.Columns[0].Visible = false;
                foreach (DataGridViewRow row in dane_seriale.Rows)
                {
                    row.Height = 45;
                }

                dane_seriale.DefaultCellStyle.Font = FontFam(14);
                dane_seriale.AlternatingRowsDefaultCellStyle.Font = FontFam(14);

                checkimg = false;
            }
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            dane_seriale.Rows.Clear();
            Lbl_profil.Text = "";
            using (Profil profil = new Profil())
            {
                if (profil.ShowDialog() == DialogResult.OK)
                {
                    Seriale = Directory.GetFiles(Settings.Default.Nazwa, "*.xml")[0];
                    Zaladuj(false);
                }
                else
                {
                    MessageBox.Show("Nie znaleziono profilu!!");
                    Application.Exit();
                }
            }
        }

        private async Task ToReadAsyncOpen()
        {
            var credential = GoogleCredential.FromFile(PathToServiceAccountKeyFile).CreateScoped(new[] { DriveService.ScopeConstants.Drive });

            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential
            });

            var request = service.Files.List();
            request.Q = "parents in '1CghG8xIM4kLoabsIsA-FhBLXSPDkFkrB'";
            var response = await request.ExecuteAsync();
            
            foreach (var driveFiles in response.Files)
            {

                error = false;
                
                fileid = driveFiles.Id;
            }
            if (error == true)
            {
                MessageBox.Show("Nie znaleziono zapisanych profili");
            }
            else
            {

                if (response.Files.Count() > 0)
                {


                    var downloadFile = response.Files.FirstOrDefault();
                    var getRequest = service.Files.Get(downloadFile.Id);
                    var fileStream = new FileStream(downloadFile.Name, FileMode.Create, FileAccess.Write);
                    await getRequest.DownloadAsync(fileStream);

                    getRequest.Fields = "parents";
                    var file = getRequest.Execute();
                    var previousParents = string.Join(",", file.Parents);
                    var updateRequest =
                        service.Files.Update(new Google.Apis.Drive.v3.Data.File(),
                            fileid);
                    updateRequest.Fields = "id, parents";
                    updateRequest.RemoveParents = previousParents;
                    updateRequest.Execute();
                    fileStream.Close();
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                service.Dispose();

                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data");
                }
                DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"\Data");

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
                ZipFile.ExtractToDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Kopia.rar", AppDomain.CurrentDomain.BaseDirectory + @"\Data");
            }

        }
        private async Task ToReadAsync()
        {

            var credential = GoogleCredential.FromFile(PathToServiceAccountKeyFile).CreateScoped(DriveService.ScopeConstants.Drive);
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential
            });
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = UploadFileName,
                Parents = new List<string>() { DirectoryId }
            };

            string uploadedFileId;
             using (var fsSource = new FileStream(UploadFileName, FileMode.Open, FileAccess.Read))
            {
                var request = service.Files.Create(fileMetadata, fsSource, "*/*");
                var results = await request.UploadAsync(CancellationToken.None);

                if (results.Status == Google.Apis.Upload.UploadStatus.Failed)
                {
                    MessageBox.Show("Error");
                }
                uploadedFileId = request.ResponseBody?.Id;
            }
        }
    }
}