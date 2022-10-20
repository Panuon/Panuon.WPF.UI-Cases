using Caliburn.Micro;
using ProjectM.Models;
using ProjectM.Shared;
using ProjectM.UI;
using ProjectM.ViewModels.Shell;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ProjectM.ViewModels
{
    public class ShellViewModel
        : ViewModelBase
    {
        #region Ctor
        public ShellViewModel()
        {
            HomeViewModel = new HomeViewModel();
            MembersViewModel = new MembersViewModel();
            MessagesViewModel = new MessagesViewModel();
            ProjectsViewModel = new ProjectsViewModel();
            SettingsViewModel = new SettingsViewModel();
            TasksViewModel = new TasksViewModel();

            ProjectItems = new ObservableCollection<ProjectItem>()
            {
                new ProjectItem()
                {
                    ProjectName = "Mobile App",
                    AccentBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7AC555")),
                },
                new ProjectItem()
                {
                    ProjectName = "Website Redesign",
                    AccentBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFA500")),
                },
                new ProjectItem()
                {
                    ProjectName = "Design System",
                    AccentBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E4CCFD")),
                },
                new ProjectItem()
                {
                    ProjectName = "Wireframes",
                    AccentBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#76A5EA")),
                },
            };
        }
        #endregion

        #region Properties

        #region ViewModels
        public HomeViewModel HomeViewModel { get; }

        public MembersViewModel MembersViewModel { get; }

        public MessagesViewModel MessagesViewModel { get; }

        public ProjectsViewModel ProjectsViewModel { get; }

        public SettingsViewModel SettingsViewModel { get; }

        public TasksViewModel TasksViewModel { get; }
        #endregion

        #region ProjectItems
        public ObservableCollection<ProjectItem> ProjectItems { get => _projectItems; set => Set(ref _projectItems, value); }
        private ObservableCollection<ProjectItem> _projectItems;
        #endregion

        #region SelectedMainMenuIndex
        public int SelectedMainMenuIndex { get => _selectedMainMenuIndex; set => Set(ref _selectedMainMenuIndex, value); }
        private int _selectedMainMenuIndex;
        #endregion

        #region SelectedProjectIndex
        public int SelectedProjectIndex { get => _selectedProjectIndex; set => Set(ref _selectedProjectIndex, value); }
        private int _selectedProjectIndex = -1;
        #endregion

        #region SelectedViewIndex
        public int SelectedViewIndex { get => _selectedViewIndex; set => Set(ref _selectedViewIndex, value); }
        private int _selectedViewIndex = -1;
        #endregion

        #endregion

        #region Event Handler
        public void OnMainMenuSelectionChanged()
        {
            if(SelectedMainMenuIndex != -1)
            {
                SelectedProjectIndex = -1;
                SelectedViewIndex = SelectedMainMenuIndex;
            }
        }

        public void OnProjectSelectionChanged()
        {
            if (SelectedProjectIndex != -1)
            {
                SelectedMainMenuIndex = -1;
                SelectedViewIndex = 5;

                var currentProject = ProjectItems[SelectedProjectIndex];
                ProjectsViewModel.CurrentProject = currentProject;
            }
        }
        #endregion
    }
}
