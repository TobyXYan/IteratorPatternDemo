using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPatternDemo
{
    class TreeIterator : Iterator<Tree>
    {
        private Forest _forest;
        private int _current = 0;

        public TreeIterator(Forest forest)
        {
            _forest = forest;
        }
        public Tree Current()
        {
            return _current < _forest.Count?_forest[_current]:null;
        }

        public Tree First
        {
            get => _forest.Count==0?null: _forest[0];
        }

        public bool HasNext()
        {
            return (_current< _forest.Count);
        }

        public void Next()
        {
            _current++;
        }
    }
}
