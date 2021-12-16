using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal partial class FindMyMatchForm : Form
    {
        private MyMatchFacade m_MyMatchFacade = new MyMatchFacade();

        private const string k_MessageNoMatches = "No matches to retrieve";
       

        public FindMyMatchForm(List<FriendLogic> i_FriendsList)
        {
            m_MyMatchFacade.updateMatchsList(i_FriendsList);
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            fetchMatches();
            fetchFan();
        }

        private void fetchFan()
        {
            if(m_MyMatchFacade.GetMyMatchs().Count > 0)
            {
                try
                {
                    User myFan = m_MyMatchFacade.GetMyFan();
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
                foreach(string matchInfo in m_MyMatchFacade.GetMyMatchesInfo())
                {
                    recommendedMatchesListBox.Items.Add(matchInfo);
                  
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
                int matchNameIndex
             //recommendedMatchesListBox.Items.Add(recommendedMatchesListBox.SelectedIndex);
             //  User userFriend =recommendedMatchesListBox.SelectedItem as User;
             = m_MyMatchFacade.GetSelectedMatchIndex(
                  recommendedMatchesListBox.SelectedItem.ToString(),
                  recommendedMatchesListBox.SelectedIndex);

               myMatch.m_FriendFacade.FriendLogic.Friend = m_MyMatchFacade.GetSelectedMatch(recommendedMatchesListBox.Items[matchNameIndex].ToString());
               myMatch.Show();
            }
        }
    }
}