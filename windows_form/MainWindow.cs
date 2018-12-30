using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShowControls_Click(object sender, EventArgs e)
        {
            string ctrlInfo = "";
            foreach (Control c in this.Controls)
            {
                ctrlInfo += string.Format("Елемент: {0}\n",
                    c.ToString());
            }
            MessageBox.Show(ctrlInfo,
                "Елементи керування, поміщені в форму");
        }
    }
}
