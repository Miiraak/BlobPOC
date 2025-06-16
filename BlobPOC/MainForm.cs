// // You need to ensure that the BlobPE library is referenced in your project.
using BlobPE;

namespace BlobPOC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Important: This line is necessary to ensure that the BlobPE clears any previous update files.
            // if it's not called, the BlobPE will let leftover files from previous updates in your temp folder, maybe a lot depending on how you develop your application.
            Blob.RemoveUpdateFiles();
        }

        // Create a event handler for the Load event of the form.
        // Inside this method, you can retrieve the values from the BlobPE library and set them to the respective controls/variables.
        // Important: Don't forget to call this method in the form's Load event.
        private void MainForm_Load(object sender, EventArgs e)
        {
            // This example assumes you need to retrieve a string, an integer, and a boolean value from the BlobPE library.
            textBoxString.Text = Blob.Get("string");
            textBoxInt.Text = Blob.Get("int");
            progressBarInt.Value = Blob.GetInt("int");
            checkBoxBool.Checked = Blob.GetBool("bool");
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Values stored in the Blob are not validated by BlobPE, so you need to validate them yourself before saving.
            // It's not mandatory to validate them, but it's a good practice to ensure the data integrity.
            if (textBoxString.Text.Length > 50)
            {
                MessageBox.Show("The string value exceeds the maximum length of 50 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Prevent saving if the string is too long.
            }
            if (progressBarInt.Value < 0 || progressBarInt.Value > 99)
            {
                MessageBox.Show("The integer value must be between 0 and 99.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Prevent saving if the integer is out of range.
            }

            Blob.Set("string", textBoxString.Text); // Save the string value.
            Blob.Set("int", textBoxInt.Text); // Save the integer value.
            Blob.Set("bool", checkBoxBool.Checked); // Save the boolean value.
            Blob.Save(); // Save all changes to the BlobPE library.
            // Save will also trigger the BlobPE to check for updates and apply them if available.
            // This will create a temporary file in the user's temp folder, which will modify the binary of your main application.
            // After modifying the binary, the BlobPE will automatically restart your application to apply the changes and remove the temporary file.
            // Note: The BlobPE library handles the update process internally, so you don't need to manage it manually.
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Blob.Reset(); // Clear all values in the BlobPE library.
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Blob.Delete(); // Delete the BlobPE library, removing all stored values. And the Blob flags.
        }
    }
}
