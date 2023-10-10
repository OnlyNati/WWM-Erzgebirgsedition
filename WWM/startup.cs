using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWM
{
    public partial class startup : Form
    {
        public startup()
        {
            InitializeComponent();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            wwm wwm = new wwm();    
            wwm.Show();
            wwm.Focus();
        }

        private void bt_import_Click(object sender, EventArgs e)
        {
            import import = new import();
            import.Show();
        }

        private void bt_end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_help_Click(object sender, EventArgs e)
        {
            hilfe hilfe = new hilfe();
            hilfe.Show();
        }
    }
}
