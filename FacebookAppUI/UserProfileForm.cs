using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal partial class UserProfileForm : Form
    {
        //private FacebookAppManager m_AppManager = FacebookAppManager.Instance;
        private UserProfilePacade m_ProfilePacade = new UserProfilePacade();
        //private FriendPacade m_FriendPacade = new FriendPacade();

        private const string k_MessageSomethingWrong = "Something wrong. Try later";
        private const string k_MessageNoData = "No data to show";
        private const string k_MessageStatusPosted = "Status Posted! ID";
        private const string k_MessageErrorBirthday = @"None of your friends has birthday in the next 3 days";

       /* public FacebookAppManager AppManager
        {
            get
            {
                return m_AppManager;
            }
            set
            {
                m_AppManager = value;
            }
        }*/

        public UserProfileForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            ProfilePicture.Load(m_ProfilePacade.GetPicture());
            fetchNewsFeed();
            fetchFriends();
            fetchUpcomingBirthdays();
            fetchAlbums();
        }


        private void fetchUpcomingBirthdays()
        {
            try
            {
                if(upcomingBirthdaysListBox.Items.Count != 0)
                {
                    upcomingBirthdaysListBox.Items.Clear();
                }
                else
                {
                    List<string> friendList = m_ProfilePacade.GetUpcomingBirthdays();

                    foreach(string friendUser in friendList)
                    {
                        upcomingBirthdaysListBox.Items.Add(friendUser);
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
                    List<User> friendList = m_ProfilePacade.GetFriends();

                    foreach(User friendUser in friendList)
                    {
                        friendsListBox.Items.Add(friendUser);
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
                List<string> userPosts = m_ProfilePacade.GetNewsFeed();

                foreach(string post in userPosts)
                {
                    posts.Items.Add(post);
                }

                if(posts.Items.Count == 0)
                {
                    posts.Items.Add(k_MessageNoData);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //User user = m_AppManager.LoggedInUser;
            showSelectedFriendDetails();
           // m_AppManager.LoggedInUser = user;
        }

        private void showSelectedFriendDetails()
        {
            if(friendsListBox.SelectedItems.Count == 1)
            {
                User userFriend = friendsListBox.SelectedItem as User;
                FriendProfileForm friendProfile = new FriendProfileForm();
                //friendProfile.AppManager.LoggedInUser = userFriend;
              
                friendProfile.r_ProfilePasade.FriendLogic.Friend = userFriend;

                friendProfile.Show();
         
            }
        }

        private void fetchAlbums()
        {
            try
            {
                List<Album> userAlbums = m_ProfilePacade.GetAlbums();

                foreach(Album album in userAlbums)
                {
                    albumListBox.Items.Add(album);
                }

                if(albumListBox.Items.Count == 0)
                {
                    albumListBox.Items.Add(k_MessageNoData);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void albumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(albumListBox.SelectedItems.Count == 1)
            {
                Album selectedAlbum = albumListBox.SelectedItem as Album;
                if(selectedAlbum != null && selectedAlbum.PictureAlbumURL != null)
                {
                    AlbumCoverPictureBox.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    AlbumCoverPictureBox.Image = AlbumCoverPictureBox.ErrorImage;
                }
            }
        }

        private void postStatusButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(!(string.IsNullOrEmpty(PostStatusTextBox.Text)))
                {
                    Status postedStatus = m_ProfilePacade.PostStatus(PostStatusTextBox.Text);
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
    }
}