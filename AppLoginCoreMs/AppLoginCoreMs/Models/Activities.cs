using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppLoginCoreMs.Models
{
    public class Activities
    {
        [Key]
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Actividad")]
        public DateTime dateAct { get; set; }

        [Required]
        [Display(Name = "Ref Empleado")]
        public long employeeid { get; set; }

        [Display(Name = "Lista de tiempos")]
        public List<Time> time { get; set; }
    }
}
