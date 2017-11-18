using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pencil
{
    interface IPencilRepository
    {
        int Count { get; }

        Pencil this[int index] { get; }

        void Delete(int index);
    }
}
