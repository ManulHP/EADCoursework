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
        [Required(ErrorMessage = "Enter a company name")]
        [StringLength(55, ErrorMessage = "That name is too long")]
        public String CompanyName { get; set; }
        [Required(ErrorMessage ="Enter a titel for the project")]
        [StringLength(255, ErrorMessage ="Exceeded the work count")]
        public String Title { get; set; }
        [StringLength(255)]
        public String Description { get; set; }
        [Required]
        public String ProjectType { get; set; }

        //public Coursework.Data.Ticket.Ticket Tickets { get; set; }

    }
}
