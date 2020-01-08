using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
namespace InfluencerToolkit
{
    public class UserAdapter
    {
        public List<PostAdapter> Posts { get; set; }
        //public List<AlbumsAdapter> Albums { get; set; }
        //public List<FriendsAdapter> Friends { get; set; }
    }
    public UserAdapter()
    {
        
    }

    public void AdaptUser(User i_UserToAdapt)
    {
        this Posts = adaptPosts(i_UserToAdapt.Posts);
        this.Albums = adaptCollection<AdaptedAlbum,Album>(i_UserToAdapt.Albums);
        this.Friends = adaptCollection<UserAdapter,User>(i_UserToAdapt.Friends
    }
    
    public List<T1> AdaptCollection<T1,T2> (FacebookObjectCollection<T2> i_CollectionToAdapt)
    {
        List<T1> retList = new List<T1>();

        return retList;
    }
}
