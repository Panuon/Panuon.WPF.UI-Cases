using Caliburn.Micro;
using ProjectM.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ProjectM.ViewModels.SignInSignUp
{
    public class SignUpViewModel
        : ViewModelBase
    {
        #region Fields
        private DispatcherTimer _dispatcherTimer;
        #endregion

        #region Ctor
        public SignUpViewModel()
        {
            _dispatcherTimer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            _dispatcherTimer.Tick += DispatcherTimer_Tick;
        }
        #endregion

        #region Properties
        public bool IsSendCodeEnabled { get => _isSendCodeEnabled; set => Set(ref _isSendCodeEnabled, value); }
        private bool _isSendCodeEnabled = true;

        public int? SendCodeCountdown { get => _sendCodeCountdown; set => Set(ref _sendCodeCountdown, value); }
        private int? _sendCodeCountdown = null;

        public string Email { get => _email; set => Set(ref _email, value); }
        private string _email;
        #endregion

        #region Methods
        public void SendCode()
        {
            SendCodeCountdown = 60;
            IsSendCodeEnabled = false;
            _dispatcherTimer.Start();
        }

        public void SignIn()
        {
            EventAggregator.PublishOnUIThread(new SwitchPageMessage(SwitchPageMessageType.SignIn));
        }

        public void SignUp()
        {
            
        }
        #endregion

        #region Event Handlers
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (SendCodeCountdown is int countdown
                && countdown > 0)
            {
                SendCodeCountdown--;
            }
            else
            {
                SendCodeCountdown = null;
                IsSendCodeEnabled = true;
                _dispatcherTimer.Stop();
            }
        }
        #endregion
    }
}
