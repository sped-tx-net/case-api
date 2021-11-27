using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ims.Case.Models;
using Ims.Case.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;

namespace Ims.Case.Supervisor
{
    public class CaseApiSupervisor : ICaseApiSupervisor
    {
        private readonly ICFAssociationRepository _cfAssociationRepository;
        private readonly ICFAssociationGroupingRepository _cfAssociationGroupingRepository;
        private readonly ICFConceptRepository _cfConceptRepository;
        private readonly ICFDocumentRepository _cfDocumentRepository;
        private readonly ICFItemRepository _cfItemRepository;
        private readonly ICFItemTypeRepository _cfItemTypeRepository;
        private readonly ICFLicenseRepository _cfLicenseRepository;
        private readonly ICFRubricRepository _cfRubricRepository;
        private readonly ICFRubricCriterionRepository _cfRubricCriterionRepository;
        private readonly ICFRubricCriterionLevelRepository _cfRubricCriterionLevelRepository;
        private readonly ICFSubjectRepository _cfSubjectRepository;
        private readonly IMemoryCache _cache;
        private readonly IApiModelFactory _factory;

        public CaseApiSupervisor(
            ICFAssociationRepository cfAssociationRepository,
            ICFAssociationGroupingRepository cfAssociationGroupingRepository,
            ICFConceptRepository cfConceptRepository,
            ICFDocumentRepository cfDocumentRepository,
            ICFItemRepository cfItemRepository,
            ICFItemTypeRepository cfItemTypeRepository,
            ICFLicenseRepository cfLicenseRepository,
            ICFRubricRepository cfRubricRepository,
            ICFRubricCriterionRepository cfRubricCriterionRepository,
            ICFRubricCriterionLevelRepository cfRubricCriterionLevelRepository,
            ICFSubjectRepository cfSubjectRepository,
            IMemoryCache cache,
            IApiModelFactory factory,
            IHttpContextAccessor accessor)
        {
            _cfAssociationRepository = cfAssociationRepository;
            _cfAssociationGroupingRepository = cfAssociationGroupingRepository;
            _cfConceptRepository = cfConceptRepository;
            _cfDocumentRepository = cfDocumentRepository;
            _cfItemRepository = cfItemRepository;
            _cfItemTypeRepository = cfItemTypeRepository;
            _cfLicenseRepository = cfLicenseRepository;
            _cfRubricRepository = cfRubricRepository;
            _cfRubricCriterionRepository = cfRubricCriterionRepository;
            _cfRubricCriterionLevelRepository = cfRubricCriterionLevelRepository;
            _cfSubjectRepository = cfSubjectRepository;
            _cache = cache;
            _factory = factory;
            HttpContext = accessor;
        }

        public IHttpContextAccessor HttpContext { get; }

        public async Task<List<CFAssociation>> GetAllCFAssociationAsync(CancellationToken ct = default)
        {
            var list = new List<CFAssociation>();
            var entities = await _cfAssociationRepository.GetAllAsync(ct).ConfigureAwait(false);
            foreach (var entity in entities)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(entity.Id, entity, cacheEntryOptions);
                list.Add(_factory.CreateCFAssociation(entity));
            }
            return list;
        }

        public async Task<CFAssociation> GetCFAssociationByIdAsync(string sourcedId, CancellationToken ct = default)
        {
            var entity = _cache.Get<Ims.Case.Entities.CFAssociation>(sourcedId);

            if (entity != null)
            {
                return _factory.CreateCFAssociation(entity);
            }
            else
            {
                var model = _factory.CreateCFAssociation(await _cfAssociationRepository.GetByIdAsync(sourcedId, ct));
                var cacheEntryOptions =
                    new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(model.Identifier, model, cacheEntryOptions);
                return model;
            }
        }

