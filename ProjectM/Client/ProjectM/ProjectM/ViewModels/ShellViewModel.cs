using Caliburn.Micro;
using Panuon.WPF;
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
using System.Windows;
using System.Windows.Input;
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
                    InviteUserItems = new ObservableCollection<InviteUserItem>()
                    {
                        new InviteUserItem()
                        {
                            User = new UserItem()
                            {
                                Name = "John",
                                HeadImage = "/ProjectM.UI;component/Resources/Images/headimage_1.png",
                            },
                        },
                        new InviteUserItem()
                        {
                            User = new UserItem()
                            {
                                Name = "John",
                                HeadImage = "/ProjectM.UI;component/Resources/Images/headimage_2.png",
                            },
                        },
                        new InviteUserItem()
                        {
                            User = new UserItem()
                            {
                                Name = "John",
                                HeadImage = "/ProjectM.UI;component/Resources/Images/headimage_3.png",
                            },
                        },
                        new InviteUserItem()
                        {
                            User = new UserItem()
                            {
                                Name = "John",
                                HeadImage = "/ProjectM.UI;component/Resources/Images/headimage_4.png",
                            },
                        },
                        new InviteUserItem()
                        {
                            IsExtend = true,
                            ExtendNumber = 2,
                        }
                    },
                    ToDoCardItems = new ObservableCollection<ProjectCardItemBase>()
                    {
                        new ProjectCardTextItem()
                        {
                            Comments = 12,
                            Files = 0,
                            Priority = ProjectCardPriority.Low,
                            DisplayName = "Brainstorming",
                            Text = "Brainstorming brings team members' diverse experience into play. ",
                            InviteUserItems = new ObservableCollection<InviteUserItem>()
                            {
                                new InviteUserItem()
                                {
                                    User = new UserItem()
                                    {
                                        Name = "John",
                                        HeadImage = "/ProjectM.UI;component/Resources/Images/headimage_1.png",
                                    },
                                },
                                new InviteUserItem()
                                {
                                    User = new UserItem()
                                    {
                                        Name = "John",
                                        HeadImage = "/ProjectM.UI;component/Resources/Images/headimage_2.png",
                                    },
                                },
                                new InviteUserItem()
                                {
                                    User = new UserItem()
                                    {
                                        Name = "John",
                                        HeadImage = "/ProjectM.UI;component/Resources/Images/headimage_3.png",
                                    },
                                },
                            },

                        },
                        new ProjectCardSinglePictureItem()
                        {
                            Comments = 12,
                            Files = 0,
                            Priority = ProjectCardPriority.High,
                            DisplayName = "Brainstorming",
                            Image = "/ProjectM.UI;component/Resources/Images/background_1.png",
                            InviteUserItems = new ObservableCollection<InviteUserItem>()
                            {
                                new InviteUserItem()
                                {
                                    User = new UserItem()
                                    {
                                        Name = "John",
                                        HeadImage = "/ProjectM.UI;component/Resources/Images/headimage_1.png",
                                    },
                                },
                                new InviteUserItem()
                                {
                                    User = new UserItem()
                                    {
                                        Name = "John",
                                        HeadImage = "/ProjectM.UI;component/Resources/Images/headimage_2.png",
                                    },
                                },
                                new InviteUserItem()
                                {
                                    User = new UserItem()
                                    {
                                        Name = "John",
                                        HeadImage = "/ProjectM.UI;component/Resources/Images/headimage_3.png",
                                    },
                                },
                            },

                        },
                        new ProjectCardMultiplePictureItem()
                        {
                            Comments = 12,
                            Files = 0,
                            Priority = ProjectCardPriority.Completed,
                            DisplayName = "Brainstorming",
                            Image1 = "/ProjectM.UI;component/Resources/Images/background_2.png",
                            Image2 = "/ProjectM.UI;component/Resources/Images/background_3.png",
                            InviteUserItems = new ObservableCollection<InviteUserItem>()
                            {
                                new InviteUserItem()
                                {
                                    User = new UserItem()
                                    {
                                        Name = "John",
                                        HeadImage = "/ProjectM.UI;component/Resources/Images/headimage_1.png",
                                    },
                                },
                                new InviteUserItem()
                                {
                                    User = new UserItem()
                                    {
                                        Name = "John",
                                        HeadImage = "/ProjectM.UI;component/Resources/Images/headimage_2.png",
                                    },
                                },
                                new InviteUserItem()
                                {
                                    User = new UserItem()
                                    {
                                        Name = "John",
                                        HeadImage = "/ProjectM.UI;component/Resources/Images/headimage_3.png",
                                    },
                                },
                            },

                        }

                    },
                    
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

        public ICommand CurrentPageChangedCommand { get => _currentPageChangedCommand; set => Set(ref _currentPageChangedCommand, value); }
        private ICommand _currentPageChangedCommand = new RelayCommand(OnExecuted);

        private static void OnExecuted(object obj)
        {
        }


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
        private int _selectedViewIndex = 0;
        #endregion

        #endregion

        #region Methods
        public void Exit()
        {
            Application.Current.Shutdown(0);
        }
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
