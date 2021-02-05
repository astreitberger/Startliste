using SQLite;
using Startlist.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Startlist.Services
{
    public class SqlData : IStartliste
    {​​​​
        private string Filename {​​​​ get; set; }​​​​ = "Startliste.db";

        private string Dir {​​​​ get; set; }​​​​ = Directory.GetCurrentDirectory();



        private string StartlisteFilePath {​​​​ get; set; }​​​​



        private SQLiteConnection Conn {​​​​ get; set; }​​​​
        public string Vorname { get ; set ; }
        public string Nachname { get; set; }
        public string Geschlecht { get; set; }
        public string Nation { get; set; }
        public int Startnummer { get; set; }

        public SqlData()
        {​​​​
            this.StartlisteFilePath = Path.Combine(this.Dir, this.Filename);



            var options = new SQLiteConnectionString(this.StartlisteFilePath, true);
            this.Conn = new SQLiteConnection(options);



            this.Conn.CreateTable<Startliste>();
        }​​​​



        public List<IStartliste> All()
        {​​​​
            var starter = from s in this.Conn.Table<Startliste>()
              select new Startliste()
              {​​​​
                  Startnummer = s.Startnummer,
                  Vorname = s.Vorname,
                  Nachname = s.Nachname,
                  Geschlecht = s.Geschlecht,
                  Nation = s.Nation
              }​​​​;
            return starter.ToList<IStartliste>();
        }​​​​



        public bool Add(IStartliste startliste)
        {​​​​
            var count = this.Conn.Insert(startliste);
            return count > 0;
        }​​​​



        public bool Delete(IStartliste startliste)
        {​​​​
            var item = from st in this.Conn.Table<Startliste>()
            where st.Startnummer == startliste.Startnummer
            select st;
            var count = this.Conn.Delete(item);
            return count > 0;
        }​​​​



        public bool Save()
        {​​​​
            throw new NotImplementedException();
        }​​​​
}​​​​
}
