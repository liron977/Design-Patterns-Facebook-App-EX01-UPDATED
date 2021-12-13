using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;


namespace BasicFacebookFeatures
{
    internal partial class PostRankForm : Form
    {
        private PostRankFormLogic m_AppPostsRank;
        private FacebookAppManager m_AppManager = new FacebookAppManager();
        private Dictionary<Post, int> m_UserPosts;
        private const string k_ErrorMessage = "No posts to retrieve";
        private const string k_ErrorCantDisplayInfo = "Sorry we can`t displayed information on this post";

        public PostRankForm()
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

        public PostRankFormLogic AppPostsRank
        {
            get
            {
                return m_AppPostsRank;
            }
            set
            {
                m_AppPostsRank = value;
            }
        }

        private void displayedPostCommentsRank()
        {
            try
            {
                Post thePopularPostByComments = m_AppPostsRank.TheMostPopularPostByComments();

                textBox1.Text = thePopularPostByComments.Message;
            }

            catch
            {
                textBox1.Text = k_ErrorMessage;
            }
        }

        private void monthsChartPosts_Click(object sender, EventArgs e)
        {
            PostsChartByMonthsForm commentsChartByMonths = new PostsChartByMonthsForm { AppManager = AppManager };
            commentsChartByMonths.Show();
        }

        private void yearChartPost_Click(object sender, EventArgs e)
        {
            PostsChartByYearForm commentsChartByYear = new PostsChartByYearForm { AppManager = AppManager };
            commentsChartByYear.Show();
        }

        protected override void OnShown(EventArgs e)
        {
            m_UserPosts = m_AppPostsRank.UserPosts;
            displayedPostCommentsRank();
        }

        private void ascending_CheckedChanged(object sender, EventArgs e)
        {
            descendingSorted.Enabled = true;
            postMessage.Items.Clear();

            try
            {
                m_UserPosts = m_AppPostsRank.UserPosts;
                var ascendingSort = from objDict in m_UserPosts orderby objDict.Value select objDict;
                foreach(KeyValuePair<Post, int> kvp in ascendingSort)
                {
                    postMessage.Items.Add(kvp.Key);
                }

                if(postMessage.Items.Count == 0)
                {
                    postMessage.Items.Add(k_ErrorMessage);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ascending.Checked = false;
            ascending.Enabled = false;
        }

        private void descendingSorted_CheckedChanged(object sender, EventArgs e)
        {
            postMessage.Items.Clear();
            ascending.Enabled = true;
            var dictSort = from objDict in m_UserPosts orderby objDict.Value descending select objDict;
            try
            {
                foreach(KeyValuePair<Post, int> kvp in dictSort)
                {
                    postMessage.Items.Add(kvp.Key);
                }

                if(postMessage.Items.Count == 0)
                {
                    postMessage.Items.Add(k_ErrorMessage);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            descendingSorted.Checked = false;
            descendingSorted.Enabled = false;
        }

        private void postMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(postMessage.SelectedItems.Count == 1)
            {
                if(postMessage.SelectedItem is Post selectedPost && selectedPost.Message != null)
                {
                    PostInformationForm postInformationForm = new PostInformationForm { AppManager = AppManager };
                    postInformationForm.Post(selectedPost);
                    postInformationForm.Show();
                }
                else
                {
                    MessageBox.Show(k_ErrorCantDisplayInfo);
                }
            }
        }
    }
}