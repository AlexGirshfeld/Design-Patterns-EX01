using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using System.Drawing;
using System.Net;

namespace InfluencerToolkit
{
    public class UserAdapter : IFacebookObjAdapter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Image ProfilePicture { get; set; }
        public List<PostAdapter> Posts { get; set; }
        public List<AlbumAdapter> Albums { get; set; }
        public List<UserAdapter> Friends { get; set; }
        
       


        public UserAdapter()
        {
        }

        public void AdaptFacebookObj(FacebookObject i_UserToAdapt)
        {
            if (i_UserToAdapt is User)
            {
                this.Posts = CollectionAdapter.AdaptCollection<PostAdapter,Post>((i_UserToAdapt as User).Posts);
                this.Albums = CollectionAdapter.AdaptCollection<AlbumAdapter, Album>((i_UserToAdapt as User).Albums);
                this.Friends = CollectionAdapter.AdaptCollection<UserAdapter, User>((i_UserToAdapt as User).Friends);
                this.FirstName = (i_UserToAdapt as User).FirstName;
                this.LastName = (i_UserToAdapt as User).LastName;
                this.ProfilePicture = (i_UserToAdapt as User).ImageNormal;
            }
            else
            {
                throw new Exception("trying to adapt into a User Adapter an object that is not a Facebook User");
            }
        }

        private Image LoadImageFromUrl(string URL)
        {
            Image retImage = null;
            var request = WebRequest.Create(URL);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                retImage = Bitmap.FromStream(stream);
            }
            retImage;
        }

        public static explicit operator User(UserAdapter v)
        {
            throw new NotImplementedException();
        }
    }
}
