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
        
        public int GetUserPostsOrderedByMonth(int index)
        {
            return r_PostRank.UserPostsOrderedByMonth[index].Count;
        }

        public int GetUserPostsOrderedByYear(int index)
        {
            return r_PostRank.UserPostsOrderedByYear[index].Count;
        }




    }
}
