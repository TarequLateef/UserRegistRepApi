using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistRepApi.Core.Models
{
    [Table(name:"UsersTBL",Schema ="Users")]
    public class UsersTBL:ExtendFields
    {
        [Key]
        public int UserID { get; set; }

        [MaxLength(100),Required]
        public string UserName { get; set; }

        [MaxLength(100),Required,DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }

        [Required,MaxLength(14)]
        public string NationalNo { get; set; }

        [Required,DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        
        [Required,MaxLength(200)]
        public string Address { get; set; }

        [Required,MaxLength(11)]
        public string PhoneNo { get; set; }

        [Required, MaxLength(11)]
        public string MobileNo { get; set; }

        [Required,MaxLength(150)]
        public string UserPic { get; set; }

    }
}
