using System;
using System.Windows.Forms;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    internal partial class PostsChartByMonthsForm : Form
    {
        private readonly PostRankFacade r_AppPostsFacade;

        public PostsChartByMonthsForm(PostRankFacade i_AppPostsFacade)
        {
            r_AppPostsFacade = i_AppPostsFacade;
            InitializeComponent();
        }


        protected override void OnShown(EventArgs i_E)
        {
            displayedCommentsChartOrderedByMonths();
        }

        private void displayedCommentsChartOrderedByMonths()
        {
            int numberOfMonths = r_AppPostsFacade.GetNumberOfMonths();
            for(int i = 1; i < numberOfMonths; i++)
            {
                commentsChart.Series["Posts"].Points.AddXY(i, r_AppPostsFacade.GetUserPostsOrderedByMonth(i));
            }
        }
    }
}