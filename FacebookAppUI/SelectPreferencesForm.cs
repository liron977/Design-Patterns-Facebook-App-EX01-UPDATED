using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    internal partial class SelectPreferencesForm : Form
    {
        private FindMyMatchLogic m_AppManager = new FindMyMatchLogic();
        private const string k_ErrorMessageAgeRange = "The range you entered is not possible";

        public FindMyMatchLogic AppManager
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

        public SelectPreferencesForm()
        {
            InitializeComponent();
        }


        private void continueButton_Click(object sender, EventArgs e)
        {
            if(FromNumericUpDown.Value > ToNumericUpDown.Value)
            {
                MessageBox.Show(k_ErrorMessageAgeRange);
            }
            else
            {
                getUserSelectionAndContinue();
            }
        }

        private void getUserSelectionAndContinue()
        {
            User.eGender genderSelection;
            if(femaleRadioButton.Checked)
            {
                genderSelection = User.eGender.female;
            }
            else
            {
                genderSelection = User.eGender.male;
            }

            m_AppManager.FilterMyMatch(
                int.Parse(FromNumericUpDown.Value.ToString()),
                int.Parse(ToNumericUpDown.Value.ToString()),
                genderSelection);
            FindMyMatchForm findMyMatchForm = new FindMyMatchForm();
            findMyMatchForm.MyMatch.m_LoggedInUser = m_AppManager.m_LoggedInUser;
            foreach(Friend friend in AppManager.r_FriendsList)
            {
                findMyMatchForm.MyMatch.r_FriendsList.Add(friend);
            }

            this.Close();
            findMyMatchForm.Show();
        }
    }
}