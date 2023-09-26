using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistRepApi.Core.Models
{
    [Table(name:"UserPositionTBL",Schema ="Users")]
    public class UserPositionTBL:ExtendFields
    {
        [Key]
        public int UserPositionID { get; set; }

        [Required,ForeignKey("fk_UserPos_User")]
        public int UserID { get; set; }

        [Required, ForeignKey("fk_UserPos_Pos")]
        public int PositionID { get; set; }

        public UsersTBL users { get; set; }
        public PosistionsTBL posistions { get; set; }
    }
}
