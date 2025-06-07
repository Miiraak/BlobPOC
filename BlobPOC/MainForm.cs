using BlobPE;

namespace BlobPOC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Blob.RemoveUpdateFiles();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxLang.Text = Blob.Get("lang");
            comboBoxExt.Text = Blob.Get("ext");
            checkBoxAutoLog.Checked = Blob.GetBool("autolog");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Blob.Set("lang", comboBoxLang.Text);
            Blob.Set("ext", comboBoxExt.Text);
            Blob.Set("autolog", checkBoxAutoLog.Checked);
            Blob.Save();
        }
    }
}
