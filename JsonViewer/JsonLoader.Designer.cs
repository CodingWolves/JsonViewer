namespace JsonViewer
{
    partial class JsonLoader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonLoader));
            this.LoaderButton = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePathDialogButton = new System.Windows.Forms.Button();
            this.FilePathDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // LoaderButton
            // 
            this.LoaderButton.Location = new System.Drawing.Point(124, 40);
            this.LoaderButton.Name = "LoaderButton";
            this.LoaderButton.Size = new System.Drawing.Size(135, 47);
            this.LoaderButton.TabIndex = 0;
            this.LoaderButton.Text = "Load";
            this.LoaderButton.UseVisualStyleBackColor = true;
            this.LoaderButton.Click += new System.EventHandler(this.LodaerButton_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(66, 14);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(162, 20);
            this.FilePathTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Path";
            // 
            // FilePathDialogButton
            // 
            this.FilePathDialogButton.Location = new System.Drawing.Point(234, 12);
            this.FilePathDialogButton.Name = "FilePathDialogButton";
            this.FilePathDialogButton.Size = new System.Drawing.Size(25, 23);
            this.FilePathDialogButton.TabIndex = 0;
            this.FilePathDialogButton.Text = "...";
            this.FilePathDialogButton.UseVisualStyleBackColor = true;
            this.FilePathDialogButton.Click += new System.EventHandler(this.FilePathDialogButton_Click);
            // 
            // FilePathDialog
            // 
            this.FilePathDialog.FileName = "*.json";
            this.FilePathDialog.Filter = "Json Files|*.json";
            // 
            // JsonLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 99);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.FilePathDialogButton);
            this.Controls.Add(this.LoaderButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JsonLoader";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JsonLoader_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoaderButton;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FilePathDialogButton;
        private System.Windows.Forms.OpenFileDialog FilePathDialog;
    }
}

