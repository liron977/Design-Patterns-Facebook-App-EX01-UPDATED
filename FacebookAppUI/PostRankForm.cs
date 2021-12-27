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
        private readonly PostRankFacade r_AppPostsFacade = new PostRankFacade();
        private Dictionary<Post, int> m_UserPosts;
        private const string k_ErrorMessage = "No posts to retrieve";
        private const string k_ErrorCantDisplayInfo = "Sorry we can`t displayed information on this post";

        public PostRankForm()
        {
            InitializeComponent();
        }

        private void displayedPostCommentsRank()
        {
            try
            {
                Post thePopularPostByComments = r_AppPostsFacade.GetTheMostPopularPostByComments();

                textBox1.Text = thePopularPostByComments.Message;
            }

            catch
            {
                textBox1.Text = k_ErrorMessage;
            }
        }

        private void monthsChartPosts_Click(object i_Sender, EventArgs i_E)
        {
            PostsChartByMonthsForm commentsChartByMonths = new PostsChartByMonthsForm(r_AppPostsFacade);
            commentsChartByMonths.Show();
        }

        private void yearChartPost_Click(object i_Sender, EventArgs i_E)
        {
            PostsChartByYearForm commentsChartByYear = new PostsChartByYearForm(r_AppPostsFacade);
            commentsChartByYear.Show();
        }

        protected override void OnShown(EventArgs i_E)
        {
            changeButtonStatus(false);
            r_AppPostsFacade.InitPostsInfo();
            fetchInfo();
            changeButtonStatus(true);
        }

        private void fetchInfo()
        {
            m_UserPosts = r_AppPostsFacade.GetUserPosts();
            displayedPostCommentsRank();
        }

        private void changeButtonStatus(bool i_EnableButton)
        {
            monthsChartPosts.Enabled = i_EnableButton;
            yearChartPost.Enabled = i_EnableButton;
            ascending.Enabled = i_EnableButton;
            descendingSorted.Enabled = i_EnableButton;
        }

        private void ascending_CheckedChanged(object i_Sender, EventArgs i_E)
        {
            ascendingInfo();
        }

        private void ascendingInfo()
        {
            descendingSorted.Enabled = true;

            List<Post> ascendingSortedPosts = new List<Post>();
            try
            {
                var ascendingSort = from objDict in m_UserPosts orderby objDict.Value select objDict;
                foreach(KeyValuePair<Post, int> kvp in ascendingSort)
                {
                    if(!string.IsNullOrEmpty(kvp.Key.Message))
                    {
                        ascendingSortedPosts.Add(kvp.Key);
                    }
                }

                postBindingSource.DataSource = ascendingSortedPosts;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ascending.Checked = false;
            ascending.Enabled = false;
        }

        private void descendingSortedInfo()
        {
            List<Post> descendingSortedPosts = new List<Post>();

            ascending.Enabled = true;
            var dictSort = from objDict in m_UserPosts orderby objDict.Value descending select objDict;
            try
            {
                foreach(KeyValuePair<Post, int> kvp in dictSort)
                {
                    if(!string.IsNullOrEmpty(kvp.Key.Message))
                    {
                        descendingSortedPosts.Add(kvp.Key);
                    }
                }

                postBindingSource.DataSource = descendingSortedPosts;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            descendingSorted.Checked = false;
            descendingSorted.Enabled = false;
        }

        private void descendingSorted_CheckedChanged(object i_Sender, EventArgs i_E)
        {
            descendingSortedInfo();
        }

        private void postMessage_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            if(postMessage.SelectedItems.Count == 1)
            {
                if(postMessage.SelectedItem is Post selectedPost && selectedPost.Message != null)
                {
                    PostInformationForm postInformationForm = new PostInformationForm();
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