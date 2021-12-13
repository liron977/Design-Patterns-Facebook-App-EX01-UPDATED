using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    internal partial class MyMatchForm : Form
    {
        //private FacebookAppManager m_MatchAppManager = FacebookAppManager.Instance;
        private ProfileFriendPasade m_FriendPasade = new ProfileFriendPasade();
        private FacebookAppManager m_UserAppManager = FacebookAppManager.Instance;
        private List<Photo> m_Photos;
        private int m_PhotoListIndex;
        private const string k_MessageSomethingWrong = @"Something wrong. Try later";
        private const string k_MessageSentSuccessfully = "-sent successfully";

        public FacebookAppManager UserAppManager
        {
            get
            {
                return m_UserAppManager;
            }
            set
            {
                m_UserAppManager = value;
            }
        }
       /* public FacebookAppManager MatchAppManager
        {
            get
            {
                return m_MatchAppManager;
            }
            set
            {
                m_MatchAppManager = value;
            }
        }*/

        public MyMatchForm()
        {
            InitializeComponent();
            m_PhotoListIndex = 0;
        }

        protected override void OnShown(EventArgs e)
        {
            fetchMatchInfo();
        }

        private void fetchMatchInfo()
        {
            MyMatchPictureBox.Load(m_FriendPasade.GetPicture());
            UserGenderLabel.Text = m_FriendPasade.GetGender();
            UserAgeLabel.Text = m_FriendPasade.GetAge().ToString();
            UserLocationLabel.Text = m_FriendPasade.GetLocation();
            MyMatchNameLabel.Text = m_FriendPasade.GetUserName();
            m_Photos = m_FriendPasade.GetPictures();
            fetchPhoto();
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            LikedPagesListBox.Items.Clear();
            List<Page> likedPages = m_FriendPasade.GetLikedPages();
            try
            {
                foreach(Page page in likedPages)
                {
                    LikedPagesListBox.Items.Add(page);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchPhoto()
        {
            MyMatchPicrutesBox.Load(m_Photos[m_PhotoListIndex].PictureNormalURL);
        }


        private void postButton_Click(object sender, EventArgs e)
        {
            postAndTagFriend(m_FriendPasade.Friend.friend, FirstMoveTextBox.Text);
        }

        private void postAndTagFriend(User i_ToTagged, string i_Message)
        {
            try
            {
                m_UserAppManager.PostAndTag(i_ToTagged, i_Message);
                MessageBox.Show(i_Message + k_MessageSentSuccessfully);
            }
            catch(Exception ex)
            {
                MessageBox.Show(k_MessageSomethingWrong);
            }
        }


        private void nextPictureButton_Click(object sender, EventArgs e)
        {
            if(m_PhotoListIndex + 1 == m_Photos.Count)
            {
                m_PhotoListIndex = 0;
            }
            else
            {
                m_PhotoListIndex++;
            }

            MyMatchPicrutesBox.Load(m_Photos[m_PhotoListIndex].PictureNormalURL);
        }

        private void previousPictureButton_Click(object sender, EventArgs e)
        {
            if(m_PhotoListIndex == 0)
            {
                m_PhotoListIndex = m_Photos.Count - 1;
            }
            else
            {
                m_PhotoListIndex--;
            }

            MyMatchPicrutesBox.Load(m_Photos[m_PhotoListIndex].PictureNormalURL);
        }
    }
}