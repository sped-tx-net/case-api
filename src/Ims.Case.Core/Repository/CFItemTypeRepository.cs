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
    public class CFItemTypeRepository : ICFItemTypeRepository
    {
        private readonly CaseApiContext _context;

        public CFItemTypeRepository(CaseApiContext context)
        {
            _context = context;
        }

        public void Dispose() => _context.Dispose();

        public async Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFItemType.AnyAsync(e => e.Id.ToString() == sourcedId, ct);

        public async Task<List<CFItemType>> GetAllAsync(CancellationToken ct = default) =>
            await _context.CFItemType.AsNoTracking().ToListAsync(ct);

        public async Task<CFItemType> GetByIdAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFItemType.FindAsync(new object[] { new Guid(sourcedId) }, ct);
    }
}
