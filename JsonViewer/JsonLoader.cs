using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (FilePathDialog.ShowDialog() == DialogResult.OK)
            {
                FilePathTextBox.Text = FilePathDialog.FileName;
            }
        }

        private void LodaerButton_Click(object sender, EventArgs e)
        {
            string filePath = FilePathTextBox.Text;
            if (File.Exists(filePath))
            {
                JsonView f = new JsonView(filePath);
                if (f.loadedSuccessfully)
                {
                    f.Show();
                }
                else
                {
                    MessageBox.Show("There was an error while loading json file.\n"+f.exception.Message);
                }
            }
            else
            {
                MessageBox.Show("File path is not valid");
            }
        }
    }
}
