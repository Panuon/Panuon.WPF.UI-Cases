using Caliburn.Micro;
using ProjectM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectM.UI
{
    public class ViewModelBase
        : Screen
    {
        public IWindowManager WindowManager =>
            IoC.Get<IWindowManager>();

        public IEventAggregator EventAggregator 
            => IoC.Get<IEventAggregator>();

        public ILogger Logger
            => IoC.Get<ILogger>();

        public IThemeManager ThemeManager 
            => IoC.Get<IThemeManager>();
    }
}
