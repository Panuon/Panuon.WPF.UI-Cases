using Caliburn.Micro;
using ProjectM.UI;
using ProjectM.ViewModels.SignInSignUp;

namespace ProjectM.ViewModels
{
    public class SignInSignUpViewModel
        : ViewModelBase, IHandle<SwitchPageMessage>
    {
        #region Fields
        private SignInViewModel _signInViewModel;

        private SignUpViewModel _signUpViewModel;
        #endregion

        #region Ctor
        public SignInSignUpViewModel()
        {
            EventAggregator.Subscribe(this);

            _signInViewModel = new SignInViewModel();
            _signUpViewModel = new SignUpViewModel();

            CurrentViewModel = _signInViewModel;
        }
        #endregion

        #region Properties
        public ViewModelBase CurrentViewModel { get => _currentViewModel; set => Set(ref _currentViewModel, value); }
        private ViewModelBase _currentViewModel;
        #endregion

        #region Methods
        public void SwitchToSignUp()
        {
        }

        public void Handle(SwitchPageMessage message)
        {
            switch (message.PageType)
            {
                case SwitchPageMessageType.SignIn:
                    CurrentViewModel = _signInViewModel;
                    break;
                case SwitchPageMessageType.SignUp:
                    CurrentViewModel = _signUpViewModel;
                    break;
                case SwitchPageMessageType.Shell:
                    var viewModel = new ShellViewModel();
                    WindowManager.ShowWindow(viewModel);
                    TryClose();
                    break;
            }
        }
        #endregion
    }
}
