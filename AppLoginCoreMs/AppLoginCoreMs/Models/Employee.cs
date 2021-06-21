using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppLoginCoreMs.Models
{
    public class Employee
    {
        [Key]
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string name { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Documento")]
        public string dni { get; set; }

        [Display(Name = "Actividades")]
        public List<Activities> activity { get; set; }
    }
}
