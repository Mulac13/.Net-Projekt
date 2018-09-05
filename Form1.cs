using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace excel_tablice_projekt
{
    public partial class Form1 : Form
    {
        tablicaEntities db = new tablicaEntities();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {      
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = @"Excel files | *.xlsx";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String path = dialog.FileName;
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()))
                {
                    var wb = new ExcelPackage(reader.BaseStream);
                    var ws = wb.Workbook.Worksheets[1];

                    for (int i = ws.Dimension.Start.Row; i <= ws.Dimension.End.Row; i++)
                    {
                        var sifraProizvoda = ws.Cells[i, 2].Value.ToString();
                        if (db.Proizvod.Any(x => x.SifraProizvoda == sifraProizvoda))
                        {
                            var proizvod = db.Proizvod.First(x => x.SifraProizvoda == sifraProizvoda);
                            proizvod.Kolicina += int.Parse(ws.Cells[i, 4].Value.ToString());
                            db.SaveChanges();
                        }
                        else
                        {
                            db.Proizvod.Add(new Proizvod
                            {
                                NazivProizvoda = ws.Cells[i, 1].Value.ToString(),
                                SifraProizvoda = ws.Cells[i, 2].Value.ToString(),
                                MjernaJedinica = ws.Cells[i, 3].Value.ToString(),
                                Kolicina = int.Parse(ws.Cells[i, 4].Value.ToString())
                            });
                            db.SaveChanges();
                        }
                    }

                    wb.Dispose();
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var popis = new popis();
            popis.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