        public async Task<List<CFAssociationGrouping>> GetAllCFAssociationGroupingAsync(CancellationToken ct = default)
        {
            var list = new List<CFAssociationGrouping>();
            var entities = await _cfAssociationGroupingRepository.GetAllAsync(ct).ConfigureAwait(false);
            foreach (var entity in entities)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(entity.Id, entity, cacheEntryOptions);
                list.Add(_factory.CreateCFAssociationGrouping(entity));
            }
            return list;
        }

        public async Task<CFAssociationGrouping> GetCFAssociationGroupingByIdAsync(string sourcedId, CancellationToken ct = default)
        {
            var entity = _cache.Get<Ims.Case.Entities.CFAssociationGrouping>(sourcedId);

            if (entity != null)
            {
                return _factory.CreateCFAssociationGrouping(entity);
            }
            else
            {
                var model = _factory.CreateCFAssociationGrouping(await _cfAssociationGroupingRepository.GetByIdAsync(sourcedId, ct));
                var cacheEntryOptions =
                    new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(model.Identifier, model, cacheEntryOptions);
                return model;
            }
        }

        public async Task<List<CFConcept>> GetAllCFConceptAsync(CancellationToken ct = default)
        {
            var list = new List<CFConcept>();
            var entities = await _cfConceptRepository.GetAllAsync(ct).ConfigureAwait(false);
            foreach (var entity in entities)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(entity.Id, entity, cacheEntryOptions);
                list.Add(_factory.CreateCFConcept(entity));
            }
            return list;
        }

        public async Task<CFConcept> GetCFConceptByIdAsync(string sourcedId, CancellationToken ct = default)
        {
            var entity = _cache.Get<Ims.Case.Entities.CFConcept>(sourcedId);

            if (entity != null)
            {
                return _factory.CreateCFConcept(entity);
            }
            else
            {
                var model = _factory.CreateCFConcept(await _cfConceptRepository.GetByIdAsync(sourcedId, ct));
                var cacheEntryOptions =
                    new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(model.Identifier, model, cacheEntryOptions);
                return model;
            }
        }

        public async Task<List<CFDocument>> GetAllCFDocumentAsync(CancellationToken ct = default)
        {
            var list = new List<CFDocument>();
            var entities = await _cfDocumentRepository.GetAllAsync(ct).ConfigureAwait(false);
            foreach (var entity in entities)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(entity.Id, entity, cacheEntryOptions);
                list.Add(_factory.CreateCFDocument(entity));
            }
            return list;
        }

        public async Task<CFDocument> GetCFDocumentByIdAsync(string sourcedId, CancellationToken ct = default)
        {
            var entity = _cache.Get<Ims.Case.Entities.CFDocument>(sourcedId);

            if (entity != null)
            {
                return _factory.CreateCFDocument(entity);
            }
            else
            {
                var model = _factory.CreateCFDocument(await _cfDocumentRepository.GetByIdAsync(sourcedId, ct));
                var cacheEntryOptions =
                    new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(model.Identifier, model, cacheEntryOptions);
                return model;
            }
        }

        public async Task<List<CFItem>> GetAllCFItemAsync(CancellationToken ct = default)
        {
            var list = new List<CFItem>();
            var entities = await _cfItemRepository.GetAllAsync(ct).ConfigureAwait(false);
            foreach (var entity in entities)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(entity.Id, entity, cacheEntryOptions);
                list.Add(_factory.CreateCFItem(entity));
            }
            return list;
        }

        public async Task<CFItem> GetCFItemByIdAsync(string sourcedId, CancellationToken ct = default)
        {
            var entity = _cache.Get<Ims.Case.Entities.CFItem>(sourcedId);

            if (entity != null)
            {
                return _factory.CreateCFItem(entity);
            }
            else
            {
                var model = _factory.CreateCFItem(await _cfItemRepository.GetByIdAsync(sourcedId, ct));
                var cacheEntryOptions =
                    new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(model.Identifier, model, cacheEntryOptions);
                return model;
            }
        }

        public async Task<List<CFItemType>> GetAllCFItemTypeAsync(CancellationToken ct = default)
        {
            var list = new List<CFItemType>();
            var entities = await _cfItemTypeRepository.GetAllAsync(ct).ConfigureAwait(false);
            foreach (var entity in entities)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(entity.Id, entity, cacheEntryOptions);
                list.Add(_factory.CreateCFItemType(entity));
            }
            return list;
        }

        public async Task<CFItemType> GetCFItemTypeByIdAsync(string sourcedId, CancellationToken ct = default)
        {
            var entity = _cache.Get<Ims.Case.Entities.CFItemType>(sourcedId);

            if (entity != null)
            {
                return _factory.CreateCFItemType(entity);
            }
            else
            {
                var model = _factory.CreateCFItemType(await _cfItemTypeRepository.GetByIdAsync(sourcedId, ct));
                var cacheEntryOptions =
                    new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(model.Identifier, model, cacheEntryOptions);
                return model;
            }
        }

        public async Task<List<CFLicense>> GetAllCFLicenseAsync(CancellationToken ct = default)
        {
            var list = new List<CFLicense>();
            var entities = await _cfLicenseRepository.GetAllAsync(ct).ConfigureAwait(false);
            foreach (var entity in entities)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(entity.Id, entity, cacheEntryOptions);
                list.Add(_factory.CreateCFLicense(entity));
            }
            return list;
        }

        public async Task<CFLicense> GetCFLicenseByIdAsync(string sourcedId, CancellationToken ct = default)
        {
            var entity = _cache.Get<Ims.Case.Entities.CFLicense>(sourcedId);

            if (entity != null)
            {
                return _factory.CreateCFLicense(entity);
            }
            else
            {
                var model = _factory.CreateCFLicense(await _cfLicenseRepository.GetByIdAsync(sourcedId, ct));
                var cacheEntryOptions =
                    new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(model.Identifier, model, cacheEntryOptions);
                return model;
            }
        }

        public async Task<List<CFRubric>> GetAllCFRubricAsync(CancellationToken ct = default)
        {
            var list = new List<CFRubric>();
            var entities = await _cfRubricRepository.GetAllAsync(ct).ConfigureAwait(false);
            foreach (var entity in entities)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(entity.Id, entity, cacheEntryOptions);
                list.Add(_factory.CreateCFRubric(entity));
            }
            return list;
        }

        public async Task<CFRubric> GetCFRubricByIdAsync(string sourcedId, CancellationToken ct = default)
        {
            var entity = _cache.Get<Ims.Case.Entities.CFRubric>(sourcedId);

            if (entity != null)
            {
                return _factory.CreateCFRubric(entity);
            }
            else
            {
                var model = _factory.CreateCFRubric(await _cfRubricRepository.GetByIdAsync(sourcedId, ct));
                var cacheEntryOptions =
                    new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(model.Identifier, model, cacheEntryOptions);
                return model;
            }
        }

        public async Task<List<CFRubricCriterion>> GetAllCFRubricCriterionAsync(CancellationToken ct = default)
        {
            var list = new List<CFRubricCriterion>();
            var entities = await _cfRubricCriterionRepository.GetAllAsync(ct).ConfigureAwait(false);
            foreach (var entity in entities)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(entity.Id, entity, cacheEntryOptions);
                list.Add(_factory.CreateCFRubricCriterion(entity));
            }
            return list;
        }

        public async Task<CFRubricCriterion> GetCFRubricCriterionByIdAsync(string sourcedId, CancellationToken ct = default)
        {
            var entity = _cache.Get<Ims.Case.Entities.CFRubricCriterion>(sourcedId);

            if (entity != null)
            {
                return _factory.CreateCFRubricCriterion(entity);
            }
            else
            {
                var model = _factory.CreateCFRubricCriterion(await _cfRubricCriterionRepository.GetByIdAsync(sourcedId, ct));
                var cacheEntryOptions =
                    new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(model.Identifier, model, cacheEntryOptions);
                return model;
            }
        }

        public async Task<List<CFRubricCriterionLevel>> GetAllCFRubricCriterionLevelAsync(CancellationToken ct = default)
        {
            var list = new List<CFRubricCriterionLevel>();
            var entities = await _cfRubricCriterionLevelRepository.GetAllAsync(ct).ConfigureAwait(false);
            foreach (var entity in entities)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(entity.Id, entity, cacheEntryOptions);
                list.Add(_factory.CreateCFRubricCriterionLevel(entity));
            }
            return list;
        }

        public async Task<CFRubricCriterionLevel> GetCFRubricCriterionLevelByIdAsync(string sourcedId, CancellationToken ct = default)
        {
            var entity = _cache.Get<Ims.Case.Entities.CFRubricCriterionLevel>(sourcedId);

            if (entity != null)
            {
                return _factory.CreateCFRubricCriterionLevel(entity);
            }
            else
            {
                var model = _factory.CreateCFRubricCriterionLevel(await _cfRubricCriterionLevelRepository.GetByIdAsync(sourcedId, ct));
                var cacheEntryOptions =
                    new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(model.Identifier, model, cacheEntryOptions);
                return model;
            }
        }

        public async Task<List<CFSubject>> GetAllCFSubjectAsync(CancellationToken ct = default)
        {
            var list = new List<CFSubject>();
            var entities = await _cfSubjectRepository.GetAllAsync(ct).ConfigureAwait(false);
            foreach (var entity in entities)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(entity.Id, entity, cacheEntryOptions);
                list.Add(_factory.CreateCFSubject(entity));
            }
            return list;
        }

        public async Task<CFSubject> GetCFSubjectByIdAsync(string sourcedId, CancellationToken ct = default)
        {
            var entity = _cache.Get<Ims.Case.Entities.CFSubject>(sourcedId);

            if (entity != null)
            {
                return _factory.CreateCFSubject(entity);
            }
            else
            {
                var model = _factory.CreateCFSubject(await _cfSubjectRepository.GetByIdAsync(sourcedId, ct));
                var cacheEntryOptions =
                    new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(model.Identifier, model, cacheEntryOptions);
                return model;
            }
        }

        public async Task<CFPackage> GetCFPackageByIdAsync(string sourcedId, CancellationToken ct = default)
        {
            var document = await _cfDocumentRepository.GetByIdAsync(sourcedId, ct);
            var package = new CFPackage();
            package.CFDocument = _factory.CreateCFDocument(document);
            foreach (var cfItem in document.CFItem)
                package.CFItems.Add(_factory.CreateCFItem(cfItem));
            foreach (var cfAssociation in document.CFAssociation)
                package.CFAssociations.Add(_factory.CreateCFAssociation(cfAssociation));
            foreach (var cfItemType in await _cfItemTypeRepository.GetAllAsync(ct))
                package.CFDefinitions.CFItemTypes.Add(_factory.CreateCFItemType(cfItemType));
            var subject = await _cfSubjectRepository.GetByIdAsync(document.SubjectId.ToString(), ct);
            package.CFDefinitions.CFSubjects.Add(_factory.CreateCFSubject(subject));
            return package;
        }
    }
}
