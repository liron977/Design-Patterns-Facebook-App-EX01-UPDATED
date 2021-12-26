using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PostRankFormLogic
    {
        private readonly Dictionary<Post, int> r_UserPosts;
        private readonly FacebookAppManager r_AppManager = FacebookAppManager.Instance;
        public const int k_CurrentYear = 22;
        public const int k_NumberOfMonths = 13;
        public const int k_Millennium = 2000;
        public readonly List<Post>[] r_UserPostsOrderedByMonth = new List<Post>[13];
        public readonly List<Post>[] r_UserPostsOrderedByYear = new List<Post>[k_CurrentYear];

        public PostRankFormLogic()
        {
            r_UserPosts = new Dictionary<Post, int>();
        }

        public void InitUserPostsOrderedByMonthList()
        {
            for(int i = 0; i < k_NumberOfMonths; i++)
            {
                r_UserPostsOrderedByMonth[i] = new List<Post>();
            }
        }

        public void InitUserPostsOrderedByYearList()
        {
            for(int i = 0; i < k_CurrentYear; i++)
            {
                r_UserPostsOrderedByYear[i] = new List<Post>();
            }
        }

        public int CurrentYear
        {
            get
            {
                return k_CurrentYear;
            }
        }
        public int NumberOfMonths
        {
            get
            {
                return k_NumberOfMonths;
            }
        }
        public Dictionary<Post, int> UserPosts
        {
            get
            {
                return r_UserPosts;
            }
        }
        public List<Post>[] UserPostsOrderedByMonth
        {
            get
            {
                return r_UserPostsOrderedByMonth;
            }
        }
        public List<Post>[] UserPostsOrderedByYear
        {
            get
            {
                return r_UserPostsOrderedByYear;
            }
        }

        public void InitPostsList()
        {
            int postCreatedMonth = 0;
            int postCreatedYear = 0;

            foreach(Post userPosts in r_AppManager.LoggedInUser.Posts)
            {
                try
                {
                    r_UserPosts.Add(userPosts, postCommentCounter(userPosts));
                    postCreatedMonth = userPosts.CreatedTime.Value.Month;
                    postCreatedYear = userPosts.CreatedTime.Value.Year;
                    r_UserPostsOrderedByMonth[postCreatedMonth].Add(userPosts);
                    r_UserPostsOrderedByYear[postCreatedYear - k_Millennium].Add(userPosts);
                }
                catch
                {
                }
            }
        }

        public Post TheMostPopularPostByComments()
        {
            Post theMostCommentedPost = new Post();
            int maximumCountOfComments = 0;

            foreach(KeyValuePair<Post, int> item in r_UserPosts)
            {
                if(item.Key.Message != null)
                {
                    if(item.Value > maximumCountOfComments)
                    {
                        maximumCountOfComments = item.Value;
                        theMostCommentedPost = item.Key;
                    }
                }
            }

            return theMostCommentedPost;
        }

        private int postCommentCounter(Post i_UserPost)
        {
            int postCommentCounter = i_UserPost.Comments.Count;

            return postCommentCounter;
        }
    }
}