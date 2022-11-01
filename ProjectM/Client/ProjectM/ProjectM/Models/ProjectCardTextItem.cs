using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectM.Models
{
    public class ProjectCardTextItem
        : ProjectCardItemBase
    {
        #region Text
        public string Text { get => _text; set => Set(ref _text, value); }
        private string _text;
        #endregion

    }
}
