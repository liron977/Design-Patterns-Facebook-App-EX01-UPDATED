using System;
using System.Linq;
using System.Windows.Forms;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    internal partial class PostsChartByMonthsForm : Form
    {
        private readonly PostRankFacade r_AppPostsFacade = new PostRankFacade();

        // private FacebookAppManager m_AppManager = FacebookAppManager.Instance;

        public PostsChartByMonthsForm(PostRankFacade i_AppPostsFacade)
        {
            r_AppPostsFacade = i_AppPostsFacade;
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
            int NumberOfMonths = r_AppPostsFacade.GetNumberOfMonths();
            for (int i = 1; i < NumberOfMonths; i++)
            {
                commentsChart.Series["Posts"].Points.AddXY(i, r_AppPostsFacade.GetUserPostsOrderedByMonth(i));
            }
        }
    }
}