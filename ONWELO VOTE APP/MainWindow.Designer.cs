namespace ONWELO_VOTE_APP
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.voterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VotersDataGridView = new System.Windows.Forms.DataGridView();
            this.CandidatesDataGridView = new System.Windows.Forms.DataGridView();
            this.UserLable = new System.Windows.Forms.Label();
            this.InfoLabel3 = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.InfoLabel2 = new System.Windows.Forms.Label();
            this.ChoosedCandidatLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.AmountCandidateslabel = new System.Windows.Forms.Label();
            this.AddCandidateButton = new System.Windows.Forms.Button();
            this.VoteButton = new System.Windows.Forms.Button();
            this.VotersSearchTextBox = new System.Windows.Forms.TextBox();
            this.CandidatesSearchTextBox = new System.Windows.Forms.TextBox();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.VotersGroupBox = new System.Windows.Forms.GroupBox();
            this.VotersCurrentPageTextBox = new System.Windows.Forms.TextBox();
            this.VotersTotalPagesLabel = new System.Windows.Forms.Label();
            this.VotersPagesLabel = new System.Windows.Forms.Label();
            this.VotersResultLabel = new System.Windows.Forms.Label();
            this.VotersTotalResultLabel = new System.Windows.Forms.Label();
            this.CandidatesGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoLabel4 = new System.Windows.Forms.Label();
            this.CandidateNameTextBox = new System.Windows.Forms.TextBox();
            this.CandidatesTotalPagesLabel = new System.Windows.Forms.Label();
            this.CandidatesCurrentPageTextBox = new System.Windows.Forms.TextBox();
            this.CandidatesPagesLabel = new System.Windows.Forms.Label();
            this.CandidatesResultLabel = new System.Windows.Forms.Label();
            this.CandidatesTotalResultsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EditAccountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VotersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatesDataGridView)).BeginInit();
            this.VotersGroupBox.SuspendLayout();
            this.CandidatesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // voterBindingSource
            // 
            this.voterBindingSource.DataSource = typeof(ONWELO_VOTE_APP.Entity.Voter);
            // 
            // candidateBindingSource
            // 
            this.candidateBindingSource.DataSource = typeof(ONWELO_VOTE_APP.Entity.Candidate);
            // 
            // VotersDataGridView
            // 
            this.VotersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VotersDataGridView.Location = new System.Drawing.Point(6, 68);
            this.VotersDataGridView.Name = "VotersDataGridView";
            this.VotersDataGridView.ReadOnly = true;
            this.VotersDataGridView.RowTemplate.Height = 32;
            this.VotersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VotersDataGridView.Size = new System.Drawing.Size(244, 329);
            this.VotersDataGridView.TabIndex = 0;
            // 
            // CandidatesDataGridView
            // 
            this.CandidatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidatesDataGridView.Location = new System.Drawing.Point(6, 68);
            this.CandidatesDataGridView.Name = "CandidatesDataGridView";
            this.CandidatesDataGridView.ReadOnly = true;
            this.CandidatesDataGridView.RowTemplate.Height = 32;
            this.CandidatesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CandidatesDataGridView.Size = new System.Drawing.Size(244, 329);
            this.CandidatesDataGridView.TabIndex = 2;
            this.CandidatesDataGridView.SelectionChanged += new System.EventHandler(this.CandidatesDataGridView_SelectionChanged);
            // 
            // UserLable
            // 
            this.UserLable.AutoSize = true;
            this.UserLable.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserLable.Location = new System.Drawing.Point(12, 9);
            this.UserLable.Name = "UserLable";
            this.UserLable.Size = new System.Drawing.Size(75, 28);
            this.UserLable.TabIndex = 5;
            this.UserLable.Text = "Hi User";
            // 
            // InfoLabel3
            // 
            this.InfoLabel3.AutoSize = true;
            this.InfoLabel3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel3.Location = new System.Drawing.Point(485, 485);
            this.InfoLabel3.Name = "InfoLabel3";
            this.InfoLabel3.Size = new System.Drawing.Size(79, 37);
            this.InfoLabel3.TabIndex = 6;
            this.InfoLabel3.Text = "Vote!";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(485, 457);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(251, 28);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "Choose your candidate and";
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel2.Location = new System.Drawing.Point(485, 522);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(166, 28);
            this.InfoLabel2.TabIndex = 8;
            this.InfoLabel2.Text = "You are voting to:";
            // 
            // ChoosedCandidatLabel
            // 
            this.ChoosedCandidatLabel.AutoSize = true;
            this.ChoosedCandidatLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoosedCandidatLabel.Location = new System.Drawing.Point(657, 522);
            this.ChoosedCandidatLabel.Name = "ChoosedCandidatLabel";
            this.ChoosedCandidatLabel.Size = new System.Drawing.Size(203, 28);
            this.ChoosedCandidatLabel.TabIndex = 9;
            this.ChoosedCandidatLabel.Text = "SomeCandidateName";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.ResultLabel.Location = new System.Drawing.Point(441, 601);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(113, 28);
            this.ResultLabel.TabIndex = 10;
            this.ResultLabel.Text = "Some value";
            // 
            // AmountCandidateslabel
            // 
            this.AmountCandidateslabel.AutoSize = true;
            this.AmountCandidateslabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountCandidateslabel.Location = new System.Drawing.Point(255, 30);
            this.AmountCandidateslabel.Name = "AmountCandidateslabel";
            this.AmountCandidateslabel.Size = new System.Drawing.Size(183, 21);
            this.AmountCandidateslabel.TabIndex = 11;
            this.AmountCandidateslabel.Text = "You can add x candidates";
            // 
            // AddCandidateButton
            // 
            this.AddCandidateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCandidateButton.Location = new System.Drawing.Point(288, 133);
            this.AddCandidateButton.Name = "AddCandidateButton";
            this.AddCandidateButton.Size = new System.Drawing.Size(87, 37);
            this.AddCandidateButton.TabIndex = 13;
            this.AddCandidateButton.Text = "Add";
            this.AddCandidateButton.UseVisualStyleBackColor = true;
            this.AddCandidateButton.Click += new System.EventHandler(this.AddCandidateButton_Click);
            // 
            // VoteButton
            // 
            this.VoteButton.Location = new System.Drawing.Point(491, 564);
            this.VoteButton.Name = "VoteButton";
            this.VoteButton.Size = new System.Drawing.Size(99, 34);
            this.VoteButton.TabIndex = 14;
            this.VoteButton.Text = "Vote";
            this.VoteButton.UseVisualStyleBackColor = true;
            this.VoteButton.Click += new System.EventHandler(this.VoteButton_Click);
            // 
            // VotersSearchTextBox
            // 
            this.VotersSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VotersSearchTextBox.Location = new System.Drawing.Point(6, 33);
            this.VotersSearchTextBox.Name = "VotersSearchTextBox";
            this.VotersSearchTextBox.Size = new System.Drawing.Size(205, 29);
            this.VotersSearchTextBox.TabIndex = 15;
            this.VotersSearchTextBox.Text = "Search";
            this.VotersSearchTextBox.Click += new System.EventHandler(this.VotersSearchTextBox_Click);
            this.VotersSearchTextBox.TextChanged += new System.EventHandler(this.VotersSearchTextBox_TextChanged);
            // 
            // CandidatesSearchTextBox
            // 
            this.CandidatesSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CandidatesSearchTextBox.Location = new System.Drawing.Point(6, 33);
            this.CandidatesSearchTextBox.Name = "CandidatesSearchTextBox";
            this.CandidatesSearchTextBox.Size = new System.Drawing.Size(205, 29);
            this.CandidatesSearchTextBox.TabIndex = 16;
            this.CandidatesSearchTextBox.Text = "Search";
            this.CandidatesSearchTextBox.Click += new System.EventHandler(this.CandidatesSearchTextBox_Click);
            this.CandidatesSearchTextBox.TextChanged += new System.EventHandler(this.CandidatesSearchTextBox_TextChanged);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(139, 7);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 41);
            this.LogOutButton.TabIndex = 17;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.Location = new System.Drawing.Point(220, 7);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(75, 41);
            this.DeleteAccountButton.TabIndex = 18;
            this.DeleteAccountButton.Text = "Delete account";
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // VotersGroupBox
            // 
            this.VotersGroupBox.Controls.Add(this.VotersCurrentPageTextBox);
            this.VotersGroupBox.Controls.Add(this.VotersTotalPagesLabel);
            this.VotersGroupBox.Controls.Add(this.VotersPagesLabel);
            this.VotersGroupBox.Controls.Add(this.VotersResultLabel);
            this.VotersGroupBox.Controls.Add(this.VotersTotalResultLabel);
            this.VotersGroupBox.Controls.Add(this.VotersSearchTextBox);
            this.VotersGroupBox.Controls.Add(this.VotersDataGridView);
            this.VotersGroupBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VotersGroupBox.Location = new System.Drawing.Point(12, 54);
            this.VotersGroupBox.Name = "VotersGroupBox";
            this.VotersGroupBox.Size = new System.Drawing.Size(423, 400);
            this.VotersGroupBox.TabIndex = 20;
            this.VotersGroupBox.TabStop = false;
            this.VotersGroupBox.Text = "Voters";
            // 
            // VotersCurrentPageTextBox
            // 
            this.VotersCurrentPageTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VotersCurrentPageTextBox.Location = new System.Drawing.Point(257, 358);
            this.VotersCurrentPageTextBox.Name = "VotersCurrentPageTextBox";
            this.VotersCurrentPageTextBox.Size = new System.Drawing.Size(26, 23);
            this.VotersCurrentPageTextBox.TabIndex = 20;
            this.VotersCurrentPageTextBox.Text = "1";
            this.VotersCurrentPageTextBox.TextChanged += new System.EventHandler(this.VotersCurrentPageTextBox_TextChanged);
            // 
            // VotersTotalPagesLabel
            // 
            this.VotersTotalPagesLabel.AutoSize = true;
            this.VotersTotalPagesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VotersTotalPagesLabel.Location = new System.Drawing.Point(289, 361);
            this.VotersTotalPagesLabel.Name = "VotersTotalPagesLabel";
            this.VotersTotalPagesLabel.Size = new System.Drawing.Size(18, 15);
            this.VotersTotalPagesLabel.TabIndex = 19;
            this.VotersTotalPagesLabel.Text = "/1";
            // 
            // VotersPagesLabel
            // 
            this.VotersPagesLabel.AutoSize = true;
            this.VotersPagesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VotersPagesLabel.Location = new System.Drawing.Point(257, 335);
            this.VotersPagesLabel.Name = "VotersPagesLabel";
            this.VotersPagesLabel.Size = new System.Drawing.Size(38, 15);
            this.VotersPagesLabel.TabIndex = 18;
            this.VotersPagesLabel.Text = "Pages";
            // 
            // VotersResultLabel
            // 
            this.VotersResultLabel.AutoSize = true;
            this.VotersResultLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VotersResultLabel.Location = new System.Drawing.Point(371, 358);
            this.VotersResultLabel.Name = "VotersResultLabel";
            this.VotersResultLabel.Size = new System.Drawing.Size(13, 15);
            this.VotersResultLabel.TabIndex = 17;
            this.VotersResultLabel.Text = "0";
            // 
            // VotersTotalResultLabel
            // 
            this.VotersTotalResultLabel.AutoSize = true;
            this.VotersTotalResultLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VotersTotalResultLabel.Location = new System.Drawing.Point(345, 335);
            this.VotersTotalResultLabel.Name = "VotersTotalResultLabel";
            this.VotersTotalResultLabel.Size = new System.Drawing.Size(72, 15);
            this.VotersTotalResultLabel.TabIndex = 16;
            this.VotersTotalResultLabel.Text = "Total Results";
            // 
            // CandidatesGroupBox
            // 
            this.CandidatesGroupBox.Controls.Add(this.InfoLabel4);
            this.CandidatesGroupBox.Controls.Add(this.CandidateNameTextBox);
            this.CandidatesGroupBox.Controls.Add(this.CandidatesTotalPagesLabel);
            this.CandidatesGroupBox.Controls.Add(this.CandidatesCurrentPageTextBox);
            this.CandidatesGroupBox.Controls.Add(this.CandidatesPagesLabel);
            this.CandidatesGroupBox.Controls.Add(this.CandidatesResultLabel);
            this.CandidatesGroupBox.Controls.Add(this.CandidatesTotalResultsLabel);
            this.CandidatesGroupBox.Controls.Add(this.CandidatesDataGridView);
            this.CandidatesGroupBox.Controls.Add(this.CandidatesSearchTextBox);
            this.CandidatesGroupBox.Controls.Add(this.AddCandidateButton);
            this.CandidatesGroupBox.Controls.Add(this.AmountCandidateslabel);
            this.CandidatesGroupBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CandidatesGroupBox.Location = new System.Drawing.Point(485, 54);
            this.CandidatesGroupBox.Name = "CandidatesGroupBox";
            this.CandidatesGroupBox.Size = new System.Drawing.Size(444, 400);
            this.CandidatesGroupBox.TabIndex = 21;
            this.CandidatesGroupBox.TabStop = false;
            this.CandidatesGroupBox.Text = "Candidates";
            // 
            // InfoLabel4
            // 
            this.InfoLabel4.AutoSize = true;
            this.InfoLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel4.Location = new System.Drawing.Point(287, 63);
            this.InfoLabel4.Name = "InfoLabel4";
            this.InfoLabel4.Size = new System.Drawing.Size(122, 15);
            this.InfoLabel4.TabIndex = 27;
            this.InfoLabel4.Text = "Enter candidate name";
            // 
            // CandidateNameTextBox
            // 
            this.CandidateNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CandidateNameTextBox.Location = new System.Drawing.Point(288, 90);
            this.CandidateNameTextBox.Name = "CandidateNameTextBox";
            this.CandidateNameTextBox.Size = new System.Drawing.Size(100, 29);
            this.CandidateNameTextBox.TabIndex = 26;
            // 
            // CandidatesTotalPagesLabel
            // 
            this.CandidatesTotalPagesLabel.AutoSize = true;
            this.CandidatesTotalPagesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CandidatesTotalPagesLabel.Location = new System.Drawing.Point(301, 366);
            this.CandidatesTotalPagesLabel.Name = "CandidatesTotalPagesLabel";
            this.CandidatesTotalPagesLabel.Size = new System.Drawing.Size(18, 15);
            this.CandidatesTotalPagesLabel.TabIndex = 25;
            this.CandidatesTotalPagesLabel.Text = "/1";
            // 
            // CandidatesCurrentPageTextBox
            // 
            this.CandidatesCurrentPageTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CandidatesCurrentPageTextBox.Location = new System.Drawing.Point(269, 363);
            this.CandidatesCurrentPageTextBox.Name = "CandidatesCurrentPageTextBox";
            this.CandidatesCurrentPageTextBox.Size = new System.Drawing.Size(26, 23);
            this.CandidatesCurrentPageTextBox.TabIndex = 24;
            this.CandidatesCurrentPageTextBox.Text = "1";
            this.CandidatesCurrentPageTextBox.TextChanged += new System.EventHandler(this.CandidatesCurrentPageTextBox_TextChanged);
            // 
            // CandidatesPagesLabel
            // 
            this.CandidatesPagesLabel.AutoSize = true;
            this.CandidatesPagesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CandidatesPagesLabel.Location = new System.Drawing.Point(269, 335);
            this.CandidatesPagesLabel.Name = "CandidatesPagesLabel";
            this.CandidatesPagesLabel.Size = new System.Drawing.Size(38, 15);
            this.CandidatesPagesLabel.TabIndex = 23;
            this.CandidatesPagesLabel.Text = "Pages";
            // 
            // CandidatesResultLabel
            // 
            this.CandidatesResultLabel.AutoSize = true;
            this.CandidatesResultLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CandidatesResultLabel.Location = new System.Drawing.Point(396, 366);
            this.CandidatesResultLabel.Name = "CandidatesResultLabel";
            this.CandidatesResultLabel.Size = new System.Drawing.Size(13, 15);
            this.CandidatesResultLabel.TabIndex = 22;
            this.CandidatesResultLabel.Text = "0";
            // 
            // CandidatesTotalResultsLabel
            // 
            this.CandidatesTotalResultsLabel.AutoSize = true;
            this.CandidatesTotalResultsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CandidatesTotalResultsLabel.Location = new System.Drawing.Point(366, 335);
            this.CandidatesTotalResultsLabel.Name = "CandidatesTotalResultsLabel";
            this.CandidatesTotalResultsLabel.Size = new System.Drawing.Size(72, 15);
            this.CandidatesTotalResultsLabel.TabIndex = 21;
            this.CandidatesTotalResultsLabel.Text = "Total Results";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ONWELO_VOTE_APP.Properties.Resources.Vote;
            this.pictureBox1.Location = new System.Drawing.Point(12, 457);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // EditAccountButton
            // 
            this.EditAccountButton.Location = new System.Drawing.Point(301, 7);
            this.EditAccountButton.Name = "EditAccountButton";
            this.EditAccountButton.Size = new System.Drawing.Size(75, 41);
            this.EditAccountButton.TabIndex = 23;
            this.EditAccountButton.Text = "Edit Account";
            this.EditAccountButton.UseVisualStyleBackColor = true;
            this.EditAccountButton.Click += new System.EventHandler(this.EditAccountButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 641);
            this.Controls.Add(this.EditAccountButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CandidatesGroupBox);
            this.Controls.Add(this.VotersGroupBox);
            this.Controls.Add(this.DeleteAccountButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.VoteButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ChoosedCandidatLabel);
            this.Controls.Add(this.InfoLabel2);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.InfoLabel3);
            this.Controls.Add(this.UserLable);
            this.Name = "MainWindow";
            this.Text = "Voting app";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VotersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatesDataGridView)).EndInit();
            this.VotersGroupBox.ResumeLayout(false);
            this.VotersGroupBox.PerformLayout();
            this.CandidatesGroupBox.ResumeLayout(false);
            this.CandidatesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource voterBindingSource;
        private BindingSource candidateBindingSource;
        private DataGridView VotersDataGridView;
        private DataGridView CandidatesDataGridView;
        private Label UserLable;
        private Label InfoLabel3;
        private Label InfoLabel;
        private Label InfoLabel2;
        private Label ChoosedCandidatLabel;
        private Label ResultLabel;
        private Label AmountCandidateslabel;
        private Button AddCandidateButton;
        private Button VoteButton;
        private TextBox VotersSearchTextBox;
        private TextBox CandidatesSearchTextBox;
        private Button LogOutButton;
        private Button DeleteAccountButton;
        private GroupBox VotersGroupBox;
        private GroupBox CandidatesGroupBox;
        private PictureBox pictureBox1;
        private TextBox VotersCurrentPageTextBox;
        private Label VotersTotalPagesLabel;
        private Label VotersPagesLabel;
        private Label VotersResultLabel;
        private Label VotersTotalResultLabel;
        private Label CandidatesTotalPagesLabel;
        private TextBox CandidatesCurrentPageTextBox;
        private Label CandidatesPagesLabel;
        private Label CandidatesResultLabel;
        private Label CandidatesTotalResultsLabel;
        private Button EditAccountButton;
        private Label InfoLabel4;
        private TextBox CandidateNameTextBox;
    }
}