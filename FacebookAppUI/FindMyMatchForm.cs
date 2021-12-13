using System;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal partial class FindMyMatchForm : Form
    {
        private FindMyMatchLogic m_FindMatch = new FindMyMatchLogic();
        private const string k_MessageNoMatches = "No matches to retrieve";

        public FindMyMatchLogic MyMatch
        {
            get
            {
                return m_FindMatch;
            }
            set
            {
                m_FindMatch = value;
            }
        }

        public FindMyMatchForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            fetchMatches();
            fetchFan();
        }

        private void fetchFan()
        {
            if(m_FindMatch.r_FriendsList.Count > 0)
            {
                try
                {
                    User myFan = m_FindMatch.FindMyFan();
                    FriendWhoLoveMePictureBox.Load(myFan.PictureNormalURL);
                    FriendWhoLoveMeLabel.Text = myFan.Name;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void fetchMatches()
        {
            try
            {
                foreach(Friend friend in m_FindMatch.r_FriendsList)
                {
                    recommendedMatchesListBox.Items.Add(friend.FriendUser);
                }

                if(recommendedMatchesListBox.Items.Count == 0)
                {
                    MessageBox.Show(k_MessageNoMatches);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void recommendedMatchesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSelectedFriendDetails();
        }

        private void showSelectedFriendDetails()
        {
            if(recommendedMatchesListBox.SelectedItems.Count == 1)
            {
                MyMatchForm myMatch = new MyMatchForm();

                myMatch.MatchAppManager.m_LoggedInUser = m_FindMatch.m_LoggedInUser;
                User userFriend =
                    myMatch.MatchAppManager.FindSelectedFriend(recommendedMatchesListBox.SelectedItem.ToString());
                myMatch.MatchAppManager.LoggedInUser = userFriend;
                myMatch.UserAppManager.LoggedInUser = m_FindMatch.m_LoggedInUser;
                myMatch.Show();
            }
        }
    }
}