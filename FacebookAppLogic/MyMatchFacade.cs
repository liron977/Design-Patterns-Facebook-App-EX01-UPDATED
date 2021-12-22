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

        public void FilterMyMatch(int i_FromAge, int i_ToAge, User.eGender i_Gender)
        {
            m_FindMyMatchLogic.FilterMyMatch(i_FromAge, i_ToAge, i_Gender);
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

        public int GetSelectedMatchIndex(string i_Selected_item, int i_SelectedIndex)
        {
            return m_FindMyMatchLogic.GetNameIndex(i_Selected_item, i_SelectedIndex);
        }

        public User GetSelectedMatch(string i_SelectedMatch)
        {
            return m_FindMyMatchLogic.FindSelectedFriend(i_SelectedMatch);
        }


    }
}
