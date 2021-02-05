using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Startlist.Models
{
    public interface IStartliste
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Geschlecht { get; set; }
        public string Nation { get; set; }
        public int Startnummer { get; set; }
    }
}
