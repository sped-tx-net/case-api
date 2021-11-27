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
    public class CFSubjectRepository : ICFSubjectRepository
    {
        private readonly CaseApiContext _context;

        public CFSubjectRepository(CaseApiContext context)
        {
            _context = context;
        }

        public void Dispose() => _context.Dispose();

        public async Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFSubject.AnyAsync(e => e.Id.ToString() == sourcedId, ct);

        public async Task<List<CFSubject>> GetAllAsync(CancellationToken ct = default) =>
            await _context.CFSubject.AsNoTracking().ToListAsync(ct);

        public async Task<CFSubject> GetByIdAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFSubject.FindAsync(new object[] { new Guid(sourcedId) }, ct);
    }
}
