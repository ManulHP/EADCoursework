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

        #region Get List of Employees
        public async Task<List<Coursework.Data.Project.Project>> GetAllEmployeesAsync()
        {
            return await _appDBContext.Projects.ToListAsync();

        }
        #endregion

        #region Insert Employee
        public async Task<bool> InsertEmployeeAsync(Coursework.Data.Project.Project project)
        {
            await _appDBContext.Projects.AddAsync(project);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Update Employee
        public async Task<bool> UpdateEmployeeAsync(Coursework.Data.Project.Project project)
        {
            _appDBContext.Projects.Update(project);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Employee by Id
        public async Task<Coursework.Data.Project.Project> GetEmployeeAsync(int Id)
        {
            Coursework.Data.Project.Project project = await _appDBContext.Projects.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return project;
        }
        #endregion

        #region DeleteEmployee
        public async Task<bool> DeleteEmployeeAsync(Coursework.Data.Project.Project project)
        {
            _appDBContext.Remove(project);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
