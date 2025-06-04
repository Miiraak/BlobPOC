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
            blobData = BlobStore.Read();

            // set the text box with the value from blobData if it exists
            if (blobData.TryGetValue("lang", out string langValue))
                comboBoxLang.Text = langValue;
            else
                comboBoxLang.Text = "en-US"; // default value

            if (blobData.TryGetValue("ext", out string extValue))
                comboBoxExt.Text = extValue;
            else
                comboBoxExt.Text = ".log"; // default value

            if (blobData.TryGetValue("autolog", out string autoLogValue))
            {
                if (autoLogValue != "_____")
                    checkBoxAutoLog.Checked = bool.Parse(autoLogValue);
            }
            else
            {
                checkBoxAutoLog.Checked = false; // default value
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blobData["lang"] = comboBoxLang.Text;
            blobData["ext"] = comboBoxExt.Text;
            blobData["autolog"] = checkBoxAutoLog.Checked.ToString();
            SelfUpdater.UpdateAndRestart(blobData);
        }
    }
}
