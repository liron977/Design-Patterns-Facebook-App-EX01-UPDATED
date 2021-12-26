﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System.Threading;
namespace BasicFacebookFeatures
{
    internal partial class UserProfileForm : Form
    {
      
        private readonly UserProfileFacade r_ProfileFacade = new UserProfileFacade();

        private const string k_MessageSomethingWrong = "Something wrong. Try later";
        private const string k_MessageNoData = "No data to show";
        private const string k_MessageStatusPosted = "Status Posted! ID";
        private const string k_MessageErrorBirthday = @"None of your friends has birthday in the next 3 days";


        public UserProfileForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            new Thread(fetchInfo).Start();
        }
        protected void fetchInfo()
        {
          ProfilePicture.Load(r_ProfileFacade.GetPicture());
            new Thread(fetchNewsFeed).Start();
            new Thread(fetchFriends).Start();
            new Thread(fetchUpcomingBirthdays).Start();
            new Thread(fetchAlbums).Start();
        }

        private void fetchUpcomingBirthdays()
        {
            try
            {
                if(upcomingBirthdaysListBox.Items.Count != 0)
                {
                    upcomingBirthdaysListBox.Invoke(new Action(() => upcomingBirthdaysListBox.Items.Clear()));
                }
                else
                {
                    List<string> friendList = r_ProfileFacade.GetUpcomingBirthdays();

                    foreach(string friendUser in friendList)
                    {
                        upcomingBirthdaysListBox.Invoke(new Action(() => upcomingBirthdaysListBox.Items.Add(friendUser)));
                    }

                    if(friendsListBox.Items.Count == 0)
                    {
                        MessageBox.Show(k_MessageErrorBirthday);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchFriends()
        {
            try
            {
                if(friendsListBox.Items.Count != 0)
                {
                    friendsListBox.Items.Clear();
                }
                else
                {
                    List<User> friendList = r_ProfileFacade.GetFriends();

                    foreach(User friendUser in friendList)
                    {
                        friendsListBox.Invoke(new Action(() => friendsListBox.Items.Add(friendUser)));
                    }

                    if(friendsListBox.Items.Count == 0)
                    {
                        MessageBox.Show(k_MessageNoData);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void fetchNewsFeed()
        {
            try
            {
                List<string> userPosts = r_ProfileFacade.GetNewsFeed();

                foreach(string post in userPosts)
                {
                    posts.Invoke(new Action(() => posts.Items.Add(post)));
                }

                if(posts.Items.Count == 0)
                {
                    posts.Invoke(new Action(() => posts.Items.Add(k_MessageNoData)));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSelectedFriendDetails();
        }

        private void showSelectedFriendDetails()
        {
            if(friendsListBox.SelectedItems.Count == 1)
            {
                User userFriend = friendsListBox.SelectedItem as User;
                FriendProfileForm friendProfile = new FriendProfileForm();            
                friendProfile.r_ProfileFacade.FriendLogic.Friend = userFriend;

                friendProfile.Show();
         
            }
        }

        private void fetchAlbums()
        {
            try
            {
                /*List<Album> userAlbums = m_ProfileFacade.GetAlbums();

                foreach(Album album in userAlbums)
                {
                    albumListBox.Invoke(new Action(() => albumListBox.Items.Add(album)));
                }

                if(albumListBox.Items.Count == 0)
                {
                    albumListBox.Invoke(new Action(() => albumListBox.Items.Add(k_MessageNoData)));
                }*/
                List<Album> userAlbums = r_ProfileFacade.GetAlbums();
                albumBindingSource.DataSource = userAlbums;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       /* private void albumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (albumListBox.SelectedItems.Count == 1)
            {
                Album selectedAlbum = albumListBox.SelectedItem as Album;
                if (selectedAlbum != null && selectedAlbum.PictureAlbumURL != null)
                {
                    AlbumCoverPictureBox.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    AlbumCoverPictureBox.Image = AlbumCoverPictureBox.ErrorImage;
                }

            }
            

        }*/

        private void postStatusButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(!(string.IsNullOrEmpty(PostStatusTextBox.Text)))
                {
                    Status postedStatus = r_ProfileFacade.PostStatus(PostStatusTextBox.Text);
                    MessageBox.Show(k_MessageStatusPosted);
                }
                else
                {
                    MessageBox.Show(k_MessageSomethingWrong);
                }
            }
            catch
            {
                MessageBox.Show(k_MessageSomethingWrong);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AlbumCoverPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}