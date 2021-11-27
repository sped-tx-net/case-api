namespace Ims.Case.Models
{
    /// <summary>
    /// This is the container for the CFItem data outside of the context of a CFPackage.This is the
    /// content that either describes a specific competency (learning objective) or describes a
    /// grouping of competencies within the taxonomy of a Competency Framework Document.
    /// </summary>
    public class CFItem : CFPckgItem
    {
        public LinkURI CFDocumentURI { get; set; }
    }
}
