using ONWELO_VOTE_APP.Entity;
using ONWELO_VOTE_APP.MainWindowOption;
using ONWELO_VOTE_APP.Models;
using ONWELO_VOTE_APP.UserOptions;
using Sieve.Models;
using System.Data;

namespace ONWELO_VOTE_APP
{
    public partial class MainWindow : Form
    {
        Voter CurentUser;
        readonly DataFinder DataFinder = new();
        string ChosenCandidateName;
        SieveModel VotersQuery= new()
        {
            Page=1,
            PageSize=9
        };
        SieveModel CandidatesQuery = new()
        {
            Page = 1,
            PageSize = 9
        };

        public MainWindow(Voter User)
        {
            InitializeComponent();
            CurentUser = User;
        }

        private async void MainWindow_Load(object sender, EventArgs e)
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
            VotersSearchTextBox_TextChanged(sender, e);
            CandidatesSearchTextBox_TextChanged(sender, e);

        }

        private async void EditAccountButton_Click(object sender, EventArgs e)
        {
            var form = new UserDataWindow(CurentUser);
            await Task.Run(() => form.ShowDialog());
            CurentUser = form.ReturnValue;
            UserLable.Text = "Hi " + CurentUser.Name;
            VotersSearchTextBox_TextChanged(sender, e);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            this.Close();
        }

        private async void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            var result= await AccountDeleter.Delete(CurentUser);
            if(result)
            {
                DialogResult = DialogResult.Yes;
                this.Close();
                return;
            }
            else
            {
                await ResultLabelShow("Cannot delete your account?");
            }
            
        }
        async Task ResultLabelShow(string text)
        {
            ResultLabel.Text = text;
            await Task.Delay(4000);
            ResultLabel.Text = "";
        }

        private async void VotersSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            PageResult<VoterDto> VotersData;
            if (VotersCurrentPageTextBox.Text == "0" || VotersCurrentPageTextBox.Text == "" || Convert.ToInt32(VotersCurrentPageTextBox.Text) > Convert.ToInt32(VotersTotalPagesLabel.Text.Remove(0, 1)))
            {
                await ResultLabelShow("Incorrect page data");
                return;
            }
            VotersQuery.Page = Convert.ToInt32(VotersCurrentPageTextBox.Text);
            if (VotersSearchTextBox.Text.Length == 0 || VotersSearchTextBox.Text == "Search")
            {
                VotersData = await DataFinder.GetVotersData(VotersQuery);
            }
            else
            {
                VotersData = await DataFinder.FindVoters(VotersSearchTextBox.Text, VotersQuery);
            }
            VotersDataGridView.DataSource = VotersData.Items;
            VotersTotalPagesLabel.Text = "/" + VotersData.TotalPages.ToString();
            VotersResultLabel.Text = VotersData.TotalItemsCount.ToString();

        }

        private async void CandidatesSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            PageResult<CandidateDto> CandidatesData;
            if (CandidatesCurrentPageTextBox.Text == "0" || CandidatesCurrentPageTextBox.Text == "" || Convert.ToInt32(CandidatesCurrentPageTextBox.Text) > Convert.ToInt32(CandidatesTotalPagesLabel.Text.Remove(0, 1)))
            {
                await ResultLabelShow("Incorrect page data");
                return;
            }
            CandidatesQuery.Page = Convert.ToInt32(CandidatesCurrentPageTextBox.Text);
            if (CandidatesSearchTextBox.Text.Length == 0 || CandidatesSearchTextBox.Text == "Search")
            {
                CandidatesData = await DataFinder.GetCandidatesData(CandidatesQuery);
            }
            else
            {
                CandidatesData = await DataFinder.FindCandidates(CandidatesSearchTextBox.Text, CandidatesQuery);
            }
            CandidatesDataGridView.DataSource = CandidatesData.Items;
            CandidatesTotalPagesLabel.Text = "/" + CandidatesData.TotalPages.ToString();
            CandidatesResultLabel.Text = CandidatesData.TotalItemsCount.ToString();
        }

        private  async void AddCandidateButton_Click(object sender, EventArgs e)
        {
            if (CurentUser.AmountOfCandidats==0)
            {
                await ResultLabelShow("You can't add more candidates");
                return;
            }
            if (CandidateNameTextBox.Text.Length==0)
            {

                await ResultLabelShow("Please insert candidate name");
                return;
            }
            if (CandidateNameTextBox.Text.Length < 4)
            {
                await ResultLabelShow("Candidate name must contains at least 4 characters");
                return;
            }
          
            if (!CandidateValidater.Validate(CandidateNameTextBox.Text))
            {
                await  ResultLabelShow("This candidate exist");
                return;
            }
            var NewCandidate = new Candidate()
            {
                Name = CandidateNameTextBox.Text
            };
            CurentUser = await CandidatesAdder.Add(NewCandidate, CurentUser);
            if (CurentUser.AmountOfCandidats == 1)
            {
                AmountCandidateslabel.Text = "You can add " + CurentUser.AmountOfCandidats.ToString() + " candidate";
            }
            else
            {
                AmountCandidateslabel.Text = "You can add " + CurentUser.AmountOfCandidats.ToString() + " candidates";
            }

            CandidateNameTextBox.Text = "";
            ChoosedCandidatLabel.Text = "";

            CandidatesSearchTextBox_TextChanged(sender, e);
            await ResultLabelShow("Candidate has been added");

        }
        private  void VotersSearchTextBox_Click(object sender, EventArgs e)
        {
            VotersSearchTextBox.Text = "";
        }
        private void CandidatesSearchTextBox_Click(object sender, EventArgs e)
        {
            CandidatesSearchTextBox.Text = "";
        }
        private void CandidatesDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (CandidatesDataGridView.SelectedRows.Count > 0)
            {
                var name = CandidatesDataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
                ChoosedCandidatLabel.Text = name;
                ChosenCandidateName = name;
            }


        }

        private async void VoteButton_Click(object sender, EventArgs e)
        {
            if(ChosenCandidateName==null)
            {
                await ResultLabelShow("Please select your candidate");
                return;
            }
            if(CurentUser.HasVoted)
            {
                await ResultLabelShow("You has been voted");
                return;
            }
            CurentUser = await VoteAdder.Vote(ChosenCandidateName, CurentUser);
            if(!CurentUser.HasVoted)
            {
                await  ResultLabelShow("Something go wrong. Please try again later");
                return;
            }
            VotersSearchTextBox_TextChanged(sender, e);
            CandidatesSearchTextBox_TextChanged(sender, e);
            await ResultLabelShow("Thanks for voted!");


        }

        private void VotersCurrentPageTextBox_TextChanged(object sender, EventArgs e)
        {
            VotersSearchTextBox_TextChanged(sender, e);
        }

        private void CandidatesCurrentPageTextBox_TextChanged(object sender, EventArgs e)
        {
            CandidatesSearchTextBox_TextChanged(sender, e);
        }
    }
}