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
    public class CFAssociationRepository : ICFAssociationRepository
    {
        private readonly CaseApiContext _context;

        public CFAssociationRepository(CaseApiContext context)
        {
            _context = context;
        }

        public void Dispose() => _context.Dispose();

        public async Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFAssociation.AnyAsync(e => e.Id.ToString() == sourcedId, ct);

        public async Task<List<CFAssociation>> GetAllAsync(CancellationToken ct = default) =>
            await _context.CFAssociation.AsNoTracking().ToListAsync(ct);

        public async Task<CFAssociation> GetByIdAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFAssociation.FindAsync(new object[] { new Guid(sourcedId) }, ct);
    }
}
