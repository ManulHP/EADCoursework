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
        [StringLength(55)]
        public String Title { get; set; }
        [StringLength(55)]
        public String CompanyName { get; set; }

        public Coursework.Data.Ticket.Ticket Tickets { get; set; }

    }
}
