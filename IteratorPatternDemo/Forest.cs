using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPatternDemo
{
    class Forest : Iterable<Tree>
    {
        private Iterator<Tree> _iterator;
        private IList<Tree>    _treeCollection;
        public Forest()
        {
            _treeCollection = new List<Tree>();
            _iterator       = new TreeIterator(this);
        }
        public Iterator<Tree> GetIterator()
        {
            return _iterator;
        }

        public Tree this[int index]
        {
            get => _treeCollection[index];
            set => _treeCollection.Insert(index, value);
        }

        public void Add(Tree tree)
        {
            _treeCollection.Add(tree);
        }

        public void Remove(Tree tree)
        {
            _treeCollection.Remove(tree);
        }

        public int Count
        {
            get => _treeCollection.Count;
        }
    }
}
