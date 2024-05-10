using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Modelo
{
    internal class Coche
    {
        public Coche(string matricula, bool cabe = false)
        {
            Matricula = matricula;
            Cabe = cabe;
        }
        public Coche() { }
        public string Matricula { get; set; }
        public bool Cabe { get; set; } = false;

        public override string ToString()
        {
            return "Matricula: " + Matricula + ", ¿y cabe? " + Cabe;
        }

        public override bool Equals(object? obj)
        {
            return obj is Coche coche && Matricula == coche.Matricula;
        }

        // public int CompareTo(Coche other) => this.Matricula.CompareTo(other.Matricula);

        public int CompareTo(Coche other)
        {
            return this.Matricula.CompareTo(other.Matricula);
        }

    }
}
