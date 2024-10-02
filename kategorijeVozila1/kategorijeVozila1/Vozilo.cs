using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kategorijeVozila1
{
    internal class Vozilo
    {
        string model, kategorija;
        int godinaProizvodnje, brojKotaca;

        public Vozilo(string model, int godinaProizvodnje, int brojKotaca)
        {
            Model = model;
            GodinaProizvodnje = godinaProizvodnje;
            BrojKotaca = brojKotaca;
        }

        public string Model { get => model; set => model = value; }
        public int GodinaProizvodnje { get => godinaProizvodnje; set => godinaProizvodnje = value; }
        public int BrojKotaca { get => brojKotaca; set => brojKotaca = value; }

        public string Kategorija { get => kategorija; set => kategorija = value; }

        public override string ToString()
        {
            //string ispis = this.Ime + "," + this.Prezime + "," + this.Email + "," + this.GodinaRodjenja;

            string ispis = $"{this.Model},{this.GodinaProizvodnje},{this.BrojKotaca},{this.Kategorija}";

            return ispis;
        }
    }
}
