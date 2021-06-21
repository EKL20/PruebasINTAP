using System;
using System.ComponentModel.DataAnnotations;


namespace AppLoginCoreMs.Models
{
    public class Time
    {
        [Key]
        public long id { get; set; }


        [Required]

        [Display(Name = "Tiempo de Actividad")]
        public double timeAct { get; set; }


        [Display(Name = "Ref de Actividad")]
        public long activities { get; set; }
    }
}
