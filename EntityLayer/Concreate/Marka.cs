using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Marka
    {
        [Key]
        public int MarkaID { get; set; }
        public string MarkaAdi { get; set; }
        public List< Urun> Uruns { get; set; }

    }
}
