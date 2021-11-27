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
    public interface ICFRubricCriterionRepository : IDisposable
    {
        Task<List<CFRubricCriterion>> GetAllAsync(CancellationToken ct = default);

        Task<CFRubricCriterion> GetByIdAsync(string sourcedId, CancellationToken ct = default);

        Task<bool> ExistsAsync(string sourcedId, CancellationToken ct = default);
    }
}
