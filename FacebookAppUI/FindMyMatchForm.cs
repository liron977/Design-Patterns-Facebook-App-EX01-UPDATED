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
        private readonly MyMatchFacade r_MyMatchFacade = new MyMatchFacade();

        private const string k_MessageNoMatches = "No matches to retrieve";

        public FindMyMatchForm(List<FriendLogic> i_FriendsList)
        {
            r_MyMatchFacade.UpdateMatchesList(i_FriendsList);
            InitializeComponent();
        }

        protected override void OnShown(EventArgs i_E)
        {
            recommendedMatchesListBox.Enabled = false;
            new Thread(fetchFan).Start();
            new Thread(fetchMatches).Start();
        }

        private void fetchFan()
        {
            if(r_MyMatchFacade.GetMyMatches().Count > 0)
            {
                try
                {
                    User myFan = r_MyMatchFacade.GetMyFan();

                    FriendWhoLoveMePictureBox.Invoke(
                        new Action(() => FriendWhoLoveMePictureBox.Load(myFan.PictureNormalURL)));
                    FriendWhoLoveMeLabel.Invoke(new Action(() => FriendWhoLoveMeLabel.Text = myFan.Name));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            recommendedMatchesListBox.Enabled = true;
        }

        private void fetchMatches()
        {
            try
            {
                foreach(string matchInfo in r_MyMatchFacade.GetMyMatchesInfo())
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

        private void recommendedMatchesListBox_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            showSelectedFriendDetails();
        }

        private void showSelectedFriendDetails()
        {
            if(recommendedMatchesListBox.SelectedItems.Count == 1)
            {
                MyMatchForm myMatch = new MyMatchForm();
                int matchNameIndex = r_MyMatchFacade.GetSelectedMatchIndex(
                    recommendedMatchesListBox.SelectedItem.ToString(),
                    recommendedMatchesListBox.SelectedIndex);

                myMatch.m_FriendFacade.FriendLogic.Friend =
                    r_MyMatchFacade.GetSelectedMatch(recommendedMatchesListBox.Items[matchNameIndex].ToString());
                myMatch.Show();
            }
        }
    }
}