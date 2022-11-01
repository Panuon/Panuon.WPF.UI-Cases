using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectM.Models
{
    public class ProjectCardSinglePictureItem
        : ProjectCardItemBase
    {
        #region Image
        public string Image { get => _image; set => Set(ref _image, value); }
        private string _image;
        #endregion
    }
}
