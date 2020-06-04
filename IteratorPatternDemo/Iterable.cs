using System;
using System.Collections.Generic;
using System.Text;


namespace IteratorPatternDemo
{
    public interface Iterable<T> where T:class
    {
        Iterator<T> GetIterator();
    }
}
