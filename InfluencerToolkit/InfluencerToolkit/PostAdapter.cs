using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    [Serializable]
    public class PostAdapter : IFacebookObjAdapter
    {
        public Post m_Post;

        public string Name { get; set; }

        public string Message { get; set; }

        public List<UserAdapter> LikedBy { get; set; }

        public DateTime? CreatedTime { get; set; }

        public PostAdapter()
        {
        }

        public PostAdapter(Post i_Post)
        {
            AdaptFacebookObj(i_Post);
        }

        public void AdaptFacebookObj(FacebookObject i_PostToAdapt)
        {
            if (i_PostToAdapt is Post)
            {
                this.Name = (i_PostToAdapt as Post).Name;
                this.Message = (i_PostToAdapt as Post).Message;
                this.LikedBy = CollectionAdapter.AdaptCollection<UserAdapter, User>((i_PostToAdapt as Post).LikedBy);
                this.CreatedTime = (i_PostToAdapt as Post).CreatedTime;
            }
            else
            {
                throw new Exception("trying to adapt into a  PostAdapter an object that is not a Facebook Post");
            }
        }
    }
}
