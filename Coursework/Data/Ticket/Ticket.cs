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
        [Required]
        [StringLength(155)]
        public String Title { get; set; }
        [Required]
        [StringLength(250)]
        public String Description { get; set; }
        public String Assignee { get; set; }
        [Required]
        public String Status { get; set; }
        [Required]
        public DateTime DueDate { get; set; }

        public String ProjectId { get; set; }

      

    }
}
