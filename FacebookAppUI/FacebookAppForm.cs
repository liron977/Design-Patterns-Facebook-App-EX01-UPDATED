using System;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    internal partial class FacebookAppForm : Form
    {
       private UserProfileFacade m_ProfileFacade = new UserProfileFacade();
        private const string k_MessageLogout = " are you sure you want to log out from this app?";

       
        public FacebookAppForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            ProfilePicture.Load(m_ProfileFacade.GetPicture());
        }

        private void profilePageButton_Click(object sender, EventArgs e)
        {
            UserProfileForm profileForm = new UserProfileForm();
            profileForm.Show();
        }

        private void findMyMatchButton_Click(object sender, EventArgs e)
        {
            SelectPreferencesForm selectPreferencesForm = new SelectPreferencesForm();
            selectPreferencesForm.Show();
        }

        private void postStatistics_Click(object sender, EventArgs e)
        {
            PostRankForm postRankForm = new PostRankForm();
            postRankForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            activateLogout();
        }

        private void activateLogout()
        {
            string userName = m_ProfileFacade.GetUserName();
            DialogResult dialogResult = MessageBox.Show(userName + k_MessageLogout, "", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                FacebookService.LogoutWithUI();
                this.Close();
            }
        }
    }
}