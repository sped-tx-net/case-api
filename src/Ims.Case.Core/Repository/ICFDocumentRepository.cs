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
    public interface ICFDocumentRepository : IDisposable
    {
        Task<List<CFDocument>> GetAllAsync(CancellationToken ct = default);

        Task<CFDocument> GetByIdAsync(string sourcedId, CancellationToken ct = default);

        Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default);
    }
}
