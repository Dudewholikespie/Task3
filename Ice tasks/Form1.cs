using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ice_tasks
{
    public partial class frmDarGame : Form
    {
        Map name = new Map();
        public frmDarGame()
        {
            InitializeComponent();
        }

        private void frmDarGame_Load(object sender, EventArgs e)
        {
          
           
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {

        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lblMap.Text = "";
            lblMap.Text = name.MapDisplay();
        }
    }
}
