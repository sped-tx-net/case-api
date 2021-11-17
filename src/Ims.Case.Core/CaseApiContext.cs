using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Ims.Case.Entities
{
    public partial class CaseApiContext : DbContext
    {
        public CaseApiContext(DbContextOptions<CaseApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CFAssociation> CFAssociation { get; set; }
        public virtual DbSet<CFAssociationGrouping> CFAssociationGrouping { get; set; }
        public virtual DbSet<CFConcept> CFConcept { get; set; }
        public virtual DbSet<CFDocument> CFDocument { get; set; }
        public virtual DbSet<CFItem> CFItem { get; set; }
        public virtual DbSet<CFItemType> CFItemType { get; set; }
        public virtual DbSet<CFLicense> CFLicense { get; set; }
        public virtual DbSet<CFRubric> CFRubric { get; set; }
        public virtual DbSet<CFRubricCriterion> CFRubricCriterion { get; set; }
        public virtual DbSet<CFRubricCriterionLevel> CFRubricCriterionLevel { get; set; }
        public virtual DbSet<CFSubject> CFSubject { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CFAssociation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CFAssociation_Id")
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssociationType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationNodeId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationNodeTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangeDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.OriginNodeId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OriginNodeTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CFAssociationGrouping)
                    .WithMany(p => p.CFAssociation)
                    .HasForeignKey(d => d.CFAssociationGroupingId)
                    .HasConstraintName("FK_CFAssociation_CFAssociationGroupingId");

                entity.HasOne(d => d.CFDocument)
                    .WithMany(p => p.CFAssociation)
                    .HasForeignKey(d => d.CFDocumentId)
                    .HasConstraintName("FK_CFAssociation_CFDocumentId");
            });

            modelBuilder.Entity<CFAssociationGrouping>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CFAssociationGrouping_Id")
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangeDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CFConcept>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CFConcept_Id")
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HierarchyCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangeDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CFDocument>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CFDocument_Id")
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdoptionStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Language)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangeDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OfficialSourceURL)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Publisher)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StatusEndDate).HasColumnType("date");

                entity.Property(e => e.StatusStartDate).HasColumnType("date");

                entity.Property(e => e.Subject)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.License)
                    .WithMany(p => p.CFDocument)
                    .HasForeignKey(d => d.LicenseId)
                    .HasConstraintName("FK_CFDocument_LicenseId");

                entity.HasOne(d => d.SubjectNavigation)
                    .WithMany(p => p.CFDocument)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_CFDocument_SubjectId");
            });

            modelBuilder.Entity<CFItem>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CFItem_Id")
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AbbreviatedStatement)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.AlternativeLabel)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.CFItemType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptKeywords)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EducationLevel)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FullStatement)
                    .IsRequired()
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.HumanCodingScheme)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Language)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangeDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.StatusEndDate).HasColumnType("date");

                entity.Property(e => e.StatusStartDate).HasColumnType("date");

                entity.HasOne(d => d.CFDocument)
                    .WithMany(p => p.CFItem)
                    .HasForeignKey(d => d.CFDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CFItem_CFDocumentId");

                entity.HasOne(d => d.CFItemTypeNavigation)
                    .WithMany(p => p.CFItem)
                    .HasForeignKey(d => d.CFItemTypeId)
                    .HasConstraintName("FK_CFItem_CFItemTypeId");

                entity.HasOne(d => d.ConceptKeywordsNavigation)
                    .WithMany(p => p.CFItem)
                    .HasForeignKey(d => d.ConceptKeywordsId)
                    .HasConstraintName("FK_CFItem_ConceptKeywordsId");

                entity.HasOne(d => d.License)
                    .WithMany(p => p.CFItem)
                    .HasForeignKey(d => d.LicenseId)
                    .HasConstraintName("FK_CFItem_LicenseId");
            });

            modelBuilder.Entity<CFItemType>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CFItemType_Id")
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HierarchyCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangeDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CFLicense>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CFLicense_Id")
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangeDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.LicenseText)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CFRubric>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CFRubric_Id")
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangeDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CFRubricCriterion>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CFRubricCriterion_Id")
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangeDateTime).HasColumnType("smalldatetime");

                entity.HasOne(d => d.CFItem)
                    .WithMany(p => p.CFRubricCriterion)
                    .HasForeignKey(d => d.CFItemId)
                    .HasConstraintName("FK_CFRubricCriterion_CFItemId");

                entity.HasOne(d => d.Rubric)
                    .WithMany(p => p.CFRubricCriterion)
                    .HasForeignKey(d => d.RubricId)
                    .HasConstraintName("FK_CFRubricCriterion_RubricId");
            });

            modelBuilder.Entity<CFRubricCriterionLevel>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CFRubricCriterionLevel_Id")
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Feedback)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangeDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Quality)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.RubricCriterion)
                    .WithMany(p => p.CFRubricCriterionLevel)
                    .HasForeignKey(d => d.RubricCriterionId)
                    .HasConstraintName("FK_CFRubricCriterionLevel_RubricCriterionId");
            });

            modelBuilder.Entity<CFSubject>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CFSubject_Id")
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HierarchyCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangeDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
