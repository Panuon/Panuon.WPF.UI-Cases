using Panuon.WPF;
using ProjectM.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectM.Models
{
    public abstract class ProjectCardItemBase
        : NotifyPropertyChangedBase
    {
        #region DisplayName
        public string DisplayName { get => _displayName; set => Set(ref _displayName, value); }
        private string _displayName;
        #endregion

        #region Priority
        public ProjectCardPriority Priority { get => _priority; set => Set(ref _priority, value); }
        private ProjectCardPriority _priority;
        #endregion

        #region InviteUserItems
        public ObservableCollection<InviteUserItem> InviteUserItems { get => _inviteUserItems; set => Set(ref _inviteUserItems, value); }
        private ObservableCollection<InviteUserItem> _inviteUserItems;
        #endregion

        #region Comments
        public int Comments { get => _comments; set => Set(ref _comments, value); }
        private int _comments;
        #endregion

        #region Files
        public int Files { get => _files; set => Set(ref _files, value); }
        private int _files;
        #endregion
    }
}
