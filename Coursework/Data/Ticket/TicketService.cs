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
        public async Task<bool> InsertTicketAsync(Coursework.Data.Ticket.Ticket ticket)
        {
            await _appDBContext.Tickets.AddAsync(ticket);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get List of Employees
        public async Task<List<Coursework.Data.Ticket.Ticket>> GetAllTicketAsync()
        {
            var queryToSelectAllData = await (from pro in _appDBContext.Tickets
                                              select pro).ToListAsync();

            //return await _appDBContext.Tickets.ToListAsync();
            return queryToSelectAllData;
        }
        #endregion

        #region Update Employee
        public async Task<bool> UpdateTicket(Coursework.Data.Ticket.Ticket ticket)
        {
            _appDBContext.Tickets.Update(ticket);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Employee by Id
        public async Task<Coursework.Data.Ticket.Ticket> GetTicketAsync(int Id)
        {
            Coursework.Data.Ticket.Ticket ticket = await _appDBContext.Tickets.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return ticket;
        }
        #endregion

        public async Task<Coursework.Data.Ticket.Ticket[]> GetTicketsAsync()
        {
            return await _appDBContext.Tickets.ToArrayAsync();
        }
    }
}
