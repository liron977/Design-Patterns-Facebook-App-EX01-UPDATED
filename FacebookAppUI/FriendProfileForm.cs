using System;
using System.Windows.Forms;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    internal partial class FriendProfileForm : Form
    {
        //private FacebookAppManager m_AppManager = FacebookAppManager.Instance;
        public readonly ProfileFriendPasade r_ProfilePasade = new ProfileFriendPasade();
        
       

        protected override void OnShown(EventArgs e)
        {
            FriendPicture.Load(r_ProfilePasade.GetPicture());
            userBirthDay.Text = r_ProfilePasade.GetBirthday();
            FriendName.Text = r_ProfilePasade.GetUserName();
            Gender.Text = r_ProfilePasade.GetGender();
        }

        public FriendProfileForm()
        {
            InitializeComponent();
        }
    }
}