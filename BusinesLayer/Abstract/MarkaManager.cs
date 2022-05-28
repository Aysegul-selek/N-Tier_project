using BusinesLayer.Abstract;
using DataLayer.Abstract;
using DataLayer.EntityFramwork;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concreate
{
  public  class MarkaManager : IMarkaServices
    {
        IMArkaDal _markaDal;
       

        public MarkaManager(IMArkaDal markaDal)
        {
            _markaDal = markaDal;
        }

        

        public List<Marka> GetList()
        {
          return _markaDal.GetListAll();
        }

        public void MArkaAdd(Marka marka)
        {
            _markaDal.Insert(marka);
        }
    }
}
