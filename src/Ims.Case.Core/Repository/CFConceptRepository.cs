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
    public class CFConceptRepository : ICFConceptRepository
    {
        private readonly CaseApiContext _context;

        public CFConceptRepository(CaseApiContext context)
        {
            _context = context;
        }

        public void Dispose() => _context.Dispose();

        public async Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFConcept.AnyAsync(e => e.Id.ToString() == sourcedId, ct);

        public async Task<List<CFConcept>> GetAllAsync(CancellationToken ct = default) =>
            await _context.CFConcept.AsNoTracking().ToListAsync(ct);

        public async Task<CFConcept> GetByIdAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFConcept.FindAsync(new object[] { new Guid(sourcedId) }, ct);
    }
}
