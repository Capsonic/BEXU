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

        public frmMain()
        {
            InitializeComponent();
            _sp = new SP();
            #region Tab Search Ctor
            _fileItemListSearch = new BindingList<FileItem>();
            _bindingListViewSearch = new BindingListView<FileItem>(_fileItemListSearch);
            dataGrid.DataSource = _bindingListViewSearch;
            updateFilterLabelSearch();
            _fileItemListSearch.ListChanged += _fileItemListSearch_ListChanged;
            #endregion

            #region Tab Selection Ctor
            _fileItemListSelection = new BindingList<FileItem>();
            _bindingListViewSelection = new BindingListView<FileItem>(_fileItemListSelection);
            dataGridSelection.DataSource = _bindingListViewSelection;
            updateFilterLabelSelection();
            _fileItemListSelection.ListChanged += _fileItemListSelection_ListChanged;

            _availableProcesses = new BindingList<IExcelUpdateProcess>();
            _bindingListView_AvailableProcesses = new BindingListView<IExcelUpdateProcess>(_availableProcesses);
            listAvailableProcesses.DataSource = _bindingListView_AvailableProcesses;

            _processesToPerform = new BindingList<IExcelUpdateProcess>();
            _bindingListView_ProcessesToPerform = new BindingListView<IExcelUpdateProcess>(_processesToPerform);
            listProcessesToPerform.DataSource = _bindingListView_ProcessesToPerform;


            _availableProcesses.Add(new frmCompareAndSetVersion());

            #endregion
        }

        #region Tab Login
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_sp.Login(txtURL.Text, txtUserName.Text, txtPassword.Text))
                {
                    tabs.SelectedTab = tabSearch;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Tab Search
        private BindingList<FileItem> _fileItemListSearch;
        private BindingListView<FileItem> _bindingListViewSearch;
        private long _totalFileItemsSearch = 0;
        private long _totalShowingFileItemsSearch = 0;

        private void _fileItemListSearch_ListChanged(object sender, ListChangedEventArgs e)
        {
            updateFilterLabelSearch();
        }

        private void btnClearListSearch_Click(object sender, EventArgs e)
        {
            _fileItemListSearch.Clear();
            updateFilterLabelSearch();
        }

        private void updateFilterLabelSearch()
        {
            _totalFileItemsSearch = _fileItemListSearch.Count;
            _totalShowingFileItemsSearch = _bindingListViewSearch.Count;
            lblFilterLabelSearch.Text = "Showing " + _totalShowingFileItemsSearch + " entries from " + _totalFileItemsSearch;
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
                    _fileItemListSearch.Clear();

                    progressBar.Style = ProgressBarStyle.Marquee;

                    await _sp.readWebs(_fileItemListSearch, txtFolderLike.Text, txtFileLike.Text);

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
        private void txtSearchOverResult_TextChanged(object sender, EventArgs e)
        {
            string[] arrCriteria = txtSearchOverResult.Text.Trim().ToLower().Split(' ');
            _bindingListViewSearch.ApplyFilter(delegate (FileItem file)
            {
                return arrCriteria.All(keyword => file.FileName.ToLower().Contains(keyword));
            });
            updateFilterLabelSearch();

            //bindingListView.Filter = "FileName LIKE '%" + txtSearchOverResult.Text + "%' OR " +
            //                        "FolderName LIKE '%" + txtSearchOverResult.Text + "%'";
            //dataGrid.Refresh();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            resetFileItemListSelection();
            tabs.SelectedTab = tabProcess;
        }
        #endregion

        #region Tab Process

        #region Datagrid
        private BindingList<FileItem> _fileItemListSelection;
        private BindingListView<FileItem> _bindingListViewSelection;
        private long _totalFileItemsSelection = 0;
        private long _totalShowingFileItemsSelection = 0;

        private void resetFileItemListSelection()
        {
            _fileItemListSelection.Clear();
            foreach (var item in _fileItemListSearch)
            {
                if (item.IsSelected)
                {
                    _fileItemListSelection.Add(item.Clone());
                }
            }
        }
        private void _fileItemListSelection_ListChanged(object sender, ListChangedEventArgs e)
        {
            updateFilterLabelSelection();
        }
        private void updateFilterLabelSelection()
        {
            _totalFileItemsSelection = _fileItemListSelection.Count;
            _totalShowingFileItemsSelection = _bindingListViewSelection.Count;
            lblFilterLabelSelection.Text = "Showing " + _totalShowingFileItemsSelection + " entries from " + _totalFileItemsSelection;
        }
        private void btnClearListSelection_Click(object sender, EventArgs e)
        {
            resetFileItemListSelection();
            updateFilterLabelSearch();
        }

        private void txtSearchOverResultSelection_TextChanged(object sender, EventArgs e)
        {
            string[] arrCriteria = txtSearchOverResultSelection.Text.Trim().ToLower().Split(' ');
            _bindingListViewSelection.ApplyFilter(delegate (FileItem file)
            {
                return arrCriteria.All(keyword => file.FileName.ToLower().Contains(keyword));
            });
            updateFilterLabelSelection();
        }
        #endregion

        #region Processes
        private BindingList<IExcelUpdateProcess> _availableProcesses;
        private BindingListView<IExcelUpdateProcess> _bindingListView_AvailableProcesses;

        private BindingList<IExcelUpdateProcess> _processesToPerform;
        private BindingListView<IExcelUpdateProcess> _bindingListView_ProcessesToPerform;

        private void btnAddProcessToPerform_Click(object sender, EventArgs e)
        {
            if (listAvailableProcesses.SelectedIndex > -1)
            {
                if (_availableProcesses.ElementAt(listAvailableProcesses.SelectedIndex).Configure())
                {
                    _processesToPerform.Add(_availableProcesses.ElementAt(listAvailableProcesses.SelectedIndex));
                    _availableProcesses.RemoveAt(listAvailableProcesses.SelectedIndex);
                }
            }
        }

        private void btnRemoveProcessToPerform_Click(object sender, EventArgs e)
        {
            if (listProcessesToPerform.SelectedIndex > -1)
            {
                _availableProcesses.Add(_processesToPerform.ElementAt(listProcessesToPerform.SelectedIndex));
                _processesToPerform.RemoveAt(listProcessesToPerform.SelectedIndex);
            }
        }

        private void listProcessesToPerform_DoubleClick(object sender, EventArgs e)
        {
            _processesToPerform.ElementAt(listProcessesToPerform.SelectedIndex).Configure();
        }

        #endregion

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (_fileItemListSelection.Count > 0)
                {
                    if (_processesToPerform.Count > 0)
                    {
                        _sp.Process(_fileItemListSelection, _processesToPerform);
                        dataGridSelection.Refresh();
                        MessageBox.Show("Process completed.");
                    }
                    else
                    {
                        MessageBox.Show("No processes to perform.");
                    }
                }
                else
                {
                    MessageBox.Show("No files to process.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion
    }
}
