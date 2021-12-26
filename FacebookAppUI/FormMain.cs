using System;
using System.Windows.Forms;
using FacebookAppLogic;


namespace BasicFacebookFeatures
{
    internal partial class FormMain : Form
    {
        private readonly LoginFacade r_LoginFacade;
        private const string k_MessageCantLogin = "Cant login";

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_LoginFacade = new LoginFacade();
        }

        private void buttonLogin_Click(object i_Sender, EventArgs i_E)
        {
            try
            {
                r_LoginFacade.Login();
                this.Hide();
                FacebookAppForm facebookApp = new FacebookAppForm();
                facebookApp.Closed += (i_S, i_Args) => this.Close();
                facebookApp.Show();
            }
            catch
            {
                MessageBox.Show(k_MessageCantLogin);
            }
        }
    }
}