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
    public class CFRubricCriterionRepository : ICFRubricCriterionRepository
    {
        private readonly CaseApiContext _context;

        public CFRubricCriterionRepository(CaseApiContext context)
        {
            _context = context;
        }

        public void Dispose() => _context.Dispose();

        public async Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFRubricCriterion.AnyAsync(e => e.Id.ToString() == sourcedId, ct);

        public async Task<List<CFRubricCriterion>> GetAllAsync(CancellationToken ct = default) =>
            await _context.CFRubricCriterion.AsNoTracking().ToListAsync(ct);

        public async Task<CFRubricCriterion> GetByIdAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFRubricCriterion.FindAsync(new object[] { new Guid(sourcedId) }, ct);
    }
}
