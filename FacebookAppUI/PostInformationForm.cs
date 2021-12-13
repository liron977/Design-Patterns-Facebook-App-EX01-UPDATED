using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    internal partial class PostInformationForm : Form
    {
        public Post m_UserPost;
        private FacebookAppManager m_AppManager = new FacebookAppManager();
        private const string k_MessageSomethingWrong = "Something wrong. Try later";
        private const string k_MessageNoData = "No data to show";
        private const string k_MessageStatusPosted = "Status Posted!";

        public PostInformationForm()
        {
            InitializeComponent();
        }

        public FacebookAppManager AppManager
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

        public void Post(Post i_UserSelectedPost)
        {
            m_UserPost = i_UserSelectedPost;
        }

        private void fetchUserPostMessage()
        {
            try
            {
                postTextBox.Text = m_UserPost.Message;
            }
            catch
            {
                postTextBox.Text = k_MessageNoData;
                MessageBox.Show(k_MessageSomethingWrong);
            }
        }

        private void fetchUserPostTaggedFriends()
        {
            try
            {
                labelTaggedFriends.Text = m_UserPost.TaggedUsers.Count.ToString();
            }
            catch
            {
                MessageBox.Show(k_MessageSomethingWrong);
                labelTaggedFriends.Text = k_MessageNoData;
            }
        }

        private void fetchUserPostCreatedTime()
        {
            try
            {
                timeCreate.Text = m_UserPost.CreatedTime.ToString();
            }
            catch
            {
                MessageBox.Show(k_MessageSomethingWrong);
                timeCreate.Text = k_MessageNoData;
            }
        }

        private void fetchUserPostComments()
        {
            try
            {
                Comments.Text = m_UserPost.Comments.Count.ToString();
            }
            catch
            {
                MessageBox.Show(k_MessageSomethingWrong);
                Comments.Text = k_MessageNoData;
            }
        }


        protected override void OnShown(EventArgs e)
        {
            fetchUserPostMessage();
            fetchUserPostTaggedFriends();
            fetchUserPostCreatedTime();
            fetchUserPostComments();
        }

        private void PostInformation_Load(object sender, EventArgs e)

        {
            fetchUserPostMessage();
        }

        private void shareYouPostButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(!(string.IsNullOrEmpty(postTextBox.Text)))
                {
                    Status postedStatus = AppManager.LoggedInUser.PostStatus(postTextBox.Text);
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