using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wonderboyz.Data.Interfaces
{
    interface IBaseRepositoryInterface<T>
    {
        T Save(T SaveMe);
        bool Delete(T DeleteMe);
    }
}
