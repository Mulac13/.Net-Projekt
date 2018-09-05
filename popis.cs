using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excel_tablice_projekt
{
    public partial class popis : Form
    {
        public popis()
        {
            InitializeComponent();
        }

        private void popis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablicaDataSet.Proizvod' table. You can move, or remove it, as needed.
            this.proizvodTableAdapter.Fill(this.tablicaDataSet.Proizvod);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "ID (najveći prema najmanji)")
            {
                dataGridView1.DataSource = tablicaDataSet.Proizvod.OrderByDescending(x => x.id).ToList();
            }
            else if (this.comboBox1.Text == "ID (najmanji prema najveći)")
            {
                dataGridView1.DataSource = tablicaDataSet.Proizvod.OrderBy(x => x.id).ToList();
            }
            else if (this.comboBox1.Text == "Naziv (A do Z)")
            {
                dataGridView1.DataSource = tablicaDataSet.Proizvod.OrderBy(x => x.NazivProizvoda).ToList();
            }
            else if (this.comboBox1.Text == "Naziv (Z do A)")
            {
                dataGridView1.DataSource = tablicaDataSet.Proizvod.OrderByDescending(x => x.NazivProizvoda).ToList();
            }
            else if (this.comboBox1.Text == "Šifra proizvoda (najveća prema najmanja)")
            {
                dataGridView1.DataSource = tablicaDataSet.Proizvod.OrderByDescending(x => x.SifraProizvoda).ToList();
            }
            else if (this.comboBox1.Text == "Šifra proizvoda (najmanja prema najveća)")
            {
                dataGridView1.DataSource = tablicaDataSet.Proizvod.OrderBy(x => x.SifraProizvoda).ToList();
            }
            else if (this.comboBox1.Text == "Mjerna jedinica (A do Z)")
            {
                dataGridView1.DataSource = tablicaDataSet.Proizvod.OrderBy(x => x.MjernaJedinica).ToList();
            }
            else if (this.comboBox1.Text == "Mjerna jedinica (Z do A)")
            {
                dataGridView1.DataSource = tablicaDataSet.Proizvod.OrderByDescending(x => x.MjernaJedinica).ToList();
            }
            else if (this.comboBox1.Text == "Količina (najveća prema najmanja)")
            {
                dataGridView1.DataSource = tablicaDataSet.Proizvod.OrderByDescending(x => x.Kolicina).ToList();
            }
            else if (this.comboBox1.Text == "Količina (najmanja prema najveća)")
            {
                dataGridView1.DataSource = tablicaDataSet.Proizvod.OrderBy(x => x.Kolicina).ToList();
            }
        }
    }
}
