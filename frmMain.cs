using SPClient;
using System;
using System.Windows.Forms;

namespace BEXU
{
    public partial class frmMain : Form
    {
        private SP sp;
        
        public frmMain()
        {
            InitializeComponent();
            sp = new SP();
            dataGrid.DataSource = sp.FileItemList;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                sp.Login(txtURL.Text, txtUserName.Text, txtPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Text == "Search")
            {
                btnSearch.Text = "Stop";

                progressBar.Style = ProgressBarStyle.Marquee;

                await sp.readWebs();

                progressBar.Style = ProgressBarStyle.Blocks;
            }
            else
            {
                btnSearch.Text = "Search";
                sp.ContinueSearching = false;
                progressBar.Style = ProgressBarStyle.Blocks;
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            sp.FileItemList.Clear();
        }
    }
}
