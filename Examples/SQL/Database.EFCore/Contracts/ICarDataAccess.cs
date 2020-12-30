using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Database.EFCore.Entities;

namespace Database.EFCore.Contracts
{
    public interface ICarModelDataAccess
    {
        Task<IEnumerable<CarModelEntity>> GetAllAsync(CancellationToken ct = default);
    }
}