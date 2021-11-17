using System;
using Ims.Case.Entities;
using Ims.Case.Models;

namespace Ims.Case.Utilities
{
    internal static class CompetencyFrameworkElementExtensions
    {
        public static string LastChangeDateTime(this ICFEntityType source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return source.LastChangeDateTime.ToString("yyyy-MM-dd mm:ss");
        }
        public static string UUID(this ICFEntityType source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return source.Id.ToString().ToLower();
        }
    }
}
