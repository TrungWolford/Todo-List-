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
    public partial class TaskStep : UserControl
    {
        public event EventHandler OnStepRemove;
        public int stepID = 0;
        public string stepName = "";
        public bool isDone = false;
        public TaskStep()
        {
            InitializeComponent();
        }
        public TaskStep(int stepID, string stepName, bool isDone)
        {
            this.stepID = stepID;
            this.stepName = stepName;
            this.isDone = isDone;

            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            txt_StepName.Text = stepName;
            check_Done.Checked = isDone;
        }

        private void lbl_StepRemoveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa step này?", "Xóa step", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OnStepRemove?.Invoke(this, new EventArgs());
            }
        }

        private void check_Done_CheckedChanged(object sender, EventArgs e)
        {
            isDone = check_Done.Checked;
        }

        private void txt_StepName_TextChanged(object sender, EventArgs e)
        {
            stepName = txt_StepName.Text.Trim();
        }
    }
}
