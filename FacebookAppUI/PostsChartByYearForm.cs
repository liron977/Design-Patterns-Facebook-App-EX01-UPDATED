using System;
using System.Windows.Forms;
using FacebookAppLogic;


namespace BasicFacebookFeatures
{
    internal partial class PostsChartByYearForm : Form
    {
        private readonly PostRankFacade r_AppPostsFacade;


        public const int k_Millennium = 2000;

        public PostsChartByYearForm(PostRankFacade i_AppPostsFacade)
        {
            r_AppPostsFacade = i_AppPostsFacade;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs i_E)
        {
            displayedCommentsChartOrderedByYear();
        }

        private void displayedCommentsChartOrderedByYear()
        {
            int currentYear = r_AppPostsFacade.GetCurrentYear();

            for(int i = 1; i < currentYear; i++)
            {
                commentsChart.Series["Posts"].Points.AddXY(
                    i + k_Millennium,
                    r_AppPostsFacade.GetUserPostsOrderedByYear(i));
            }
        }
    }
}