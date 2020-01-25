using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfluencerToolkit
{
    class SelectiveEnumarble<T> : IEnumerable<T>
    {
        private IEnumerable<T> m_Collection;
        private Predicate<T> m_Predicate;
        
        public SelectiveEnumarble(IEnumerable<T> i_Collection, Predicate<T> i_Predicate)
        {
            this.m_Collection = i_Collection;
            this.m_Predicate = i_Predicate;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new FilterIterator<T>(m_Collection, m_Predicate);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            FilterIterator<T> selectiveIterator = new FilterIterator<T>(m_Collection, m_Predicate);
            while (selectiveIterator.MoveNext())
                yield return (object)selectiveIterator.Current;
        }
    }
}
