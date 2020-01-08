using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public static class CollectionAdapter
    {
        public static List<T1> AdaptCollection<T1, T2>(FacebookObjectCollection<T2> i_CollectionToAdapt)
        where T1 : IFacebookObjAdapter, new()
        where T2 : FacebookObject
        {
            List<T1> retList = new List<T1>();

            foreach (T2 adoptee in i_CollectionToAdapt)
            {
                T1 adaptedObj = new T1();
                adaptedObj.AdaptFacebookObj(adoptee);
                retList.Add(adaptedObj);
            }

            return retList;
        }
    }
}
