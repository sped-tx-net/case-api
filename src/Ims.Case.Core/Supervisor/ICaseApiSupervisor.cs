// -----------------------------------------------------------------------
// <copyright file="ICaseApiSupervisor.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ims.Case.Models;
using Microsoft.AspNetCore.Http;

namespace Ims.Case.Supervisor
{
    /// <summary>
    /// Defines the <see cref="ICaseApiSupervisor" />.
    /// </summary>
    public interface ICaseApiSupervisor
    {
        /// <summary>
        /// Gets the HttpContext.
        /// </summary>
        IHttpContextAccessor HttpContext { get; }

        /// <summary>
        /// The GetAllCFAssociationAsync.
        /// </summary>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{List{CFAssociation}}"/>.</returns>
        Task<List<CFAssociation>> GetAllCFAssociationAsync(CancellationToken ct = default);

        /// <summary>
        /// The GetAllCFAssociationGroupingAsync.
        /// </summary>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{List{CFAssociationGrouping}}"/>.</returns>
        Task<List<CFAssociationGrouping>> GetAllCFAssociationGroupingAsync(CancellationToken ct = default);

        /// <summary>
        /// The GetAllCFConceptAsync.
        /// </summary>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{List{CFConcept}}"/>.</returns>
        Task<List<CFConcept>> GetAllCFConceptAsync(CancellationToken ct = default);

        /// <summary>
        /// The GetAllCFDocumentAsync.
        /// </summary>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{List{CFDocument}}"/>.</returns>
        Task<List<CFDocument>> GetAllCFDocumentAsync(CancellationToken ct = default);

        /// <summary>
        /// The GetAllCFItemAsync.
        /// </summary>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{List{CFItem}}"/>.</returns>
        Task<List<CFItem>> GetAllCFItemAsync(CancellationToken ct = default);

        /// <summary>
        /// The GetAllCFItemTypeAsync.
        /// </summary>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{List{CFItemType}}"/>.</returns>
        Task<List<CFItemType>> GetAllCFItemTypeAsync(CancellationToken ct = default);

        /// <summary>
        /// The GetAllCFLicenseAsync.
        /// </summary>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{List{CFLicense}}"/>.</returns>
        Task<List<CFLicense>> GetAllCFLicenseAsync(CancellationToken ct = default);

        /// <summary>
        /// The GetAllCFRubricAsync.
        /// </summary>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{List{CFRubric}}"/>.</returns>
        Task<List<CFRubric>> GetAllCFRubricAsync(CancellationToken ct = default);

        /// <summary>
        /// The GetAllCFRubricCriterionAsync.
        /// </summary>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{List{CFRubricCriterion}}"/>.</returns>
        Task<List<CFRubricCriterion>> GetAllCFRubricCriterionAsync(CancellationToken ct = default);

        /// <summary>
        /// The GetAllCFRubricCriterionLevelAsync.
        /// </summary>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{List{CFRubricCriterionLevel}}"/>.</returns>
        Task<List<CFRubricCriterionLevel>> GetAllCFRubricCriterionLevelAsync(CancellationToken ct = default);

        /// <summary>
        /// The GetAllCFSubjectAsync.
        /// </summary>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{List{CFSubject}}"/>.</returns>
        Task<List<CFSubject>> GetAllCFSubjectAsync(CancellationToken ct = default);

        /// <summary>
        /// The GetCFAssociationByIdAsync.
        /// </summary>
        /// <param name="sourcedId">The sourcedId<see cref="string"/>.</param>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{CFAssociation}"/>.</returns>
        Task<CFAssociation> GetCFAssociationByIdAsync(string sourcedId, CancellationToken ct = default);

        /// <summary>
        /// The GetCFAssociationGroupingByIdAsync.
        /// </summary>
        /// <param name="sourcedId">The sourcedId<see cref="string"/>.</param>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{CFAssociationGrouping}"/>.</returns>
        Task<CFAssociationGrouping> GetCFAssociationGroupingByIdAsync(string sourcedId, CancellationToken ct = default);

        /// <summary>
        /// The GetCFConceptByIdAsync.
        /// </summary>
        /// <param name="sourcedId">The sourcedId<see cref="string"/>.</param>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{CFConcept}"/>.</returns>
        Task<CFConcept> GetCFConceptByIdAsync(string sourcedId, CancellationToken ct = default);

        /// <summary>
        /// The GetCFDocumentByIdAsync.
        /// </summary>
        /// <param name="sourcedId">The sourcedId<see cref="string"/>.</param>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{CFDocument}"/>.</returns>
        Task<CFDocument> GetCFDocumentByIdAsync(string sourcedId, CancellationToken ct = default);

        /// <summary>
        /// The GetCFItemByIdAsync.
        /// </summary>
        /// <param name="sourcedId">The sourcedId<see cref="string"/>.</param>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{CFItem}"/>.</returns>
        Task<CFItem> GetCFItemByIdAsync(string sourcedId, CancellationToken ct = default);

        /// <summary>
        /// The GetCFItemTypeByIdAsync.
        /// </summary>
        /// <param name="sourcedId">The sourcedId<see cref="string"/>.</param>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{CFItemType}"/>.</returns>
        Task<CFItemType> GetCFItemTypeByIdAsync(string sourcedId, CancellationToken ct = default);

        /// <summary>
        /// The GetCFLicenseByIdAsync.
        /// </summary>
        /// <param name="sourcedId">The sourcedId<see cref="string"/>.</param>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{CFLicense}"/>.</returns>
        Task<CFLicense> GetCFLicenseByIdAsync(string sourcedId, CancellationToken ct = default);

        /// <summary>
        /// The GetCFPackageByIdAsync.
        /// </summary>
        /// <param name="sourcedId">.</param>
        /// <param name="ct">.</param>
        /// <returns>.</returns>
        Task<CFPackage> GetCFPackageByIdAsync(string sourcedId, CancellationToken ct = default);

        /// <summary>
        /// The GetCFRubricByIdAsync.
        /// </summary>
        /// <param name="sourcedId">The sourcedId<see cref="string"/>.</param>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{CFRubric}"/>.</returns>
        Task<CFRubric> GetCFRubricByIdAsync(string sourcedId, CancellationToken ct = default);

        /// <summary>
        /// The GetCFRubricCriterionByIdAsync.
        /// </summary>
        /// <param name="sourcedId">The sourcedId<see cref="string"/>.</param>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{CFRubricCriterion}"/>.</returns>
        Task<CFRubricCriterion> GetCFRubricCriterionByIdAsync(string sourcedId, CancellationToken ct = default);

        /// <summary>
        /// The GetCFRubricCriterionLevelByIdAsync.
        /// </summary>
        /// <param name="sourcedId">The sourcedId <see cref="string"/>.</param>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{CFRubricCriterionLevel}"/>.</returns>
        Task<CFRubricCriterionLevel> GetCFRubricCriterionLevelByIdAsync(string sourcedId, CancellationToken ct = default);

        /// <summary>
        /// The GetCFSubjectByIdAsync.
        /// </summary>
        /// <param name="sourcedId">The sourcedId<see cref="string"/>.</param>
        /// <param name="ct">The ct<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{CFSubject}"/>.</returns>
        Task<CFSubject> GetCFSubjectByIdAsync(string sourcedId, CancellationToken ct = default);
    }
}
