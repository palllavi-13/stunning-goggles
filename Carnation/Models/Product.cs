using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Carnation.Models
{
    [Table("Product_Detail")]
    public class Product
    {
       
            [Key]
            public Guid PId { get; set; }

            [Column(TypeName = "nvarchar(50)")]
            [DisplayName("Product Name")]
            [Required(ErrorMessage = "Please fill name")]
            public string PName { get; set; }

            [Column(TypeName = "nvarchar(50)")]
            [DisplayName("Product Company")]
            [Required(ErrorMessage = "Please fill company")]
            public string PCompany { get; set; }

            [Column(TypeName = "float")]
            [DisplayName("Price")]
            [Required(ErrorMessage = "please mention price")]
            public double PPrice { get; set; }

            [Column(TypeName = "nvarchar(200)")]
            [DisplayName("Description")]
            [Required(ErrorMessage = "Enter the description eg: Mileage, Model, Kms travelled etc.")]
            public string PDescription { get; set; }

            [Column(TypeName = "nvarchar(100)")]
            [DisplayName("Merchant UserName")]
            [Required(ErrorMessage = "Note: Please correctly enter your UserName used for login")]
            public string UName { get; set; }

            [Column(TypeName = "nvarchar(100)")]
            [DisplayName("Product quality")]
            public string PQuality { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Product Picture")]
        public string PPicture { get; set; }

        [NotMapped]
            [Required(ErrorMessage = "Please Provide the product image")]
            public IFormFile ProductPic { get; set; }
        }
}
