using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int id = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            string nazwa = pole.Text, sid;
            id++;
            sid = "b" + id.ToString();

            Button button = new Button
            {
                Name = sid,
                Content = nazwa,
                Height = 25,
                Width = 95,
                FontSize = 16,
                Foreground = new SolidColorBrush(Colors.White),
                Background = new SolidColorBrush(Colors.RoyalBlue),
                Margin = new Thickness(5, 5, 5, 5),
                HorizontalAlignment = HorizontalAlignment.Left,

            };
            ok.Children.Add(button);

            button.Click += new RoutedEventHandler(Button1_Click);

            /*
                 Button button = LogicalTreeHelper.FindLogicalNode(
                dependencyObject, "button1") as Button;
            if (button != null)
                button.Click += new RoutedEventHandler(button1_Click);
        }
    }
 
    private void button1_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Click!!!");
    }
             */






        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            Random random = new Random();

            aaa.Text= random.Next(1,1111).ToString();


        }
    }
}