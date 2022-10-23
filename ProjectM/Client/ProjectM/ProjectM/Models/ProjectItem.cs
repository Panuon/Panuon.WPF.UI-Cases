using Panuon.WPF;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace ProjectM.Models
{
    public class ProjectItem
        : NotifyPropertyChangedBase
    {
        #region ProjectName
        public string ProjectName { get => _projectName; set => Set(ref _projectName, value); }
        private string _projectName;
        #endregion

        #region AccentBrush
        public Brush AccentBrush { get => _accentBrush; set => Set(ref _accentBrush, value); }
        private Brush _accentBrush;
        #endregion

        #region InviteUserItems
        public ObservableCollection<InviteUserItem> InviteUserItems { get => _inviteUserItems; set => Set(ref _inviteUserItems, value); }
        private ObservableCollection<InviteUserItem> _inviteUserItems;
        #endregion
    }
}
