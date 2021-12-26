using System;
using System.Windows.Forms;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    internal partial class FriendProfileForm : Form
    {
        public readonly FriendFacade r_ProfileFacade = new FriendFacade();

        protected override void OnShown(EventArgs i_E)
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