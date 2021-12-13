using System;
using System.Linq;
using System.Windows.Forms;
using FacebookAppLogic;


namespace BasicFacebookFeatures
{
    internal partial class PostsChartByYearForm : Form
    {
        public PostRankFormLogic m_AppPostsRank;
        private FacebookAppManager m_AppManager = new FacebookAppManager();
        public const int k_Millennium = 2000;

        public PostsChartByYearForm()
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
            displayedCommentsChartOrderedByYear();
        }

        private void displayedCommentsChartOrderedByYear()
        {
            for(int i = 1; i < m_AppPostsRank.CurrentYear; i++)
            {
                commentsChart.Series["Posts"].Points.AddXY(
                    i + k_Millennium,
                    m_AppPostsRank.UserPostsOrderedByYear[i].Count);
            }
        }
    }
}