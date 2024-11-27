using GUI.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Panel
{
    public partial class TaskInfo : Form
    {
        private List<string> filesToUpload = new List<string>();
        public TaskInfo()
        {
            InitializeComponent();
        }

        private void pnl_detailAddFile_Title_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        if (!filesToUpload.Contains(file))
                        {
                            filesToUpload.Add(file);
                            AttachItem item = new AttachItem(Path.GetFileName(file), file);
                            item.OnRemoveFile += Item_OnRemoveFile;
                            AddAttachmentItemToDisplay(item);
                        }
                    }
                }
            }
        }
        private void AddAttachmentItemToDisplay(AttachItem item)
        {
            pnl_FileItems.Controls.Add(item);
        }
        private void Item_OnRemoveFile(object sender, EventArgs e)
        {
            if (sender is AttachItem item)
            {
                pnl_FileItems.Controls.Remove(item);
                filesToUpload.Remove(item.FileFullPath);
                item.Dispose();
            }
        }
    }
}
