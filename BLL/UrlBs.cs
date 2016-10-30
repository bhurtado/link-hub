using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class UrlBs
    {
        private UrlDb _objDb;

        public UrlBs()
        {
            this._objDb = new UrlDb();
        }

        public IEnumerable<Url> GetAll()
        {
            return _objDb.GetAll();
        }

        public Url GetById(int id)
        {
            return _objDb.GetById(id);
        }

        public void Insert(Url objUrl)
        {
            _objDb.Insert(objUrl);
        }

        public void Delete(int id)
        {
            _objDb.Delete(id);
        }

        public void Update(Url objUrl)
        {
            _objDb.Update(objUrl);
        }
        

    }
}
