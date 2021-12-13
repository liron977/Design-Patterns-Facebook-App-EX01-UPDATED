using System;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    internal partial class FacebookAppForm : Form
    {
        private FacebookAppManager m_AppManager = new FacebookAppManager();
        private PostRankFormLogic m_AppPostsRank;
        private const string k_MessageLogout = " are you sure you want to log out from this app?";

        public FacebookAppManager AppManager
        {
            get
            {
                return m_AppManager;
            }
            set
            {
                m_AppManager = value;
            }
        }

        public FacebookAppForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            ProfilePicture.Load(AppManager.FetchPicture());
        }

        private void profilePageButton_Click(object sender, EventArgs e)
        {
            UserProfileForm profileForm = new UserProfileForm();

            profileForm.AppManager = AppManager;
            profileForm.Show();
        }

        private void findMyMatchButton_Click(object sender, EventArgs e)
        {
            SelectPreferencesForm selectPreferencesForm = new SelectPreferencesForm();

            selectPreferencesForm.AppManager.m_LoggedInUser = AppManager.m_LoggedInUser;
            selectPreferencesForm.Show();
        }

        private void postStatistics_Click(object sender, EventArgs e)
        {
            m_AppPostsRank = new PostRankFormLogic(AppManager.LoggedInUser);
            PostRankForm postRankForm = new PostRankForm();
            postRankForm.AppManager = AppManager;
            postRankForm.AppPostsRank = m_AppPostsRank;
            postRankForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            activateLogout();
        }

        private void activateLogout()
        {
            string userName = AppManager.FetchUserName();
            DialogResult dialogResult = MessageBox.Show(userName + k_MessageLogout, "", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                FacebookService.LogoutWithUI();
                this.Close();
            }
        }
    }
}