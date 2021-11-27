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
    public class CFRubricCriterionLevelRepository : ICFRubricCriterionLevelRepository
    {
        private readonly CaseApiContext _context;

        public CFRubricCriterionLevelRepository(CaseApiContext context)
        {
            _context = context;
        }

        public void Dispose() => _context.Dispose();

        public async Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFRubricCriterionLevel.AnyAsync(e => e.Id.ToString() == sourcedId, ct);

        public async Task<List<CFRubricCriterionLevel>> GetAllAsync(CancellationToken ct = default) =>
            await _context.CFRubricCriterionLevel.AsNoTracking().ToListAsync(ct);

        public async Task<CFRubricCriterionLevel> GetByIdAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFRubricCriterionLevel.FindAsync(new object[] { new Guid(sourcedId) }, ct);
    }
}
