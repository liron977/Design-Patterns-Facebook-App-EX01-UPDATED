using System;
using System.Linq;
using System.Windows.Forms;
using FacebookAppLogic;


namespace BasicFacebookFeatures
{
    internal partial class PostsChartByYearForm : Form
    {
        private PostRankFacade m_AppPostsFacade = new PostRankFacade();

        
        public const int k_Millennium = 2000;

        public PostsChartByYearForm()
        {
            InitializeComponent();
        }


        protected override void OnShown(EventArgs e)
        {
           
            displayedCommentsChartOrderedByYear();
        }

        private void displayedCommentsChartOrderedByYear()
        {
            int currentYear = m_AppPostsFacade.GetCurrentYear();

            for (int i = 1; i < currentYear; i++)
            {
                commentsChart.Series["Posts"].Points.AddXY(
                    i + k_Millennium,
                    m_AppPostsFacade.GetUserPostsOrderedByYear(i));
            }
        }
    }
}