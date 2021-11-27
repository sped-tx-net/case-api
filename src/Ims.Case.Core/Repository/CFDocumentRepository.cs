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
    public class CFDocumentRepository : ICFDocumentRepository
    {
        private readonly CaseApiContext _context;

        public CFDocumentRepository(CaseApiContext context)
        {
            _context = context;
        }

        public void Dispose() => _context.Dispose();

        public async Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFDocument.AnyAsync(e => e.Id.ToString() == sourcedId, ct);

        public async Task<List<CFDocument>> GetAllAsync(CancellationToken ct = default) =>
            await _context.CFDocument
            .Include(x => x.SubjectNavigation)
            .Include(x => x.License).AsNoTracking().ToListAsync(ct);

        public async Task<CFDocument> GetByIdAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFDocument
            .Include(x => x.SubjectNavigation)
            .Include(x => x.License)
            .Include(x => x.CFItem)
            .Include(x => x.CFAssociation)
            .FirstOrDefaultAsync(x => new Guid(sourcedId) == x.Id);
    }
}
