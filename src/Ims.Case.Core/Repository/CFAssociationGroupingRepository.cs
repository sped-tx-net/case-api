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
    public class CFAssociationGroupingRepository : ICFAssociationGroupingRepository
    {
        private readonly CaseApiContext _context;

        public CFAssociationGroupingRepository(CaseApiContext context)
        {
            _context = context;
        }

        public void Dispose() => _context.Dispose();

        public async Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFAssociationGrouping.AnyAsync(e => e.Id.ToString() == sourcedId, ct);

        public async Task<List<CFAssociationGrouping>> GetAllAsync(CancellationToken ct = default) =>
            await _context.CFAssociationGrouping.AsNoTracking().ToListAsync(ct);

        public async Task<CFAssociationGrouping> GetByIdAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFAssociationGrouping.FindAsync(new object[] { new Guid(sourcedId) }, ct);
    }
}
