using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System.Threading;

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
            new Thread(fetchFan).Start();
            new Thread(fetchMatches).Start();
            
        }
        private void fetchFan()
        {
            
            if(m_MyMatchFacade.GetMyMatchs().Count > 0)
            {
                try
                {
                 
                        User myFan = m_MyMatchFacade.GetMyFan();
                 
                    FriendWhoLoveMePictureBox.Invoke(new Action(() => FriendWhoLoveMePictureBox.Load(myFan.PictureNormalURL)));
                    FriendWhoLoveMeLabel.Invoke(new Action(() => FriendWhoLoveMeLabel.Text = myFan.Name));
            
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
                    recommendedMatchesListBox.Invoke(new Action(() => recommendedMatchesListBox.Items.Add(matchInfo)));
                  
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
             = m_MyMatchFacade.GetSelectedMatchIndex(
                  recommendedMatchesListBox.SelectedItem.ToString(),
                  recommendedMatchesListBox.SelectedIndex);

               myMatch.m_FriendFacade.FriendLogic.Friend = m_MyMatchFacade.GetSelectedMatch(recommendedMatchesListBox.Items[matchNameIndex].ToString());
               myMatch.Show();
            }
        }
    }
}