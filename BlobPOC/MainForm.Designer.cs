namespace BlobPOC
{
    partial class MainForm
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
            ButtonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            checkBoxBool = new CheckBox();
            ButtonClear = new Button();
            ButtonDelete = new Button();
            textBoxInt = new TextBox();
            textBoxString = new TextBox();
            progressBarInt = new ProgressBar();
            SuspendLayout();
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(15, 174);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(219, 23);
            ButtonSave.TabIndex = 0;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "String :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 139);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Bool :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 59);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 5;
            label4.Text = "Int :";
            // 
            // checkBoxBool
            // 
            checkBoxBool.AutoSize = true;
            checkBoxBool.Location = new Point(116, 139);
            checkBoxBool.Name = "checkBoxBool";
            checkBoxBool.Size = new Size(15, 14);
            checkBoxBool.TabIndex = 10;
            checkBoxBool.UseVisualStyleBackColor = true;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(15, 206);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(106, 23);
            ButtonClear.TabIndex = 11;
            ButtonClear.Text = "Clear Blob";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(127, 206);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(107, 23);
            ButtonDelete.TabIndex = 12;
            ButtonDelete.Text = "Delete Blob";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // textBoxInt
            // 
            textBoxInt.Location = new Point(12, 77);
            textBoxInt.Name = "textBoxInt";
            textBoxInt.Size = new Size(222, 23);
            textBoxInt.TabIndex = 13;
            // 
            // textBoxString
            // 
            textBoxString.Location = new Point(12, 27);
            textBoxString.Name = "textBoxString";
            textBoxString.Size = new Size(222, 23);
            textBoxString.TabIndex = 14;
            // 
            // progressBarInt
            // 
            progressBarInt.Location = new Point(12, 106);
            progressBarInt.Name = "progressBarInt";
            progressBarInt.Size = new Size(222, 23);
            progressBarInt.TabIndex = 15;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 241);
            Controls.Add(progressBarInt);
            Controls.Add(textBoxString);
            Controls.Add(textBoxInt);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonClear);
            Controls.Add(checkBoxBool);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonSave);
            Name = "MainForm";
            Text = "BlobPOC";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonSave;
        private Label label1;
        private Label label2;
        private Label label4;
        private CheckBox checkBoxBool;
        private Button ButtonClear;
        private Button ButtonDelete;
        private TextBox textBoxInt;
        private TextBox textBoxString;
        private ProgressBar progressBarInt;
    }
}
