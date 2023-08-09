using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;

namespace ZerothV1
{
    public partial class Form1 : KryptonForm /// change to kyrpton
    {
        bool sidebarExpand;

        public Form1()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                 
                    panelTop.Size = new Size(1228,115);
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }

            }

            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    
                  
                    panelTop.Size = new Size(998, 115);
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }



            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
