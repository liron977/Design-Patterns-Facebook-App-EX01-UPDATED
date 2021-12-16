using System;
using System.Linq;
using System.Windows.Forms;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    internal partial class PostsChartByMonthsForm : Form
    {
        private PostRankFacade m_AppPostsFacade = new PostRankFacade();

        // private FacebookAppManager m_AppManager = FacebookAppManager.Instance;

        public PostsChartByMonthsForm()
        {
            InitializeComponent();
        }

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

        protected override void OnShown(EventArgs e)
        {
           
            displayedCommentsChartOrderedByMonths();
        }

        private void displayedCommentsChartOrderedByMonths()
        {
            int NumberOfMonths = m_AppPostsFacade.GetNumberOfMonths();
            for (int i = 1; i < NumberOfMonths; i++)
            {
                commentsChart.Series["Posts"].Points.AddXY(i, m_AppPostsFacade.GetUserPostsOrderedByMonth(i));
            }
        }
    }
}