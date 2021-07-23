using System;
using System.Collections.Generic;

#nullable disable

namespace Carnation.NewModels
{
    public partial class MerchantUserLoginLog
    {
        public int Muid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? InTime { get; set; }
    }
}
