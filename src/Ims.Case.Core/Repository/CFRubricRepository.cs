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
    public class CFRubricRepository : ICFRubricRepository
    {
        private readonly CaseApiContext _context;

        public CFRubricRepository(CaseApiContext context)
        {
            _context = context;
        }

        public void Dispose() => _context.Dispose();

        public async Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFRubric.AnyAsync(e => e.Id.ToString() == sourcedId, ct);

        public async Task<List<CFRubric>> GetAllAsync(CancellationToken ct = default) =>
            await _context.CFRubric.AsNoTracking().ToListAsync(ct);

        public async Task<CFRubric> GetByIdAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFRubric.FindAsync(new object[] { new Guid(sourcedId) }, ct);
    }
}
