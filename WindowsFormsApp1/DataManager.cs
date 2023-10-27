using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;


namespace DataManager
{
    class DataManager
    {
        string name, collection;

        public DataManager(string name, string collection) {
            this.name = name;
            this.collection = collection;
        }

        public List<T> Get<T>()
        {
            using (var db = new LiteDatabase(this.name))
            {
                var col = db.GetCollection<T>(collection).FindAll();
                return col.ToList();
            }
        }

        public bool Set(Savable state)
        {
            using (var db = new LiteDatabase(this.name))
            {
                var col = db.GetCollection<Savable>(collection);
              
               try
                {
                    col.EnsureIndex(x => x.IndexID, unique: true);
                    col.Insert(state);
                    col.EnsureIndex(x => x.IndexID, unique: true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                return true;
            }
        }

        public int Delete(Savable state)
        {
            using (var db = new LiteDatabase(this.name))
            {
                var col = db.GetCollection<Savable>(collection);
                return col.DeleteMany(x => x.IndexID == state.IndexID);
            }
        }

        public enum State
        {
            Satılık,
            Kirlaik
        }


        public class Savable
        {
            public string IndexID { get; set; }
        }


        public class RealState : Savable {
            public RealState(string ilanNo, string isim_soyisim, string katagori, string m2, string binaYasi, string odaSayisi, string balkon, string esyali, string aidat, string adres, State durum, string isitma, string telefon)
            {
                this.IndexID = ilanNo;
                this.ilanNo = ilanNo;
                this.isim_soyisim = isim_soyisim;
                this.katagori = katagori;
                this.m2 = m2;
                this.binaYasi = binaYasi;
                this.odaSayisi = odaSayisi;
                this.balkon = balkon;
                this.esyali = esyali;
                this.aidat = aidat;
                this.adres = adres;
                this.durum = durum;
       
                this.isitma = isitma;
                this.telefon = telefon;
            }

            public string ilanNo { get; set; }
            public string isim_soyisim { get; set; }
            public string katagori { get; set; }
            public string m2 { get; set; }
            public string binaYasi { get; set; }
            public string odaSayisi { get; set; }
            public string balkon { get; set; }
            public string esyali { get; set; }
            public string aidat { get; set; }
            public string adres { get; set; }
            public State durum { get; set; }

            public string isitma { get; set; }
            public string telefon { get; set; }

        }

        public class User : Savable
        {
            public string username { get; set; }
            public string password { get; set; }

            public User(string username, string password)
            {
                this.IndexID = username;
                this.username = username;
                this.password = password;
            }

        }








    }
}
