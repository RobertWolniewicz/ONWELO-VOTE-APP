using ONWELO_VOTE_APP.Entity;

namespace ONWELO_VOTE_APP
{
    public partial class MainWindow : Form
    {
        Voter CurentUser;
        public MainWindow(Voter User)
        {
            InitializeComponent();
            CurentUser = User;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            UserLable.Text = "Hi " + CurentUser.Name;
            ResultLabel.Text = "";
            ChoosedCandidatLabel.Text = "";
            if (CurentUser.AmountOfCandidats == 1)
            {
                AmountCandidateslabel.Text = "You can add " + CurentUser.AmountOfCandidats.ToString() + " candidate";
            }
            else
            {
                AmountCandidateslabel.Text = "You can add " + CurentUser.AmountOfCandidats.ToString() + " candidates";
            }
            
        }

        private async void EditAccountButton_Click(object sender, EventArgs e)
        {
            var form = new UserDataWindow(CurentUser);
            await Task.Run(() => form.ShowDialog());
        }
    }
}