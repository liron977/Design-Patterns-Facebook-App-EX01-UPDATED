using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System.Threading;


namespace BasicFacebookFeatures
{
    internal partial class MyMatchForm : Form
    {
        public FriendFacade m_FriendFacade = new FriendFacade();
        public UserProfileFacade m_UserProfileFacade = new UserProfileFacade();

        private List<Photo> m_Photos;
        private int m_PhotoListIndex;
        private const string k_MessageSomethingWrong = @"Something wrong. Try later";
        private const string k_MessageSentSuccessfully = "-sent successfully";

        public MyMatchForm()
        {
            InitializeComponent();
            m_PhotoListIndex = 0;
        }

        protected override void OnShown(EventArgs i_E)
        {
            new Thread(fetchMatchInfo).Start();
        }

        private void fetchMatchInfo()
        {
            MyMatchPictureBox.Load(m_FriendFacade.GetPicture());
            UserGenderLabel.Invoke(new Action(() => UserGenderLabel.Text = m_FriendFacade.GetGender()));
            UserAgeLabel.Invoke(new Action(() => UserAgeLabel.Text = m_FriendFacade.GetAge().ToString()));
            UserLocationLabel.Invoke(new Action(() => UserLocationLabel.Text = m_FriendFacade.GetLocation()));
            MyMatchNameLabel.Invoke(new Action(() => MyMatchNameLabel.Text = m_FriendFacade.GetUserName()));
            new Thread(fetchLikedPages).Start();
            new Thread(fetchPictures).Start();
        }

        private void fetchPictures()
        {
            Thread thread = new Thread(
                () =>
                    {
                        m_Photos = m_FriendFacade.GetPictures();
                        fetchPhoto();
                    });
            thread.Start();
        }

        private void fetchLikedPages()
        {
            LikedPagesListBox.Invoke(new Action(() => LikedPagesListBox.Items.Clear()));
            List<Page> likedPages = m_FriendFacade.GetLikedPages();
            try
            {
                LikedPagesListBox.Invoke(
                    new Action(
                        () =>
                            {
                                foreach(Page page in likedPages)
                                {
                                    LikedPagesListBox.Items.Add(page);
                                }
                            }));
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


        private void postButton_Click(object i_Sender, EventArgs i_E)
        {
            postAndTagFriend(m_FriendFacade.FriendLogic.Friend, FirstMoveTextBox.Text);
        }

        private void postAndTagFriend(User i_ToTagged, string i_Message)
        {
            try
            {
                m_UserProfileFacade.PostAndTag(i_ToTagged, i_Message);
                MessageBox.Show(i_Message + k_MessageSentSuccessfully);
            }
            catch(Exception ex)
            {
                MessageBox.Show(k_MessageSomethingWrong);
            }
        }


        private void nextPictureButton_Click(object i_Sender, EventArgs i_E)
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

        private void previousPictureButton_Click(object i_Sender, EventArgs i_E)
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