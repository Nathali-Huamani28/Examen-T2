using System;
using System.Collections.Generic;

namespace Colegio
{
    public class List
    {
        public int Count { get; internal set; }

        internal void Add(estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public static implicit operator List(List<estudiante> v)
        {
            throw new NotImplementedException();
        }
    }
}