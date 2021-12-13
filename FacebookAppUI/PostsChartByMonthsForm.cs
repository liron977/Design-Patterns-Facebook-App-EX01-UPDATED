using System;
using System.Linq;
using System.Windows.Forms;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    internal partial class PostsChartByMonthsForm : Form
    {
        private PostRankFormLogic m_AppPostsRank;
        private FacebookAppManager m_AppManager = new FacebookAppManager();

        public PostsChartByMonthsForm()
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

        protected override void OnShown(EventArgs e)
        {
            m_AppPostsRank = new PostRankFormLogic(m_AppManager.LoggedInUser);
            displayedCommentsChartOrderedByMonths();
        }

        private void displayedCommentsChartOrderedByMonths()
        {
            for(int i = 1; i < m_AppPostsRank.NumberOfMonths; i++)
            {
                commentsChart.Series["Posts"].Points.AddXY(i, m_AppPostsRank.UserPostsOrderedByMonth[i].Count());
            }
        }
    }
}