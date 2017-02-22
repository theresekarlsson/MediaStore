using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MediaStore
{
    public class Product
    {
        [DisplayName("Artikelnummer")]
        public string id { get; set; }
        [DisplayName("Titel")]
        public string name { get; set; }
        [DisplayName("Varugrupp")]
        public string type { get; set; }
        [DisplayName("Pris")]
        public string price { get; set; }
        [DisplayName("Antal")]
        public string amount { get; set; }
    }
}
