using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Urun
    {   [Key]
        public int UrunID { get; set; }
        public int UrunAdi { get; set; }
        public string Renk { get; set; }
        public string Boyut { get; set; }
        public int MarkaID { get; set; }
        public Marka Marka { get; set; }
        public int MusteriID { get; set; }
        public Musteri Musteri { get; set; }
    }
}
