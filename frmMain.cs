using Equin.ApplicationFramework;
using SPClient;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static SPClient.SP;

namespace BEXU
{
    public partial class frmMain : Form
    {
        private SP _sp;
        private BindingList<FileItem> _fileItemList;
        private BindingListView<FileItem> _bindingListView;
        private long _totalFileItems = 0;
        private long _totalShowingFileItems = 0;

        public frmMain()
        {
            InitializeComponent();
            _sp = new SP();
            _fileItemList = new BindingList<FileItem>();
            _bindingListView = new BindingListView<FileItem>(_fileItemList);
            dataGrid.DataSource = _bindingListView;
            updateFilterLabel();
            _fileItemList.ListChanged += _fileItemList_ListChanged;
        }

        private void _fileItemList_ListChanged(object sender, ListChangedEventArgs e)
        {
            updateFilterLabel();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            _fileItemList.Clear();
            updateFilterLabel();
        }

        private void updateFilterLabel()
        {
            _totalFileItems = _fileItemList.Count;
            _totalShowingFileItems = _bindingListView.Count;
            lblFilterLabel.Text = "Showing " + _totalShowingFileItems + " entries from " + _totalFileItems;
        }

        private bool searchIsInterrupted = false;
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Text == "Search")
            {
                try
                {
                    btnSearch.Text = "Stop";
                    searchIsInterrupted = false;
                    _fileItemList.Clear();

                    progressBar.Style = ProgressBarStyle.Marquee;

                    await _sp.readWebs(_fileItemList, txtFolderLike.Text, txtFileLike.Text);

                    if (!searchIsInterrupted)
                    {
                        progressBar.Style = ProgressBarStyle.Blocks;
                        MessageBox.Show("Search completed.");
                        btnSearch.Text = "Search";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                btnSearch.Text = "Search";
                _sp.ContinueSearching = false;
                progressBar.Style = ProgressBarStyle.Blocks;
                searchIsInterrupted = true;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                _sp.Login(txtURL.Text, txtUserName.Text, txtPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtSearchOverResult_TextChanged(object sender, EventArgs e)
        {
            string[] arrCriteria = txtSearchOverResult.Text.Trim().ToLower().Split(' ');
            _bindingListView.ApplyFilter(delegate (FileItem file)
            {
                return arrCriteria.All(keyword => file.FileName.ToLower().Contains(keyword));
            });
            updateFilterLabel();

            //bindingListView.Filter = "FileName LIKE '%" + txtSearchOverResult.Text + "%' OR " +
            //                        "FolderName LIKE '%" + txtSearchOverResult.Text + "%'";
            //dataGrid.Refresh();
        }
    }
}
