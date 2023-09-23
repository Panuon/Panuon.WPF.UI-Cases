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

namespace SteamRedesign
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow 
        : WindowX
    {
        private List<GameData> _data = new List<GameData>()
        {
            new GameData()
            {
                ImageSource = new BitmapImage(new Uri("pack://application:,,,/SteamRedesign;component/Resources/Stray.png")),
                Tags = new List<string>()
                {
                    "Cats", "Adventrue", "Cyberpunk", "Atmospheric"
                },
            },
            new GameData()
            {
                ImageSource = new BitmapImage(new Uri("pack://application:,,,/SteamRedesign;component/Resources/HogwartsLegacy.png")),
                Tags = new List<string>()
                {
                    "Cats", "Adventrue", "Cyberpunk", "Atmospheric"
                },
            },
            new GameData()
            {
                ImageSource = new BitmapImage(new Uri("pack://application:,,,/SteamRedesign;component/Resources/CallofDuty.png")),
                Tags = new List<string>()
                {
                    "Cats", "Adventrue", "Cyberpunk", "Atmospheric"
                },
            },
            new GameData()
            {
                ImageSource = new BitmapImage(new Uri("pack://application:,,,/SteamRedesign;component/Resources/MassEffect.png")),
                Tags = new List<string>()
                {
                    "Cats", "Adventrue", "Cyberpunk", "Atmospheric"
                },
            },
        };

        public MainWindow()
        {
            InitializeComponent();

            carousel.ItemsSource = _data;
            image.Source = _data[0].ImageSource;
        }

        private void Carousel_CurrentIndexChanged(object sender, Panuon.WPF.SelectedValueChangedRoutedEventArgs<int> e)
        {
            image.Source = _data[carousel.CurrentIndex].ImageSource;
        }
    }

    public class GameData
    {
        public ImageSource ImageSource { get; set; }

        public List<string> Tags { get; set; }
    }

}
