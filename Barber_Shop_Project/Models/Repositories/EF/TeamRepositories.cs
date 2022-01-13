using Barber_Shop_Project.Models.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Barber_Shop_Project.Models.Repositories.EF
{
    public class TeamRepositories : ITeamRepositories
    {
        private BSDbContext bsDbContext;

        public TeamRepositories(BSDbContext bsDbContext)
        {
            this.bsDbContext = bsDbContext;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await bsDbContext.Employees.ToListAsync();
        }

        public Task<Employee> GetEmployeesByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task AddEmployeeAsync(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}