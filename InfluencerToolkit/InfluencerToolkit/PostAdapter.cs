using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class PostAdapter : IFacebookObjAdapter
    {
        public Post m_Post;
        public string Name { get; set; }
        
        public string Message { get; set; }

        public List<UserAdapter> LikedBy { get; set; }

        public PostAdapter()
        {    
        }

        public void AdaptFaceBookObj(FacebookObject i_PostToAdapt)
        {
            
        }

        public void AdaptPostForCaching(Post i_Post)
        {
 
        }

        public void AdaptFacebookObj(FacebookObject i_PostToAdapt)
        {
            if (i_PostToAdapt is Post)
            {
                this.Name = i_PostToAdapt.Name;
                this.Message = i_PostToAdapt.Message;
                this.LikedBy = CollectionAdapter.AdaptCollection<UserAdapter,User>(i_PostToAdapt.LikedBy);
            }
            else
            {
                throw new Exception("trying to adapt into a  PostAdapter an object that is not a Facebook Post");
            }

        }
    }
}
