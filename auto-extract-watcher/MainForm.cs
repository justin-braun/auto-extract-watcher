namespace auto_extract_watcher
{
    public partial class MainForm : Form
    {
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

            // Check if there is a folder value
            if(textWatchLocation.Text != "")
            {
                if(Directory.Exists(textWatchLocation.Text))
                {
                    Watcher watch = new Watcher();
                    watch.WatchLocation(textWatchLocation.Text);

                }
                else
                {
                    MessageBox.Show("Invalid directory specified.", "Invalid Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }
    }
}