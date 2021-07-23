using System;
using System.Collections.Generic;

#nullable disable

namespace Carnation.NewModels
{
    public partial class AdminTable
    {
        public int Auid { get; set; }
        public string GroupName { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public DateTime? CreatedInfo { get; set; }
    }
}
