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
        public String Title { get; set; }
        public String Description { get; set; }

        public String ProjectId { get; set; }

        public ICollection<Coursework.Data.Project.Project> Projects { get; set; }

    }
}
