using ProjectM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ProjectM
{
    public class ProjectCardItemTemplateSelector
        : DataTemplateSelector
    {
        #region Overrieds
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var contentPresenter = container as ContentPresenter;
            var contentControl = contentPresenter.TemplatedParent as ContentControl;

            if(item is ProjectCardTextItem)
            {
                return contentControl.FindResource("ProjectCardTextItemDataTemplate") as DataTemplate;
            }
            else if(item is ProjectCardSinglePictureItem)
            {
                return contentControl.FindResource("ProjectCardSinglePictureItemDataTemplate") as DataTemplate;
            }
            else if(item is ProjectCardMultiplePictureItem)
            {
                return contentControl.FindResource("ProjectCardMultiplePictureItemDataTemplate") as DataTemplate;
            }
            return null;
        }
        #endregion
    }
}
