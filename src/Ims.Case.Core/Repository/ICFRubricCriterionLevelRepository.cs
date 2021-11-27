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
    public interface ICFRubricCriterionLevelRepository : IDisposable
    {
        Task<List<CFRubricCriterionLevel>> GetAllAsync(CancellationToken ct = default);

        Task<CFRubricCriterionLevel> GetByIdAsync(string sourcedId, CancellationToken ct = default);

        Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default);
    }
}
