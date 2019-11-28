using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    
    class PostInfluenceAnalyzer
    {
        public Post CurrentPostToAnalyze { get; set; }

        public PostInfluenceAnalyzer()
        {
            CurrentPostToAnalyze = null;  
        }
        public void SetCurrentPostToAnalyzeByPostName(string i_PostName)
        {
            asdgad;
        }
        public Post fetchPostByName(string i_PostName, User i_User)
        {
            Post returnValuePost = null;
            foreach (Post post in i_User.Posts)
            {
                if(post.Name.Equals(i_PostName))
                {
                    returnValuePost = post;
                }
            }
            return returnValuePost;
        }
    }
}
