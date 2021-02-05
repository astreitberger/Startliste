using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Startlist.Models
{
    public class Startliste : IStartliste
    {
        
       [MaxLength(250), NotNull, Column("Vorname")]
        public string Vorname {​​​​ get; set; }​​​​

        [MaxLength(250), NotNull, Column("Nachname")]
        public string Nachname {​​​​ get; set; }​​​​

        [MaxLength(250), NotNull, Column("Geschlecht")]
        public string Geschlecht {​​​​ get; set; }​​​​

        [MaxLength(250), NotNull, Column("Nation")]
        public string Nation {​​​​ get; set; }​​​​

        [PrimaryKey, Column("Startnummer")]
        public int Startnummer {​​​​ get; set; }​​​​
    }​​​​
}
