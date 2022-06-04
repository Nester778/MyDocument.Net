using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyDocument4.Domain
{
    public class User
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Planet")]
        public string Planet { get; set; }

        [Display(Name = "Number")]
        public int Number { get; set; }
    }
}
