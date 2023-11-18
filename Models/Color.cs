using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HaVanThy_DoAn_WebDoTheThaoNike.Models
{
    public class Color
    {
        [Key]
        public int ColorID { get; set; }
        public string ColorName { get; set; }

        public virtual ICollection<ProductColor> ProductColors { get; set; }
    }
}