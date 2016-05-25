using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visibilidad.ABM_Usuario
{
    public partial class ABM_Usuario_M : Form
    {

        public ABM_Usuario_M()
        {
            InitializeComponent();
        }

        private void ABM_Usuario_M_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
        }
    }
}
