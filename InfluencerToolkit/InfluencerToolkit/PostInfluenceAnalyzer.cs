using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class PostInfluenceAnalyzer
    {
        public Post CurrentPostToAnalyze { get; set; }

        public PostInfluenceAnalyzer()
        {
            CurrentPostToAnalyze = null;  
        }

        public Post FetchSetCurrentPostToAnalyze(string i_PostMessage, User i_User)
        {
            Post postToReturn = i_User.Posts.Find(x => x.Message == i_PostMessage);
            CurrentPostToAnalyze = postToReturn;
            return postToReturn;
        }
    }
}
