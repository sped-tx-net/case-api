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
    public interface ICFAssociationGroupingRepository : IDisposable
    {
        Task<List<CFAssociationGrouping>> GetAllAsync(CancellationToken ct = default);

        Task<CFAssociationGrouping> GetByIdAsync(string sourcedId, CancellationToken ct = default);

        Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default);
    }
}
