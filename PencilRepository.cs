using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pencil
{
    class PencilRepository : BasePencilRepository, IPencilRepository
    {
        private Pencil[] _pencils;
        private int _size;
        private int _lastIndex;

        public PencilRepository(int size)
        {
            _size = size;
            _pencils = new Pencil[_size];
            _lastIndex = 0;
        }

        public int Count
        {
            get
            {
                return _pencils.Count(c => c != null);
            }
        }

        public Pencil this[int index]
        {
            get 
            {
                if(index >=0 && index<= _pencils.Length)
                     return _pencils[index];
                return null;
            } 
        }

        public override Pencil Get(int index)
        {
            if (index >= 0 && index <= _pencils.Length)
                return _pencils[index];
            else
                throw new ArgumentOutOfRangeException("index", "Index out of range");              
        }

        public override void Add(Pencil pencil)
        {
            if(_pencils.Last() == null)
                _pencils[_lastIndex++] = pencil;
            else
                Console.WriteLine("The array is full");
        }

        public void Delete(int index)
        {
            bool flag = false;
            if (index >= 0 && index <= _pencils.Length)
            {
                for (var i = 0; i < _pencils.Length; i++)
                {
                    if (i == index || flag == true)
                    {
                        if (i == _pencils.Length - 1)
                        {
                            _pencils[i] = null;
                            --_lastIndex;
                            break;
                        }
                        _pencils[i] = _pencils[i + 1];
                        flag = true;
                    }
                }
            }
            else
                throw new ArgumentOutOfRangeException("index", "Index out of range");
        }
    }
}
