using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libray;

namespace Libray
{
    public partial class LibForm : Form
    {
        
        public LibForm()
        {
            InitializeComponent();
        }

        private void LibForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.LibUser' table. You can move, or remove it, as needed.
            this.libUserTableAdapter.Fill(this.libraryDataSet.LibUser);
            // TODO: This line of code loads data into the 'libDatabaseDataSet.LibUser' table. You can move, or remove it, as needed.
            this.lblDate.Text = DateTime.Today.ToLongDateString();

        }
    }
}
