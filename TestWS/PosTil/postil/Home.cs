using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace postil
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnCourier_Click(object sender, EventArgs e)
        {
            this.Close();
            Courier.CourierHome courierFrm = new Courier.CourierHome();
            courierFrm.Show();
        }
    }
}
