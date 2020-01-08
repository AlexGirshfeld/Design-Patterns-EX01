
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
namespace InfluencerToolkit
{
    class GenAdapter<T> : IFacebookObjAdapter
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

