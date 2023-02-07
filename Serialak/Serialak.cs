﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Serialak
{
    public partial class Serialak : Form
    {
        List<string> Losowanie = new List<string>();
        List<string> Spis = new List<string>();
        Random rnd = new Random();
        private Color acolor;

        public Serialak()
        {
            InitializeComponent();
            Zaladuj();
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
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                linkCell.Value = row.Cells[7].Value;
                row.Cells[7] = linkCell;
            }

            foreach (DataGridViewRow row in dane_seriale.Rows)
            {
                if (row.Cells[5].Value.ToString() == "")
                {
                    row.Cells[5].Value = "Nie";
                }
                if (row.Cells[8].Value.ToString() == "Skończone")
                {
                    row.DefaultCellStyle.SelectionBackColor = Color.Green;
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            dane_seriale.DefaultCellStyle.SelectionBackColor
            = dane_seriale.DefaultCellStyle.BackColor;

        }
    

    


        private void Dodaj_Click(object sender, EventArgs e)
        {
            Form ADD = new Dodawanie();
            ADD.ShowDialog();
        }

        private void Usuń_Click(object sender, EventArgs e)
        {
            Form delete = new Delete();
            delete.ShowDialog();    
        }

        private void Losuj_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Seriale\Seriale.xml");
            XmlNodeList node = doc.DocumentElement.SelectNodes("/Spis/Serial/Nazwa");
            foreach (XmlNode node2 in node)
            {
                Losowanie.Add(node2.InnerText);

            }
            int x = rnd.Next(Losowanie.Count());
            MessageBox.Show(Losowanie.ElementAt(x));
            Losowanie.Clear();
        }

        public void Odśwież_Click(object sender, EventArgs e)
        {
            Zaladuj();

        }

        private void dane_seriale_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nazwa = dane_seriale.CurrentRow.Cells[0].Value.ToString();
            XDocument xdoc = XDocument.Load(@"C:\Seriale\Seriale.xml");
            var elStatus = xdoc.Descendants()?.
            Elements("Nazwa")?.
            Where(x => x.Value == nazwa)?.
            Ancestors("Serial");

            var elColor = elStatus.Elements("Status").FirstOrDefault();




            if (dane_seriale.CurrentRow.DefaultCellStyle.BackColor == Color.Green)
            {
                
                dane_seriale.CurrentRow.DefaultCellStyle.SelectionBackColor = acolor;
                dane_seriale.CurrentRow.DefaultCellStyle.BackColor = acolor;
                if (elColor != null)
                {
                    elColor.Value = "";
                }


            }
            else
            {
                acolor = dane_seriale.CurrentRow.DefaultCellStyle.SelectionBackColor;
                dane_seriale.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Green;
                dane_seriale.CurrentRow.DefaultCellStyle.BackColor = Color.Green;
                if (elColor != null)
                {
                    elColor.Value = "Skończone";
                }
            }
            dane_seriale.DefaultCellStyle.SelectionBackColor
            = dane_seriale.DefaultCellStyle.BackColor;
            xdoc.Save(@"C:\Seriale\Seriale.xml");
        }

        private void Aktualizuj_Click(object sender, EventArgs e)
        {
            Form akt = new Update();
            akt.ShowDialog();
        }
    }
    }
