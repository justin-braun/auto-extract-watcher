namespace auto_extract_watcher
{
    public partial class MainForm : Form
    {
        bool WatcherStarted = false;
        Watcher? watcher;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var folder = BrowseDialog.ShowDialog();

            if (folder == DialogResult.OK)
            {
                textWatchLocation.Text = BrowseDialog.SelectedPath;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textWatchLocation.Text == "")
            {
                MessageBox.Show("Please specify a folder location to watch.", "Invalid Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (WatcherStarted == false)
            {
                // Start the watcher

                if (Directory.Exists(textWatchLocation.Text))
                {
                    // Instantiate watcher class and start watching
                    watcher = new Watcher(textWatchLocation.Text);
                    watcher.StartWatching();
                }
                else
                {
                    MessageBox.Show("Invalid directory specified.", "Invalid Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

                // Change button text & disable location/browse
                buttonOk.Text = "&Stop";
                buttonBrowse.Enabled = false;
                textWatchLocation.Enabled = false;

                // Update the property
                WatcherStarted = true;
            }
            else
            {
                // Stop the watcher
                
                if(watcher != null)
                {
                    // Stop watching
                    watcher.StopWatching();

                    // Change button text & enable location/browse
                    buttonOk.Text = "&Start";
                    buttonBrowse.Enabled = true;
                    textWatchLocation.Enabled = true;

                    // Update the property
                    WatcherStarted = false;
                }
                
            }
            


        }
    }
}