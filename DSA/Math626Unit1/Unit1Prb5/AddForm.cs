using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1Prb5
{


    public partial class addForm : Form
    {
        public int returnJobNum { get; set; }
        public string returnUName { get; set; }
        public addForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            returnJobNum = Int32.Parse(jobNumTextBox.Text);
            returnUName = userNameTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
