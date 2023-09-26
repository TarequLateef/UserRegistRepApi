using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistRepApi.Core.Models
{
    [Table(name:"PositionsTBL",Schema ="Users")]
    public class PosistionsTBL:ExtendFields
    {
        [Key]
        public int PositionID { get; set; }

        [Required, MaxLength(75)]
        public string PositionName { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
