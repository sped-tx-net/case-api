using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ims.Case.Converters
{
    public interface IConvertModel<TSource, TTarget>
    {
        TTarget Convert();
    }
}
