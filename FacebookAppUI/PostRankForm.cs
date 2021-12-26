using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;
using System.Threading;


namespace BasicFacebookFeatures
{
    internal partial class PostRankForm : Form
    {
        private readonly PostRankFacade r_AppPostsFacade=new PostRankFacade();
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

        private void monthsChartPosts_Click(object sender, EventArgs e)
        {
            PostsChartByMonthsForm commentsChartByMonths = new PostsChartByMonthsForm(r_AppPostsFacade);
            commentsChartByMonths.Show();
        }

        private void yearChartPost_Click(object sender, EventArgs e)
        {
            PostsChartByYearForm commentsChartByYear = new PostsChartByYearForm(r_AppPostsFacade);
            commentsChartByYear.Show();
        }

        protected override void OnShown(EventArgs e)
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
        private void ascending_CheckedChanged(object sender, EventArgs e)
        {
           ascendingInfo();
        }

        private void ascendingInfo()
        {
            descendingSorted.Enabled = true;
            //postMessage.Items.Clear();
            List<Post> ascendingSortedPosts = new List<Post>();
            try
            {
               // m_UserPosts = r_AppPostsFacade.GetUserPosts();
                var ascendingSort = from objDict in m_UserPosts orderby objDict.Value select objDict;
                foreach (KeyValuePair<Post, int> kvp in ascendingSort)
                {
                   if(kvp.Key.Message!=""&& kvp.Key.Message != null)
                   {ascendingSortedPosts.Add(kvp.Key);}
                    
                }

                /*if (postMessage.Items.Count == 0)
                {
                    postMessage.Invoke(new Action(() => postMessage.Items.Add(k_ErrorMessage)));
                }*/
                postBindingSource.DataSource = ascendingSortedPosts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ascending.Checked = false;
            ascending.Enabled = false;
        }

        private void descendingSortedInfo()
        {
            List<Post> descendingSortedPosts = new List<Post>();

            // postMessage.Invoke(new Action(() => postMessage.Items.Clear()));
            ascending.Enabled = true;
            var dictSort = from objDict in m_UserPosts orderby objDict.Value descending select objDict;
            try
            {

                foreach (KeyValuePair<Post, int> kvp in dictSort)
                {
                    if (kvp.Key.Message != "" && kvp.Key.Message != null)
                    { descendingSortedPosts.Add(kvp.Key); }

                }
                /* foreach (KeyValuePair<Post, int> kvp in dictSort)
                 {
                     postMessage.Invoke(new Action(() => postMessage.Items.Add(kvp.Key)));
                 }

                 if (postMessage.Items.Count == 0)
                 {
                     postMessage.Invoke(new Action(() => postMessage.Items.Add(k_ErrorMessage)));
                 }*/
                postBindingSource.DataSource = dictSort;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            descendingSorted.Checked = false;
            descendingSorted.Enabled = false;
        }
        private void descendingSorted_CheckedChanged(object sender, EventArgs e)
        {
            descendingSortedInfo();
        }

        private void postMessage_SelectedIndexChanged(object sender, EventArgs e)
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

        private void messageLabel_Click(object sender, EventArgs e)
        {

        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}