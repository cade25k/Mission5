using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRealASPNETApp.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Please enter a title.")]
        public string title { get; set; }
        [Required(ErrorMessage = "Please enter a year.")]
        public int year { get; set; }
        [Required(ErrorMessage = "Please enter a director.")]
        public string director { get; set; }
        [Required(ErrorMessage = "Please select a rating.")]
        public string rating { get; set; }
        [Required(ErrorMessage = "Please select a categorry.")]
        public int categoryId { get; set; }
        public Category Category { get; set; }
        public bool edited { get; set; }
        public string lentTo { get; set; }
        [StringLength(25)]
        public string notes { get; set; }
    }
}
