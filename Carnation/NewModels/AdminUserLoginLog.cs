using System;
using System.Collections.Generic;

#nullable disable

namespace Carnation.NewModels
{
    public partial class AdminUserLoginLog
    {
        public int Auid { get; set; }
        public string GroupName { get; set; }
        public DateTime? InTime { get; set; }
    }
}
