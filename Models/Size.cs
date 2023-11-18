using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HaVanThy_DoAn_WebDoTheThaoNike.Models
{
    public class Size
    {
        [Key]
        public int SizeID { get; set; }
        public string SizeName { get; set; }

        public virtual ICollection<ProductSize> ProductSizes { get; set; }
    }
}