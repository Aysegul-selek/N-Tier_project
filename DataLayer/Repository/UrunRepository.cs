using DataLayer.Abstract;
using DataLayer.Concreate;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class UrunRepository : IUrunDal
    {
        public void AddUrun(Urun urun)
        {
            using var c = new Context();
            c.Add(urun);
            c.SaveChanges();
            
        }

        public List<Urun> ListAllUrun()
        {
            using var c = new Context();
            return c.Uruns.ToList();
        }
    }
}
