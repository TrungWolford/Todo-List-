using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Components
{
    public partial class AttachItem : UserControl
    {
        public event EventHandler OnRemoveFile;
        public event EventHandler OnDownloadFile;
        public string FileName { get; set; }
        public string FileFullPath { get; set; }
        public AttachItem(string fileName, string fileFullPath)
        {
            InitializeComponent();
            lbl_FileName.Text = fileName;
            FileName = fileName;
            FileFullPath = fileFullPath;
        }

        private void lbl_FileRemoveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa file?", "Xóa file", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OnRemoveFile?.Invoke(this, EventArgs.Empty);
            }
        }

        private void lbl_FileDownloadBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn tải file?", "Tải file", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OnDownloadFile?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
