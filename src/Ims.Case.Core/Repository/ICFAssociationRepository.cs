using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ims.Case.Entities;

namespace Ims.Case.Repository
{
    public interface ICFAssociationRepository : IDisposable
    {
        Task<List<CFAssociation>> GetAllAsync(CancellationToken ct = default);

        Task<CFAssociation> GetByIdAsync(string sourcedId, CancellationToken ct = default);

        Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default);
    }
}
