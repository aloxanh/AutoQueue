using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfUserControll
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UcWpf : UserControl
    {
        public DataGrid lsviewKH;
        public Image imageLogo;
        public  bool showhide = false;
        public Button btnConfig_wpf;
        public Label lblUuTien, lblBinhThuong, lblBinhThuong_dong2,lblCaption,
            lblThuTuPhucVu, lblID_header, lblCoVanDV_header, lblSoKHCho_header,
            lblKHDangPhucVu_header, lblFooter1, lblFooter2, lblFooter3;
        public UcWpf()
        {
            InitializeComponent();
            lsviewKH = listviewKH;
            imageLogo = imgLogo;
            btnConfig_wpf = btnConfig;
            lblUuTien = this.wpf_lblUuTien;
            lblBinhThuong = this.wpf_lblBinhThuong;
            lblBinhThuong_dong2 = this.wpf_lblBinhThuong_dong2;
            lblCaption = this.wpf_lblCaption;//
            lblThuTuPhucVu = this.wpf_lblThuTuPhucVu;//
            lblID_header = this.wpf_lblID_header;//
            lblCoVanDV_header = this.wpf_lblCoVanDV_header;//
            lblSoKHCho_header = this.wpf_lblSoKHCho_header;//
            lblKHDangPhucVu_header = this.wpf_lblKHDangPhucVu_header;//
            lblFooter1 = this.wpf_lblFooter1;//
            lblFooter2 = this.wpf_lblFooter2;//
            lblFooter3 = this.wpf_lblFooter3;//


        }

        public void ShowHidePanel()
        {
            showhide = !showhide;
            btnConfig.Visibility = showhide? Visibility.Hidden: Visibility.Visible;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ShowHidePanel();
        }

        private void StackPanel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        //private void btnConfig_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    MessageBox.Show("ABCssss");
        //}
    }
}
