using System;
using System.Windows.Forms;
using FacebookAppLogic;


namespace BasicFacebookFeatures
{
    internal partial class FormMain : Form
    {

        //private readonly LoginFacade r_LoginFacade; 
        private FacebookAppManager m_AppManager =FacebookAppManager.Instance;

        private const string k_MessageCantLogin = "Cant login";

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
           // r_LoginFacade = new LoginFacade();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // r_LoginFacade.Login();
                m_AppManager.UserLogin();
                this.Hide();
                FacebookAppForm facebookApp = new FacebookAppForm();
                facebookApp.AppManager = m_AppManager;
                facebookApp.Closed += (s, args) => this.Close();
                facebookApp.Show();
            }
            catch
            {
                MessageBox.Show(k_MessageCantLogin);
            }
        }
    }
}