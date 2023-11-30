using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kvaser.CanLib;

namespace Wski_kvaser
{

    public partial class Form1 : Form
    {
        CanManager canManager;
        public Form1()
        {
             
            InitializeComponent();
        }
    }
}
