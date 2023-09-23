using Caliburn.Micro;
using ProjectM.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectM.ViewModels.SignInSignUp
{
    public class SignInViewModel
        : ViewModelBase
    {
        #region Ctor
        public SignInViewModel()
        {
        }
        #endregion

        #region Methods
        public void SignUp()
        {
            EventAggregator.PublishOnUIThread(new SwitchPageMessage(SwitchPageMessageType.SignUp));
        }

        public void SignIn()
        {
            EventAggregator.PublishOnUIThread(new SwitchPageMessage(SwitchPageMessageType.Shell));
        }
        #endregion
    }
}
