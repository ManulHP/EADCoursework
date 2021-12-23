using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Coursework.Data.Ticket
{
    public class TicketService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public TicketService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Insert Employee
        public async Task<bool> InsertEmployeeAsync(Coursework.Data.Ticket.Ticket ticket)
        {
            await _appDBContext.Tickets.AddAsync(ticket);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get List of Employees
        public async Task<List<Coursework.Data.Ticket.Ticket>> GetAllEmployeesAsync()
        {
            return await _appDBContext.Tickets.ToListAsync();
        }
        #endregion
    }
}
