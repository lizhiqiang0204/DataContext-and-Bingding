using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string label = "我的标签";
        public string myLabel
        {
            get { return label; }
            set { label = value; }
        }
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = this;
            DataContext = new ClassA();
        }
    }
}
