using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coursework.Data.Ticket
{
    public class Ticket
    {
        [Key]
        public Int32 Id { get; set; }

        [Required(ErrorMessage ="Ticket title is required*")]
        [StringLength(155, ErrorMessage ="Exceeds the work limit",MinimumLength =5)]
        [MinLength(5,ErrorMessage ="Minimum length must be greater than 5")]
        public String Title { get; set; }

        [Required(ErrorMessage ="Ticket description is required*")]
        [StringLength(250, ErrorMessage ="Exceeds the word limit")]
        public String Description { get; set; }

        [EmailAddress]
        public String Assignee { get; set; }

        [Required(ErrorMessage ="Ticket status is required*")]
        public String Status { get; set; }

        [Required(ErrorMessage ="Due date is required*")]
        public DateTime DueDate { get; set; }

        public String ProjectId { get; set; }
    }
}
