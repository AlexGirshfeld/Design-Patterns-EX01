using System;
using System.Collections.Generic;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    [Serializable]
    public class AlbumAdapter : IFacebookObjAdapter
    {
        public Post m_Post;

        public string Name { get; set; }

        public string Message { get; set; }
        
        public Image ImageSmall { get; set; }

        public List<UserAdapter> LikedBy { get; set; }

        public AlbumAdapter()
        {
        }

        public AlbumAdapter(Album i_Album)
        {
            AdaptFacebookObj(i_Album);
        }

        public void AdaptFacebookObj(FacebookObject i_AlbumToAdapt)
        {
            if (i_AlbumToAdapt is Album)
            {
                this.Name = (i_AlbumToAdapt as Album).Name;
                this.Message = (i_AlbumToAdapt as Album).Message;
                this.LikedBy = CollectionAdapter.AdaptCollection<UserAdapter, User>((i_AlbumToAdapt as Album).LikedBy);
                this.ImageSmall = (i_AlbumToAdapt as Album).ImageSmall;
            }
            else
            {
                throw new Exception("trying to adapt into a  AlbumAdatper an object that is not a Facebook album");
            }
        }
    }
}
