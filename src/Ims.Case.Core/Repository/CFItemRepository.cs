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
    public class CFItemRepository : ICFItemRepository
    {
        private readonly CaseApiContext _context;

        public CFItemRepository(CaseApiContext context)
        {
            _context = context;
        }

        public void Dispose() => _context.Dispose();

        public async Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFItem.AnyAsync(e => e.Id.ToString() == sourcedId, ct);

        public async Task<List<CFItem>> GetAllAsync(CancellationToken ct = default) =>
            await _context.CFItem.AsNoTracking().ToListAsync(ct);

        public async Task<CFItem> GetByIdAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFItem.FindAsync(new object[] { new Guid(sourcedId) }, ct);
    }
}
