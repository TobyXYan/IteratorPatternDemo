using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPatternDemo
{
    public interface Iterator<T> where T: class
    {
        bool HasNext();
        void Next();
        T Current();
    }
}
