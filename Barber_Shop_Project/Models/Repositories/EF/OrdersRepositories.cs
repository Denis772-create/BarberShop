using Barber_Shop_Project.Models.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barber_Shop_Project.Models.Repositories.EF
{
    public class OrdersRepositories : IOrdersRepositories
    {
        private readonly BSDbContext _bsDbContext;

        public OrdersRepositories(BSDbContext bsDbContext)
        {
            this._bsDbContext = bsDbContext;
        }

        public async Task AddOrderAsync(Order order)
        {
            await _bsDbContext.Orders.AddAsync(order);
            await _bsDbContext.SaveChangesAsync();
        }
    }
}