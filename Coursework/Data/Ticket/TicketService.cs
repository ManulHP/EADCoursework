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

        #region Insert Ticket
        public async Task<bool> InsertTicketAsync(Coursework.Data.Ticket.Ticket ticket)
        {
            await _appDBContext.Tickets.AddAsync(ticket);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get List of Ticket
        public async Task<List<Coursework.Data.Ticket.Ticket>> GetAllTicketAsync()
        {
            var queryToSelectAllData = await (from pro in _appDBContext.Tickets
                                              select pro).ToListAsync();

            //return await _appDBContext.Tickets.ToListAsync();
            return queryToSelectAllData;
        }
        #endregion

        #region Update Ticket
        public async Task<bool> UpdateTicket(Coursework.Data.Ticket.Ticket ticket)
        {
            _appDBContext.Tickets.Update(ticket);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Ticket by Id
        public async Task<Coursework.Data.Ticket.Ticket> GetTicketAsync(int Id)
        {
            Coursework.Data.Ticket.Ticket ticket = await _appDBContext.Tickets.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return ticket;
        }
        #endregion

        #region Get ticket by project id
        public async Task<List<Coursework.Data.Ticket.Ticket>> GetTicketByProjectIdAsync(String Id)
        {
           
            var queryProjectId = await (
               from ticket in _appDBContext.Tickets
               where ticket.ProjectId == Id
               select ticket
                ).ToListAsync();
            return queryProjectId;
        }
        #endregion

        #region Get ticket by project id(Array)
        public async Task<Coursework.Data.Ticket.Ticket[]> GetTicketByProjectIdReportAsync(String Id)
        {

            var queryProjectId = await (
               from ticket in _appDBContext.Tickets
               where ticket.ProjectId == Id
               select ticket
                ).ToArrayAsync();
            return queryProjectId;
        }
        #endregion

        #region Delete ticket
        public async Task<bool> DeleteTicketAsync(Coursework.Data.Ticket.Ticket ticket)
        {
            _appDBContext.Remove(ticket);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

    }
}
