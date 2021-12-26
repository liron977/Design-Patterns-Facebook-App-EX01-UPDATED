using System;
using System.Linq;
using System.Windows.Forms;
using FacebookAppLogic;


namespace BasicFacebookFeatures
{
    internal partial class PostsChartByYearForm : Form
    {
        private readonly PostRankFacade r_AppPostsFacade = new PostRankFacade();

        
        public const int k_Millennium = 2000;

        public PostsChartByYearForm(PostRankFacade i_AppPostsFacade)
        {
            r_AppPostsFacade = i_AppPostsFacade;
            InitializeComponent();
        }


        protected override void OnShown(EventArgs e)
        {
           
            displayedCommentsChartOrderedByYear();
        }

        private void displayedCommentsChartOrderedByYear()
        {
            int currentYear = r_AppPostsFacade.GetCurrentYear();

            for (int i = 1; i < currentYear; i++)
            {
                commentsChart.Series["Posts"].Points.AddXY(
                    i + k_Millennium,
                    r_AppPostsFacade.GetUserPostsOrderedByYear(i));
            }
        }
    }
}