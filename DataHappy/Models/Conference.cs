using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataHappy.Models
{
    public class Conference
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Description { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string City { get; set; }

    }
}
