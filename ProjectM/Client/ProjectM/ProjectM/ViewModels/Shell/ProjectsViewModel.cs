using ProjectM.Models;
using ProjectM.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectM.ViewModels.Shell
{
    public class ProjectsViewModel
        : ViewModelBase
    {
        #region Properties

        #region CurrentProject
        public ProjectItem CurrentProject { get => _currentProject; set => Set(ref _currentProject, value); }
        private ProjectItem _currentProject;
        #endregion


        #endregion
    }
}
