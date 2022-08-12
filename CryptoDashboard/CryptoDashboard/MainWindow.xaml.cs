using Panuon.WPF;
using Panuon.WPF.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace CryptoDashboard
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : WindowX
    {
        public MainWindow()
        {
            InitializeComponent();

            IcItems.ItemsSource = new ObservableCollection<Model1>()
            {
                new Model1()
                {
                    DisplayName = "Total Liquidity",
                    Value = "$ 2603805.5",
                    AccentBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ED6F86")),
                    Icon = "\ue941",
                },
                new Model1()
                {
                    DisplayName = "Daily Volume",
                    Value = "$ 260805.5",
                    AccentBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#13b9ff")),
                    Icon = "\ue943",
                },
                new Model1()
                {
                    DisplayName = "Liquidity",
                    Value = "26805.5",
                    AccentBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8751e3")),
                    Icon = "\ue945",
                },
                new Model1()
                {
                    DisplayName = "Total",
                    Value = "2605.5",
                    AccentBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b95684")),
                    Icon = "\ue947",
                },
            };

            LsbItems2.ItemsSource = new ObservableCollection<Model2>()
            {
                new Model2()
                {
                    Property1 = "21.05.10",
                    Property2 = "1.125798",
                    Property3 = "0.2655",
                    Property4 = "0x23rA...",
                    IsRaise = true,
                },
                new Model2()
                {
                    Property1 = "21.05.10",
                    Property2 = "1.125798",
                    Property3 = "0.2655",
                    Property4 = "0x23rA...",
                },
                new Model2()
                {
                    Property1 = "21.05.10",
                    Property2 = "1.125798",
                    Property3 = "0.2655",
                    Property4 = "0x23rA...",
                    IsRaise = true,
                },
                new Model2()
                {
                    Property1 = "21.05.10",
                    Property2 = "1.125798",
                    Property3 = "0.2655",
                    Property4 = "0x23rA...",
                },
            };
        }

        private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }

    public class Model1
        : NotifyPropertyChangedBase
    {
        public Brush AccentBrush { get => _accentBrush; set => Set(ref _accentBrush, value); }
        private Brush _accentBrush;

        public string DisplayName { get => _displayName; set => Set(ref _displayName, value); }
        private string _displayName;

        public string Icon { get => _icon; set => Set(ref _icon, value); }
        private string _icon;

        public string Value { get => _value; set => Set(ref _value, value); }
        private string _value;
    }

    public class Model2
        : NotifyPropertyChangedBase
    {
        public string Property1 { get => _property1; set => Set(ref _property1, value); }
        private string _property1;

        public string Property2 { get => _property2; set => Set(ref _property2, value); }
        private string _property2;

        public string Property3 { get => _property3; set => Set(ref _property3, value); }
        private string _property3;

        public bool IsRaise { get => _isRaise; set => Set(ref _isRaise, value); }
        private bool _isRaise;

        public string Property4 { get => _property4; set => Set(ref _property4, value); }
        private string _property4;

    }

}
