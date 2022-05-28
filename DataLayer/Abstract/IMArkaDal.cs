using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IMArkaDal
    {
        List<Marka> ListAllMarka();
        void AddMarka(Marka marka);
        List<Marka> GetListAll();
        void Insert(Marka marka);
    }
}
