using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treća_zadaća.Modeli
{
    public class AutobusnaStanica
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Lokacija { get; set; }

        public AutobusnaStanica(int id, string naziv, string lokacija)
        {
            ID = id;
            Naziv = naziv;
            Lokacija = lokacija;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Naziv: {Naziv}, Lokacija: {Lokacija}";
        }
    }
}
