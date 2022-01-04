using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace Coursework.Data.Project
{
    public class ProjectService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public ProjectService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Project
        public async Task<List<Coursework.Data.Project.Project>> GetAllProjectAsync()
        {
            var queryToSelectAllData = await (from pro in _appDBContext.Projects
                                              select pro).ToListAsync();

            //return await _appDBContext.Projects.ToListAsync();
            return queryToSelectAllData;

        }
        #endregion

        #region Insert Project
        public async Task<bool> InsertProjectAsync(Coursework.Data.Project.Project project)
        {
            await _appDBContext.Projects.AddAsync(project);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Update Project
        public async Task<bool> UpdateTicketeAsync(Coursework.Data.Project.Project project)
        {
            _appDBContext.Projects.Update(project);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Project by Id
        public async Task<Coursework.Data.Project.Project> GetProjectByIdAsync(int Id)
        {
            Coursework.Data.Project.Project project = await _appDBContext.Projects.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return project;
        }
        #endregion

        #region Delete ticket
        public async Task<bool> DeleteTicketAsync(Coursework.Data.Project.Project project)
        {
            _appDBContext.Remove(project);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        public async Task<List<Coursework.Data.Project.Project>> GetProjectAsync(int Id)
        {
            //Coursework.Data.Ticket.Ticket ticket = await _appDBContext.Tickets.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            var queryIdProject = await (from pro in _appDBContext.Projects where pro.Id == Id select pro).ToListAsync();
            return queryIdProject;
        }

    }
}
