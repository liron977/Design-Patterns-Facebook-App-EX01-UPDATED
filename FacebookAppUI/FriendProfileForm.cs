using System;
using System.Windows.Forms;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    internal partial class FriendProfileForm : Form
    {
        //private FacebookAppManager m_AppManager = FacebookAppManager.Instance;
        public readonly FriendFacade r_ProfileFacade = new FriendFacade();
        
       

        protected override void OnShown(EventArgs e)
        {
            FriendPicture.Load(r_ProfileFacade.GetPicture());
            userBirthDay.Text = r_ProfileFacade.GetBirthday();
            FriendName.Text = r_ProfileFacade.GetUserName();
            Gender.Text = r_ProfileFacade.GetGender();
        }

        public FriendProfileForm()
        {
            InitializeComponent();
        }
    }
}