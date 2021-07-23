using System;
using System.Collections.Generic;

#nullable disable

namespace Carnation.NewModels
{
    public partial class SimpleUserLoginLog
    {
        public int Suid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? InTime { get; set; }
    }
}
