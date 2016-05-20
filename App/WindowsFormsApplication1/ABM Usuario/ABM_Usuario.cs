using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.ABM_Usuario
{
    public partial class ABM_Usuario : Form
    {
        public ABM_Usuario()
        {
            InitializeComponent();
        }

        private void ABM_Usuario_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            this.grp_ABM.Visible = false;
            this.grp_Alta.Visible = true;
        }


    }
}
