﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    internal partial class MyMatchForm : Form
    {
        //private FacebookAppManager m_MatchAppManager = FacebookAppManager.Instance;
        public FriendPacade m_FriendPacade = new FriendPacade();
        //private FacebookAppManager m_UserAppManager = FacebookAppManager.Instance;
        public UserProfilePacade m_UserProfilePacade = new UserProfilePacade();

        private List<Photo> m_Photos;
        private int m_PhotoListIndex;
        private const string k_MessageSomethingWrong = @"Something wrong. Try later";
        private const string k_MessageSentSuccessfully = "-sent successfully";

        /*public FacebookAppManager UserAppManager
        {
            get
            {
                return m_UserAppManager;
            }
            set
            {
                m_UserAppManager = value;
            }
        }*/
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
            MyMatchPictureBox.Load(m_FriendPacade.GetPicture());
            UserGenderLabel.Text = m_FriendPacade.GetGender();
            UserAgeLabel.Text = m_FriendPacade.GetAge().ToString();
            UserLocationLabel.Text = m_FriendPacade.GetLocation();
            MyMatchNameLabel.Text = m_FriendPacade.GetUserName();
            m_Photos = m_FriendPacade.GetPictures();
            fetchPhoto();
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            LikedPagesListBox.Items.Clear();
            List<Page> likedPages = m_FriendPacade.GetLikedPages();
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
            postAndTagFriend(m_FriendPacade.FriendLogic.Friend, FirstMoveTextBox.Text);
        }

        private void postAndTagFriend(User i_ToTagged, string i_Message)
        {
            try
            {
                m_UserProfilePacade.PostAndTag(i_ToTagged, i_Message);
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