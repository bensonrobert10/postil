using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AL.PosTil.DAL;

namespace postil.Courier
{
    public partial class CourierHome : Form
    {
        public AL.PosTil.BL.Utils.PosTilStatus BLErrorStatus = new AL.PosTil.BL.Utils.PosTilStatus();
        public CourierHome()
        {
            InitializeComponent();
            LoadCountries();
        }

        void LoadCountries()
        {
            List<AL.PosTil.DAL.CountryDTO> lstCountry = AL.PosTil.BL.BLFactory.ManageParcel().LoadCountries(ref BLErrorStatus);
            if (BLErrorStatus.Status == AL.PosTil.BL.Utils.PosTilStatusType.Success)
            {
                cmbFrom.DataSource  = lstCountry;
                cmbFrom.ValueMember = "CountryName";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homeFrm = new Home();
            homeFrm.Show();
        }

       
    }
}
