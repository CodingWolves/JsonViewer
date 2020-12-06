using AppTools;
using JsonViewer.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace JsonViewer
{
    public partial class JsonLoader : Form
    {
        public JsonLoader()
        {
            InitializeComponent();
        }

        private void FilePathDialogButton_Click(object sender, EventArgs e)
        {
            if(FilePathDialog.ShowDialog() == DialogResult.OK)
            {
                FilePathTextBox.Text = FilePathDialog.FileName;
            }
        }

        private void LodaerButton_Click(object sender, EventArgs e)
        {
            string filePath = FilePathTextBox.Text;
            if(File.Exists(filePath))
            {
                JsonView f = new JsonView(filePath);
                if(f.loadedSuccessfully)
                {
                    ApplicationQueue.InstanceAddFormQueue(f);
                }
                else
                {
                    MessageBox.Show(Resources.ERROR_WHILE_LOADING + f.exception.Message);
                }
            }
            else
            {
                MessageBox.Show(Resources.PATH_NOT_VALID);
            }
        }
    }
}