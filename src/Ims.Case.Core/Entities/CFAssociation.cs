using System;
using System.Collections.Generic;

#nullable disable

namespace Ims.Case.Entities
{
    public partial class CFAssociation
    {
        public Guid Id { get; set; }
        public string AssociationType { get; set; }
        public int? SequenceNumber { get; set; }
        public string OriginNodeId { get; set; }
        public string OriginNodeTitle { get; set; }
        public string DestinationNodeId { get; set; }
        public string DestinationNodeTitle { get; set; }
        public Guid? CFAssociationGroupingId { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid? CFDocumentId { get; set; }

        public virtual CFAssociationGrouping CFAssociationGrouping { get; set; }
        public virtual CFDocument CFDocument { get; set; }
    }
}
