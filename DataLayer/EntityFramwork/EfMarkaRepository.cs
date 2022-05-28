using DataLayer.Abstract;
using DataLayer.Repository;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntityFramwork
{
    public class EfMarkaRepository : GenericRepository<Marka>, IMArkaDal
    {
        public void AddMarka(Marka marka)
        {
            throw new NotImplementedException();
        }

        public List<Marka> ListAllMarka()
        {
            throw new NotImplementedException();
        }
    }
}
