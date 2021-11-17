namespace Ims.Case.Models
{
    public interface ICompetencyFrameworkElement
    {
        string Identifier { get; set; }
        string LastChangeDateTime { get; set; }
        string Uri { get; set; }
    }
}