using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ims.Case.Models;

namespace Ims.Case
{
    public interface ICaseApiController
    {
        Task<CFAssociation> GetCFAssociationAsync(string sourcedId, CancellationToken ct = default);

        Task<CFAssociationSet> GetCFItemAssociationsAsync(string sourcedId, CancellationToken ct = default);

        Task<CFAssociationGrouping> GetCFAssociationGroupingAsync(string sourcedId, CancellationToken ct = default);

        Task<CFConcept> GetCFConceptAsync(string sourcedId, CancellationToken ct = default);

        Task<CFItemType> GetCFItemTypeAsync(string sourcedId, CancellationToken ct = default);

        Task<CFLicense> GetCFLicenseAsync(string sourcedId, CancellationToken ct = default);

        Task<CFSubject> GetCFSubjectAsync(string sourcedId, CancellationToken ct = default);

        Task<CFDocumentSet> GetAllCFDocumentsAsync(CancellationToken ct = default);

        Task<CFDocument> GetCFDocumentAsync(string sourcedId, CancellationToken ct = default);

        Task<CFItem> GetCFItemAsync(string sourcedId, CancellationToken ct = default);

        Task<CFPackage> GetCFPackageAsync(string sourcedId, CancellationToken ct = default);

        Task<CFRubric> GetCFRubricAsync(string sourcedId, CancellationToken ct = default);

    }

    public class CaseApiController : ICaseApiController
    {
        private readonly Ims.Case.Entities.CaseApiContext _context;
        private readonly ApiModelFactory _factory;

        public CaseApiController(Ims.Case.Entities.CaseApiContext context, ApiModelFactory factory)
        {
            _context = context;
            _factory = factory;
        }

        public async Task<CFAssociation> GetCFAssociationAsync(string sourcedId, CancellationToken ct = default)
        {
            var retVal = await _context.CFAssociation.FindAsync(sourcedId);
            return _factory.CreateCFAssociation(retVal);
        }

        public async Task<CFAssociationSet> GetCFItemAssociationsAsync(string sourcedId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<CFAssociationGrouping> GetCFAssociationGroupingAsync(string sourcedId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<CFConcept> GetCFConceptAsync(string sourcedId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<CFItemType> GetCFItemTypeAsync(string sourcedId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<CFLicense> GetCFLicenseAsync(string sourcedId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<CFSubject> GetCFSubjectAsync(string sourcedId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<CFDocumentSet> GetAllCFDocumentsAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<CFDocument> GetCFDocumentAsync(string sourcedId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<CFItem> GetCFItemAsync(string sourcedId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<CFPackage> GetCFPackageAsync(string sourcedId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<CFRubric> GetCFRubricAsync(string sourcedId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
