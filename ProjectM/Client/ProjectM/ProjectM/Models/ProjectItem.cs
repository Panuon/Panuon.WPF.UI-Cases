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

        #region ToDoCardItems
        public ObservableCollection<ProjectCardItemBase> ToDoCardItems { get => _toDoCardItems; set => Set(ref _toDoCardItems, value); }
        private ObservableCollection<ProjectCardItemBase> _toDoCardItems;
        #endregion

        #region OnProgressCardItems
        public ObservableCollection<ProjectCardItemBase> OnProgressCardItems { get => _onProgressCardItems; set => Set(ref _onProgressCardItems, value); }
        private ObservableCollection<ProjectCardItemBase> _onProgressCardItems;
        #endregion

        #region DoneCardItems
        public ObservableCollection<ProjectCardItemBase> DoneCardItems { get => _doneCardItems; set => Set(ref _doneCardItems, value); }
        private ObservableCollection<ProjectCardItemBase> _doneCardItems;
        #endregion
    }
}
