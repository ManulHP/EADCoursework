using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Coursework.Data.Project
{
    public class Project
    {
        [Key]
        public Int32 Id { get; set; }

        [Required(ErrorMessage = "Company name is required*")]
        [StringLength(55, ErrorMessage = "Exceeds the word link")]
        [MinLength(5,ErrorMessage ="The minimum length of the text should 5")]
        public String CompanyName { get; set; }

        [Required(ErrorMessage ="Title is required*")]
        [StringLength(255, ErrorMessage ="Exceeded the word limit")]
        public String Title { get; set; }

        [StringLength(255, ErrorMessage ="Exceeds the word limit")]
        public String Description { get; set; }

        [Required(ErrorMessage ="Project type is required*")]
        public String ProjectType { get; set; }

    }
}
