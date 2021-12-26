using System;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    internal partial class FacebookAppForm : Form
    {
        private readonly UserProfileFacade r_ProfileFacade = new UserProfileFacade();
        private const string k_MessageLogout = " are you sure you want to log out from this app?";


        public FacebookAppForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs i_E)
        {
            ProfilePicture.Load(r_ProfileFacade.GetPicture());
        }

        private void profilePageButton_Click(object i_Sender, EventArgs i_E)
        {
            UserProfileForm profileForm = new UserProfileForm();
            profileForm.Show();
        }

        private void findMyMatchButton_Click(object i_Sender, EventArgs i_E)
        {
            SelectPreferencesForm selectPreferencesForm = new SelectPreferencesForm();
            selectPreferencesForm.Show();
        }

        private void postStatistics_Click(object i_Sender, EventArgs i_E)
        {
            postStatisticsLoad();
        }

        private void postStatisticsLoad()
        {
            PostRankForm postRankForm = new PostRankForm();
            postRankForm.Show();
        }

        private void logoutButton_Click(object i_Sender, EventArgs i_E)
        {
            activateLogout();
        }

        private void activateLogout()
        {
            string userName = r_ProfileFacade.GetUserName();
            DialogResult dialogResult = MessageBox.Show(userName + k_MessageLogout, "", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                FacebookService.LogoutWithUI();
                this.Close();
            }
        }
    }
}