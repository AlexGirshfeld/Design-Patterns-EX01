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
        public Post FetchSetCurrentPostToAnalyzeByPostName(string i_PostName, User i_User)
        {
            Post postToReturn = i_User.Posts.Find(x => x.Name == i_PostName);
            CurrentPostToAnalyze = postToReturn;
            return postToReturn;
        }



    }
}
