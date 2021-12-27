using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    internal partial class SelectPreferencesForm : Form
    {
        private readonly MyMatchFacade r_MyMatchFacade = new MyMatchFacade();
        private const string k_ErrorMessageAgeRange = "The range you entered is not possible";


        public SelectPreferencesForm()
        {
            InitializeComponent();
        }


        private void continueButton_Click(object i_Sender, EventArgs i_E)
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

            r_MyMatchFacade.FilterMyMatch(
                int.Parse(FromNumericUpDown.Value.ToString()),
                int.Parse(ToNumericUpDown.Value.ToString()),
                genderSelection);
            FindMyMatchForm findMyMatchForm = new FindMyMatchForm(r_MyMatchFacade.GetMyMatches());
            this.Close();
            findMyMatchForm.Show();
        }
    }
}