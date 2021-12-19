using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class MyMatchFacade
    {
        private FindMyMatchLogic m_FindMyMatchLogic = new FindMyMatchLogic();

        public void FilterMyMatch(int fromAge, int toAge, User.eGender gender)
        {
            m_FindMyMatchLogic.FilterMyMatch(fromAge, toAge, gender);
        }

        public List<FriendLogic> GetMyMatchs()
        {
            return m_FindMyMatchLogic.r_FriendsList;
        }
        public List<string> GetMyMatchesInfo()
        {

            List<string> matchesByFormat = new List<string>();

            foreach (FriendLogic friend in m_FindMyMatchLogic.r_FriendsList)
            {
                IMyMatchFormat iMatchesFormat = new MyMatchFormatAdapter(friend.Friend);
                matchesByFormat.AddRange(iMatchesFormat.CreateFormattedMatchesList());

            }

            return matchesByFormat;
        }
        public User GetMyFan()
        {
            return m_FindMyMatchLogic.FindMyFan();
        }

        public void updateMatchsList(List<FriendLogic> i_FriendsList)
        {
            m_FindMyMatchLogic.UpdateFriendList(i_FriendsList);
        }

        public int GetSelectedMatchIndex(string selected_item, int selectedIndex)
        {
            return m_FindMyMatchLogic.GetNameIndex(selected_item, selectedIndex);
        }

        public User GetSelectedMatch(string selectedMatch)
        {
            return m_FindMyMatchLogic.FindSelectedFriend(selectedMatch);
        }


    }
}
