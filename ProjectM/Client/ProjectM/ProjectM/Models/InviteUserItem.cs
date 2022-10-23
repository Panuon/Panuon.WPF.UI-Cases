using Panuon.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectM.Models
{
    public class InviteUserItem
        : NotifyPropertyChangedBase
    {
        #region UserItem
        public UserItem User { get => _user; set => Set(ref _user, value); }
        private UserItem _user;
        #endregion

        #region IsExtend
        public bool IsExtend { get => _isExtend; set => Set(ref _isExtend, value); }
        private bool _isExtend;
        #endregion

        #region ExtendNumber
        public int ExtendNumber { get => _extendNumber; set => Set(ref _extendNumber, value); }
        private int _extendNumber;
        #endregion
    }
}
