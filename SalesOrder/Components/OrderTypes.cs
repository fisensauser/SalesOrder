using Microsoft.EntityFrameworkCore;
using SalesOrder.Data;
using SalesOrder.Models;

namespace SalesOrder.Components
{
    public class OrderTypes
    {
        public async Task<List<OrderType>> GetTypes(AppDbContext dbc) {
           return await dbc.OrderTypes.AsNoTracking().ToListAsync();
        }
    }
}
