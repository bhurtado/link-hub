using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class UrlDb
    {
        private LinkHubDbEntities _db;

        public UrlDb()
        {
            this._db = new LinkHubDbEntities();
        }

        public IEnumerable<Url> GetAll()
        {
            return _db.Urls.ToList();      
        }

        public Url GetById(int id)
        {
            return _db.Urls.Find(id);
        }

        public void Insert(Url url)
        {
            _db.Urls.Add(url);
            Save();
        }

        public void Delete(int id)
        {
            Url zaBrisanje = _db.Urls.Find(id);
            _db.Urls.Remove(zaBrisanje);
            Save();
        }

        public void Update(Url url)
        {
            _db.Entry(url).State = System.Data.Entity.EntityState.Modified;
        }

        private void Save()
        {
            _db.SaveChanges();
        }



    }
}
