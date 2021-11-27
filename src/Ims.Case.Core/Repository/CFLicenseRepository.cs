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
    public class CFLicenseRepository : ICFLicenseRepository
    {
        private readonly CaseApiContext _context;

        public CFLicenseRepository(CaseApiContext context)
        {
            _context = context;
        }

        public void Dispose() => _context.Dispose();

        public async Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFLicense.AnyAsync(e => e.Id.ToString() == sourcedId, ct);

        public async Task<List<CFLicense>> GetAllAsync(CancellationToken ct = default) =>
            await _context.CFLicense.AsNoTracking().ToListAsync(ct);

        public async Task<CFLicense> GetByIdAsync(string sourcedId, CancellationToken ct = default) =>
            await _context.CFLicense.FindAsync(new object[] { new Guid(sourcedId) }, ct);
    }
}
