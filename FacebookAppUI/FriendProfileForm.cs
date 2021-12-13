using System;
using System.Windows.Forms;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    internal partial class FriendProfileForm : Form
    {
        private FacebookAppManager m_AppManager = new FacebookAppManager();

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

        protected override void OnShown(EventArgs e)
        {
            FriendPicture.Load(m_AppManager.FetchPicture());
            userBirthDay.Text = m_AppManager.FetchUserBirthday();
            FriendName.Text = m_AppManager.FetchUserName();
            Gender.Text = m_AppManager.FetchUserGender();
        }

        public FriendProfileForm()
        {
            InitializeComponent();
        }
    }
}