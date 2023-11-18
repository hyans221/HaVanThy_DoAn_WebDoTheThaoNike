using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HaVanThy_DoAn_WebDoTheThaoNike.Models
{
    public class ProductColor
    {
        [Key]
        public int ProductColorID { get; set; }
        public int ProductID { get; set; }
        public int ColorID { get; set; }

        public virtual Product Product { get; set; }
        public virtual Color Color { get; set; }
    }
}