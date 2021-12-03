using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILveILCEJSON_ENTITYMODELS.Classlar
{
   public class IL
    {
        //c# property kurallarına göre IL isimli class ı oluşturduk
        //JSONIL class deseralize olunca ordaki dataları Il class ından türeteceğimiz neyseye aktaracağız.
        public string ILAdi { get; set; }
        public byte PlakaKodu { get; set; }
        public List<string> Ilceleri { get; set;}

    }
}
