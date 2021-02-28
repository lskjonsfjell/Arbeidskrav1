using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbeidskrav1
{
    public partial class Form1Password : Form
    {
        public Form1Password()
        {
            InitializeComponent();
            
        }
        public string Password { get; set; }

        

        private void buttonConfirmPassword_Click(object sender, EventArgs e)
        {
            this.Password = textBoxPassword.Text;
            Close();
            
        }
    }
}
