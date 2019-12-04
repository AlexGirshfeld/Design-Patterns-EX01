using System;
using System.Collections;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using System.Linq;

namespace InfluencerToolkit
{
    public class PostsDataAggregator
    {
        private User m_user;
        private FacebookObjectCollection<Post> m_currentUserPostsCollection;
        private int m_avargeCountOfLikesPerPost;
        private int m_AvarageNumberOfLikesGivenToMyPostsPerUser;
        private int m_TotalNumberOfLikesRecievedInAllPosts;

        public PostsDataAggregator(User i_user)
        {
            this.m_user = i_user;
            this.m_currentUserPostsCollection = i_user.Posts;
        }

        private Dictionary<User, int> AggregateUserLikes()
        {
            Dictionary<User, int> m_usersLikesCount = new Dictionary<User, int>();
            m_TotalNumberOfLikesRecievedInAllPosts = 0;

            foreach(Post post in this.m_currentUserPostsCollection)
            {
                foreach(User user in post.LikedBy)
                {
                    m_TotalNumberOfLikesRecievedInAllPosts++;
                    if (m_usersLikesCount.ContainsKey(user))
                    {
                        m_usersLikesCount[user]++;
                    } 
                    else
                    {
                        m_usersLikesCount.Add(user, 1);
                    }
                }

                m_avargeCountOfLikesPerPost += post.LikedBy.Count;
            }
            
            m_avargeCountOfLikesPerPost /= m_currentUserPostsCollection.Count;
            return m_usersLikesCount;
        }

        private int calculateAvarageNumberOfLikesGivenPerFriend(Dictionary<User, int> i_UserLikesDict)
        {
            int avarageLikes = 0;
            foreach(KeyValuePair<User, int> userLikesPair in i_UserLikesDict)
            {
                avarageLikes += userLikesPair.Value;
            }

            return avarageLikes / i_UserLikesDict.Count;
        }

        private SortedList<User, int> SortUsersByLikesCount()
        {
            SortedList<User, int> m_usersSortedByLikes = new SortedList<User, int>();
            Dictionary<User, int> m_dictionaryToSort = AggregateUserLikes();
            m_dictionaryToSort.OrderBy(x => x.Value);

            foreach(KeyValuePair<User, int> userLikesCount in m_dictionaryToSort)
            {
                m_usersSortedByLikes.Add(userLikesCount.Key, userLikesCount.Value);
            }

            return m_usersSortedByLikes;
        }

        public int AvarageCountOfLikesPerPost
        {
            get 
            { 
                AggregateUserLikes();
                return m_avargeCountOfLikesPerPost;
            }
        }

        public int AvarageCountOfLikesPerFriend
        {
            get
            {
                m_AvarageNumberOfLikesGivenToMyPostsPerUser = calculateAvarageNumberOfLikesGivenPerFriend(AggregateUserLikes());
                return m_AvarageNumberOfLikesGivenToMyPostsPerUser;
            }
        }
        public int TotalLikes
        {
            get
            {
                AggregateUserLikes();
                return m_TotalNumberOfLikesRecievedInAllPosts;
            }
        }

        public SortedList<User, int> UsersSortedByLikes()
        {
            return SortUsersByLikesCount();
        }
    }
}
