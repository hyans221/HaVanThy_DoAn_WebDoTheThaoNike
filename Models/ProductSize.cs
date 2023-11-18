using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HaVanThy_DoAn_WebDoTheThaoNike.Models
{
    public class ProductSize
    {
        [Key]
        public int ProductSizeID { get; set; }
        public int ProductID { get; set; }
        public int SizeID { get; set; }

        public virtual Product Product { get; set; }
        public virtual Size Size { get; set; }
    }
}