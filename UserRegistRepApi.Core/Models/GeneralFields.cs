using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistRepApi.Core.Models
{
    public class ExtendFields
    {

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? RegistUserID { get; set; }

        [Required]
        public DateTime RegistDate { get; set; }=DateTime.Now;

        public bool Available => !EndDate.HasValue || EndDate.Value >= DateTime.Now;
    }

    public class ExtendReqFields
    {
        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public int RegistUserID { get; set; }

        [Required]
        public DateTime RegistDate { get; set; } = DateTime.Now;
        public bool Available => !EndDate.HasValue || EndDate.Value >= DateTime.Now;
    }
}
