using Panuon.WPF;
using Panuon.WPF.UI;
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

namespace ProjectManagement
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : WindowX
    {
        public MainWindow()
        {
            InitializeComponent();

            IcHeaders.ItemsSource = new ObservableCollectionX<HeaderItem>()
            {
                new HeaderItem(){ ImageSource = "/ProjectManagement;component/Resources/Images/header.jpg" },
                new HeaderItem(){ ImageSource = "/ProjectManagement;component/Resources/Images/header.jpg" },
                new HeaderItem(){ ImageSource = "/ProjectManagement;component/Resources/Images/header.jpg" },
                new HeaderItem(){ ImageSource = "/ProjectManagement;component/Resources/Images/header.jpg" },
                new HeaderItem(){ ExtendNumber = 15, },
            };

            IcActivity.ItemsSource = new ObservableCollectionX<ActivityItem>()
            {
                new ActivityItem(){ DisplayName = "Lily Anderson", HeadImage = "/ProjectManagement;component/Resources/Images/header.jpg", Time = DateTime.Now },
                new ActivityItem(){ DisplayName = "Lily Anderson", HeadImage = "/ProjectManagement;component/Resources/Images/header.jpg", Time = DateTime.Now },
            };
        }
    }

    public class HeaderItem 
        : NotifyPropertyChangedBase
    {
        public string ImageSource { get => _imageSource; set => Set(ref _imageSource, value); }
        private string _imageSource;

        public int ExtendNumber { get => _extendNumber; set => Set(ref _extendNumber, value); }
        private int _extendNumber;
    }

    public class ActivityItem
       : NotifyPropertyChangedBase
    {
        public string HeadImage { get => _headImage; set => Set(ref _headImage, value); }
        private string _headImage;

        public string DisplayName { get => _displayName; set => Set(ref _displayName, value); }
        private string _displayName;

        public DateTime Time { get => _time; set => Set(ref _time, value); }
        private DateTime _time;
    }
}
