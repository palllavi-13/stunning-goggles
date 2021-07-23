using System;
using System.Collections.Generic;

#nullable disable

namespace Carnation.NewModels
{
    public partial class ProductDetail
    {
        public Guid Pid { get; set; }
        public string Pname { get; set; }
        public string Pcompany { get; set; }
        public double Pprice { get; set; }
        public string Pdescription { get; set; }
        public string Uname { get; set; }
        public string Pquality { get; set; }
    }
}
