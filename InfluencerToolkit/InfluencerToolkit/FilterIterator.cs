using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfluencerToolkit
{
    class FilterIterator <T> : IEnumerator<T>
    {
        private Predicate<T> m_Predicate;
        private IEnumerator<T> m_Iterator;

        public FilterIterator(IEnumerable<T> i_Collection , Predicate<T> i_Predicate)
        {
            this.m_Predicate = i_Predicate;
            this.m_Iterator = i_Collection.GetEnumerator();
        }

        public T Current => m_Iterator.Current;

        object IEnumerator.Current => m_Iterator.Current;

        public void Dispose()
        {
            m_Iterator.Dispose();
        }

        public bool MoveNext()
        {
            bool hasNext = m_Iterator.MoveNext();
            while ( ( (Current != null) ? !m_Predicate(Current) : false) && hasNext)
                hasNext = m_Iterator.MoveNext();    
            return hasNext;
        }

        public void Reset()
        {
            m_Iterator.Reset();
        }
    }
}
