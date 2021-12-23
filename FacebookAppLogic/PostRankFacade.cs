using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
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

        public void initPostsInfo()
        {
            r_PostRank.initUserPostsOrderedByMonthList();
            r_PostRank.initUserPostsOrderedByYearList();
            r_PostRank.initPostsList();
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
