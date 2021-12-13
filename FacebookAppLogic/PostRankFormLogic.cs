using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PostRankFormLogic
    {
        private readonly Dictionary<Post, int> r_UserPosts;
        public const int k_CurrentYear = 22;
        public const int k_NumberOfMonths = 13;
        public const int k_Millennium = 2000;
        public readonly List<Post>[] r_UserPostsOrderedByMonth = new List<Post>[13];
        public readonly List<Post>[] r_UserPostsOrderedByYear = new List<Post>[k_CurrentYear];
        private const string k_MessageFailedFetch = "Fetch failed. Please try again.";

        public PostRankFormLogic(User i_LoggedInUser)
        {
            r_UserPosts = new Dictionary<Post, int>();
            initUserPostsOrderedByMonthList();
            initUserPostsOrderedByYearList();
            initPostsList(i_LoggedInUser);
        }

        private void initUserPostsOrderedByMonthList()
        {
            for(int i = 0; i < k_NumberOfMonths; i++)
            {
                r_UserPostsOrderedByMonth[i] = new List<Post>();
            }
        }

        private void initUserPostsOrderedByYearList()
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

        private void initPostsList(User i_LoggedInUser)
        {
            int postCreatedMonth = 0;
            int postCreatedYear = 0;

            foreach(Post userPosts in i_LoggedInUser.Posts)
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
            int postCommentCounter = 0;

            postCommentCounter = i_UserPost.Comments.Count;

            return postCommentCounter;
        }
    }
}