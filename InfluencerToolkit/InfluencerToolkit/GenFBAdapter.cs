using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class GenAdapter<T> : IFacebookObjAdapter
    {
        public T m_Adoptee;

        public string Name { get; set; }

        public string Message { get; set; }

        public List<GenAdapter<T>> LikedBy { get; set; }
        
        public void AdaptFacebookObj(FacebookObject i_ObjectToAdapt)
        {
            throw new NotImplementedException();
        }
    }
}