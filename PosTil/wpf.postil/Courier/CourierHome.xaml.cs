using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpf.postil.Courier
{
    /// <summary>
    /// Interaction logic for CourierHome.xaml
    /// </summary>
    public partial class CourierHome : Window
    {
        public AL.PosTil.BL.Utils.PosTilStatus BLErrorStatus = new AL.PosTil.BL.Utils.PosTilStatus();
        public CourierHome()
        {
            InitializeComponent();
            LoadCountries();
            LoadSize();
        }

        void LoadSize()
        {
            cmbSize.Items.Add("Small");
            cmbSize.Items.Add("Medium");
            cmbSize.Items.Add("Large");
        }

        void LoadCountries()
        {
            List<AL.PosTil.DAL.CountryDTO> lstCountry = AL.PosTil.BL.BLFactory.ManageParcel().LoadCountries(ref BLErrorStatus);
            if (BLErrorStatus.Status == AL.PosTil.BL.Utils.PosTilStatusType.Success)
            {
                cmbFrom.ItemsSource  = lstCountry;
                cmbFrom.DisplayMemberPath = "CountryName";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Home homeFrm = new Home();
            homeFrm.Show();
            this.Close();
        }
 

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
