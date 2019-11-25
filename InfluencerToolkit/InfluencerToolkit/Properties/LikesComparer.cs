using System;
using System.Collections.Generic;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace test
{
    class LikesComparer : IComparer<Tuple<User, int>>
    {
        public int Compare(Tuple<User, int> i_SetmemberA, Tuple<User, int> i_SetMemberB)
        {
            return i_SetmemberA.Item2 - i_SetMemberB.Item2; // returns the number of likes of A minus the number of likes of B
        }
    }
}
