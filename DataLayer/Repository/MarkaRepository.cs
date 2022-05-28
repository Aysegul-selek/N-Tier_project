using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Abstract;
using DataLayer.Concreate;
using EntityLayer.Concreate;

namespace DataLayer.Repository
{
    public class MarkaRepository : IMArkaDal
    {
        Context c = new Context();
        public void AddMarka(Marka marka)
        {
            c.Add(marka);
            c.SaveChanges();
        }

        public List<Marka> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Marka marka)
        {
            throw new NotImplementedException();
        }

        public List<Marka> ListAllMarka()
        {
            return c.MArkas.ToList();
        }
    }
}
