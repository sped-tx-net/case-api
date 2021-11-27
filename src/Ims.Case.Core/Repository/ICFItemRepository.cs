using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ims.Case.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ims.Case.Repository
{
    public interface ICFItemRepository : IDisposable
    {
        Task<List<CFItem>> GetAllAsync(CancellationToken ct = default);

        Task<CFItem> GetByIdAsync(string sourcedId, CancellationToken ct = default);

        Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default);
    }
}
