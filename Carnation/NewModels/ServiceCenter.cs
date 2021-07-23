using System;
using System.Collections.Generic;

#nullable disable

namespace Carnation.NewModels
{
    public partial class ServiceCenter
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ScenterState { get; set; }
        public string ScenterCity { get; set; }
        public string Slocation { get; set; }
    }
}
