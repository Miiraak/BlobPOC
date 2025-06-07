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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            comboBoxLang = new ComboBox();
            comboBoxExt = new ComboBox();
            checkBoxAutoLog = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(133, 126);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Langue :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "AutoLog :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 69);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 5;
            label4.Text = "Base export extension :";
            // 
            // comboBoxLang
            // 
            comboBoxLang.FormattingEnabled = true;
            comboBoxLang.Items.AddRange(new object[] { "en-US", "fr-FR", "it-IT" });
            comboBoxLang.Location = new Point(12, 27);
            comboBoxLang.Name = "comboBoxLang";
            comboBoxLang.Size = new Size(196, 23);
            comboBoxLang.TabIndex = 7;
            // 
            // comboBoxExt
            // 
            comboBoxExt.FormattingEnabled = true;
            comboBoxExt.Items.AddRange(new object[] { ".json", ".zip", ".xml", ".txt", ".log" });
            comboBoxExt.Location = new Point(12, 87);
            comboBoxExt.Name = "comboBoxExt";
            comboBoxExt.Size = new Size(196, 23);
            comboBoxExt.TabIndex = 9;
            // 
            // checkBoxAutoLog
            // 
            checkBoxAutoLog.AutoSize = true;
            checkBoxAutoLog.Location = new Point(77, 131);
            checkBoxAutoLog.Name = "checkBoxAutoLog";
            checkBoxAutoLog.Size = new Size(15, 14);
            checkBoxAutoLog.TabIndex = 10;
            checkBoxAutoLog.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 160);
            Controls.Add(checkBoxAutoLog);
            Controls.Add(comboBoxExt);
            Controls.Add(comboBoxLang);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "BlobPOC";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox comboBoxLang;
        private ComboBox comboBoxExt;
        private CheckBox checkBoxAutoLog;
    }
}
