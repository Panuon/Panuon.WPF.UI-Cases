namespace ProjectM.Models
{
    public class ProjectCardMultiplePictureItem
        : ProjectCardItemBase
    {
        #region Image1
        public string Image1 { get => _image1; set => Set(ref _image1, value); }
        private string _image1;
        #endregion

        #region Image2
        public string Image2 { get => _image2; set => Set(ref _image2, value); }
        private string _image2;
        #endregion
    }
}
