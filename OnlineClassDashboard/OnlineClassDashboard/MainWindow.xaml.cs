using Panuon.WPF;
using Panuon.WPF.UI;

namespace OnlineClassDashboard
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : WindowX
    {
        public MainWindow()
        {
            InitializeComponent();

            var model1 = new Model()
            {
                DisplayName = "Item 1",
                Description = "You have a class in 32 min."
            };
            Lsbi1.Content = model1;
            
            var model2 = new Model()
            {
                DisplayName = "Item 2",
                Description = "You have a class in 32 min."
            };
            Lsbi2.Content = model2;

            var model3 = new Model()
            {
                DisplayName = "Item 3",
                Description = "You have a class in 32 min."
            };
            Lsbi3.Content = model3;

            var model4 = new Model()
            {
                DisplayName = "Item 4",
                Description = "You have a class in 32 min."
            };
            Lsbi4.Content = model4;

            model4.DisplayName = "Item 4.4";
        }
    }

    public class Model
        : NotifyPropertyChangedBase
    {
        #region DisplayName
        public string DisplayName { get => _displayName; set => Set(ref _displayName, value); }
        private string _displayName;
        #endregion

        #region Description
        public string Description { get => _description; set => Set(ref _description, value); }
        private string _description;
        #endregion
    }
}
