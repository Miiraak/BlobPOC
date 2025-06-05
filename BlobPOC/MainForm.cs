namespace BlobPOC
{
    public partial class MainForm : Form
    {
        private static Dictionary<string, string> blobData = new Dictionary<string, string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            comboBoxLang.Text = AppSettings.Get("lang");
            comboBoxExt.Text = AppSettings.Get("ext");
            checkBoxAutoLog.Checked = AppSettings.GetBool("autolog");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppSettings.Set("lang", comboBoxLang.Text);
            AppSettings.Set("ext", comboBoxExt.Text);
            AppSettings.Set("autolog", checkBoxAutoLog.Checked);
            AppSettings.Save();
        }
    }
}
