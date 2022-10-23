using Panuon.WPF;

namespace ProjectM.Models
{
    public class UserItem
        : NotifyPropertyChangedBase
    {
        #region Name
        public string Name { get => _name; set => Set(ref _name, value); }
        private string _name;
        #endregion

        #region HeadImage
        public string HeadImage { get => _headImage; set => Set(ref _headImage, value); }
        private string _headImage;
        #endregion

    }
}
