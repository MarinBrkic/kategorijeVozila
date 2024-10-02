using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace kategorijeVozila1
{
    public partial class Form1 : Form
    {
        List<Vozilo> listaVozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo(txtModel.Text, Convert.ToInt16(txtGodinaProizvodnje.Text),
                Convert.ToInt16(txtBrojKotaca.Text));

            txtModel.Clear();
            txtGodinaProizvodnje.Clear();
            txtBrojKotaca.Clear();
            txtModel.Focus();

            DialogResult upit = MessageBox.Show("Želite li unesti još podataka?", "Upit",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (upit)
            {
                case DialogResult.Yes:
                    {
                        listaVozila.Add(vozilo);
                        break;
                    }
                case DialogResult.No:
                    {
                        listaVozila.Add(vozilo);
                        txtModel.Enabled = false;
                        txtGodinaProizvodnje.Enabled = false;
                        txtBrojKotaca.Enabled = false;

                        break;
                    }
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            string putanjaDoDatoteke = "C:\\Users\\Ucenik\\Documents\\TestCSV1";
            try
            {
                // Stvaramo ili otvaramo datoteku za pisanje
                using (StreamWriter sw = new StreamWriter(putanjaDoDatoteke))
                {
                    // Zaglavlje (imena stupaca)
                    sw.WriteLine("Model,GodinaProizvodnje,BrojKotaca");

                    // Iteriramo kroz listu osoba i zapisujemo podatke u datoteku
                    foreach (Vozilo vozilo in listaVozila)
                    {
                        sw.WriteLine(vozilo.ToString());
                    }
                }

                MessageBox.Show("Podaci su uspješno spremljeni u CSV datoteku!", "Uspjeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške prilikom spremanja podataka: " + ex.Message,
                    "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (Vozilo vozilo in listaVozila)
            {
                txtIspis.AppendText(vozilo.ToString());
            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            foreach (Vozilo vozilo in listaVozila)
            {
                if (vozilo.BrojKotaca == 2)
                {
                    vozilo.Kategorija = "Motocikl";
                }
                else if (vozilo.BrojKotaca == 4)
                {
                    vozilo.Kategorija = "Automobil";
                }
                else
                {
                    vozilo.Kategorija = "Kamion";
                }
            }


        }
        }
    }
