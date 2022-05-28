using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }
        public string UrunAdi { get; set; }
        public string MusteriAdi { get; set; }
        public string Yorum { get; set; }
        public List<Urun> Uruns { get; set; }
    }
}
