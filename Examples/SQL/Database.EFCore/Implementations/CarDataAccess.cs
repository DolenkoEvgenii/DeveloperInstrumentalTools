using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Database.EFCore.Contracts;
using Database.EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.EFCore.Implementations
{
    public class CarModelDataAccess : ICarModelDataAccess
    {
        private ExampleContext ExampleContext { get; }
        
        public CarModelDataAccess(ExampleContext exampleContext)
        {
            ExampleContext = exampleContext;
        }

        public async Task<IEnumerable<CarModelEntity>> GetAllAsync(CancellationToken ct = default)
        {
            return await this.ExampleContext.CarModels
                .Include(x => x.Car)
                .OrderBy(x => x.Id)
                .ToListAsync(ct);
        }
    }
}