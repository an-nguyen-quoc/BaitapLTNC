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

namespace Tinhtoan2so
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, RoutedEventArgs e)
        {
            decimal sothunhat ;
            bool check_1 = decimal.TryParse(tbsothunhat.Text, out sothunhat);
            decimal sothuhai;
            bool check_2 = decimal.TryParse(tbsothuhai.Text, out sothuhai);
            decimal ketqua;
            if (check_1 && check_2)
            {
                ketqua = sothunhat + sothuhai;
                tbketqua.Text = ketqua.ToString();
                lbLoi.Visibility = Visibility.Hidden;
            }    
            else
            {
                lbLoi.Content = "Không thể thực hiện phép tính!";
                lbLoi.Visibility = Visibility.Visible;
            }    
        }



        private void btnTru_Click(object sender, RoutedEventArgs e)
        {
            decimal sothunhat;
            bool check_1 = decimal.TryParse(tbsothunhat.Text, out sothunhat);
            decimal sothuhai;
            bool check_2 = decimal.TryParse(tbsothuhai.Text, out sothuhai);
            decimal ketqua;
            if (check_1 && check_2)
            {
                ketqua = sothunhat - sothuhai;
                tbketqua.Text = ketqua.ToString();
                lbLoi.Visibility = Visibility.Hidden;
            }
            else
            {
                lbLoi.Content = "Không thể thực hiện phép tính!";
                lbLoi.Visibility = Visibility.Visible;
            }
        }

        private void btnNhan_Click(object sender, RoutedEventArgs e)
        {
            decimal sothunhat;
            bool check_1 = decimal.TryParse(tbsothunhat.Text, out sothunhat);
            decimal sothuhai;
            bool check_2 = decimal.TryParse(tbsothuhai.Text, out sothuhai);
            decimal ketqua;
            if (check_1 && check_2)
            {
                ketqua = sothunhat * sothuhai;
                tbketqua.Text = ketqua.ToString();
                lbLoi.Visibility = Visibility.Hidden;
            }
            else
            {
                lbLoi.Content = "Không thể thực hiện phép tính!";
                lbLoi.Visibility = Visibility.Visible;
            }
        }

        private void btnChia_Click(object sender, RoutedEventArgs e)
        {
            decimal sothunhat;
            bool check_1 = decimal.TryParse(tbsothunhat.Text, out sothunhat);
            decimal sothuhai;
            bool check_2 = decimal.TryParse(tbsothuhai.Text, out sothuhai);
            decimal ketqua;
            if (check_1 && check_2)
            {
                if (sothuhai != 0)
                {
                    ketqua = sothunhat / sothuhai;
                    tbketqua.Text = ketqua.ToString();
                    lbLoi.Visibility = Visibility.Hidden;
                }
                else
                {
                    lbLoi.Content = "Bạn chia cho 0";
                    lbLoi.Visibility = Visibility.Visible;
                }    
            }
            else
            {
                lbLoi.Content = "Không thể thực hiện phép tính!";
                lbLoi.Visibility = Visibility.Visible;
            }
        }

        private void btnTinhtiep_Click(object sender, RoutedEventArgs e)
        {
            tbsothunhat.Text = tbketqua.Text;
            tbsothuhai.Text = "";
            lbLoi.Visibility = Visibility.Hidden;
            tbsothuhai.Focus();
        }
    }
}
