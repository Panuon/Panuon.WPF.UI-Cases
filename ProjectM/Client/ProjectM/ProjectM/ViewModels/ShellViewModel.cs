using Caliburn.Micro;
using ProjectM.Shared;
using ProjectM.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectM.ViewModels
{
    public class ShellViewModel
        : ViewModelBase
    {
        public ShellViewModel()
        {

        }

        bool isLight = true;

        public void SwitchTheme()
        {
            if (isLight)
            {
                ThemeManager.UpdateTheme(AppTheme.Dark);
            }
            else
            {
                ThemeManager.UpdateTheme(AppTheme.Light);
            }
            isLight = !isLight;
        }
    }
}
