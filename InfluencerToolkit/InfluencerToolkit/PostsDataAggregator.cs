using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class PostsDataAggregator
    {
        private List<PostAdapter> m_CurrentUserPostsCollection;
        private int m_AvargeCountOfLikesPerPost;
        public int m_AvarageNumberOfLikesGivenToMyPostsPerUser;
        private int m_TotalNumberOfLikesRecievedInAllPosts;

        public PostsDataAggregator(UserAdapter i_UserAdapter)
        {
            m_CurrentUserPostsCollection = i_UserAdapter.Posts;
        }

        private Dictionary<UserAdapter, int> aggregateUserLikes()
        {
            Dictionary<UserAdapter, int> m_usersLikesCount = new Dictionary<UserAdapter, int>();
            m_TotalNumberOfLikesRecievedInAllPosts = 0;

            SelectiveEnumarble<PostAdapter> filteredPosts = new  SelectiveEnumarble<PostAdapter>(m_CurrentUserPostsCollection, CheckIfPostsLikedByGreaterThanZero);
            
            IEnumerator<PostAdapter> Iterator = filteredPosts.GetEnumerator();
            int a = 15;
            while(Iterator.MoveNext())
            {
                PostAdapter cur = Iterator.Current;
            }
            
            foreach(PostAdapter post in filteredPosts)
            {
                foreach(UserAdapter user in post.LikedBy)
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

                m_AvargeCountOfLikesPerPost += post.LikedBy.Count;
            } 
            
            m_AvargeCountOfLikesPerPost /= m_CurrentUserPostsCollection.Count;
            return m_usersLikesCount;
        }

        public bool CheckIfPostsLikedByGreaterThanZero(PostAdapter i_Post)
        {
           
            return i_Post == null ? false : i_Post.LikedBy.Count > 0;
        }

        private int calculateAvarageNumberOfLikesGivenPerFriend(Dictionary<UserAdapter, int> i_UserLikesDict)
        {
            int avarageLikes = 0;
            foreach(KeyValuePair<UserAdapter, int> userLikesPair in i_UserLikesDict)
            {
                avarageLikes += userLikesPair.Value;
            }

            return avarageLikes / i_UserLikesDict.Count;
        }

        private SortedList<UserAdapter, int> SortUsersByLikesCount()
        {
            SortedList<UserAdapter, int> m_usersSortedByLikes = new SortedList<UserAdapter, int>();
            Dictionary<UserAdapter, int> m_dictionaryToSort = aggregateUserLikes();
            m_dictionaryToSort.OrderBy(x => x.Value);

            foreach(KeyValuePair<UserAdapter, int> userLikesCount in m_dictionaryToSort)
            {
                m_usersSortedByLikes.Add(userLikesCount.Key, userLikesCount.Value);
            }

            return m_usersSortedByLikes;
        }

        public int AvarageCountOfLikesPerPost
        {
            get
            {
                aggregateUserLikes();
                return m_AvargeCountOfLikesPerPost;
            }
        }
        
        public SortedList<UserAdapter, int> UsersSortedByLikes
        {
            get { return SortUsersByLikesCount(); }
        }

        public int TotalNumberOfLikesRecievedInAllPosts
        {
            get
            {
                aggregateUserLikes();
                return this.m_TotalNumberOfLikesRecievedInAllPosts;
            }

            internal set { this.m_TotalNumberOfLikesRecievedInAllPosts = value; }
        }

        public int AvarageNumberOfLikesGivenToMyPostsPerUser
        {
            /*get { return this.m_AvarageNumberOfLikesGivenToMyPostsPerUser; }*/
            get
            {
                AvarageNumberOfLikesGivenToMyPostsPerUser = calculateAvarageNumberOfLikesGivenPerFriend(aggregateUserLikes());
                return AvarageNumberOfLikesGivenToMyPostsPerUser;
            }

            internal set { this.m_AvarageNumberOfLikesGivenToMyPostsPerUser = value; }
        }
    }
}
