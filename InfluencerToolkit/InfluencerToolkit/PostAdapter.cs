using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class PostAdapter
    {
        public Post m_Post;
        public string Name { get; set; }
        
        public string Message { get; set; }

        public List<UserAdapter> LikedBy { get; set; }

        private PostAdapter()
        {
            
        }

        public void AdaptPostForCaching(Post i_Post)
        {
            this.Name = i_Post.Name;
            this.Message = i_Post.Message;
            //this.LikedBy = i_Post.LikedBy;
        }




    }
}
