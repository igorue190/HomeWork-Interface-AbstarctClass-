using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pencil
{
    abstract class BasePencilRepository
    {
        public abstract Pencil Get(int pencilId);

        public abstract void Add(Pencil pencil);

        public virtual void Print(Pencil pencil)
        {
            Console.WriteLine(pencil.ToString());
        }
    }
}
