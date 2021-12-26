using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PostRankFacade
    {
        private readonly PostRankFormLogic r_PostRank = new PostRankFormLogic();

        public Dictionary<Post, int> GetUserPosts()
        {
            return r_PostRank.UserPosts;
        }

        public void InitPostsInfo()
        {
            r_PostRank.InitUserPostsOrderedByMonthList();
            r_PostRank.InitUserPostsOrderedByYearList();
            r_PostRank.InitPostsList();
        }

        public Post GetTheMostPopularPostByComments()
        {
            return r_PostRank.TheMostPopularPostByComments();
        }

        public int GetNumberOfMonths()
        {
            return r_PostRank.NumberOfMonths;
        }

        public int GetCurrentYear()
        {
            return r_PostRank.CurrentYear;
        }

        public int GetUserPostsOrderedByMonth(int i_Index)
        {
            return r_PostRank.UserPostsOrderedByMonth[i_Index].Count;
        }

        public int GetUserPostsOrderedByYear(int i_Index)
        {
            return r_PostRank.UserPostsOrderedByYear[i_Index].Count;
        }
    }
}