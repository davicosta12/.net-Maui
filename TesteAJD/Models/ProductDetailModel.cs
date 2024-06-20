using CommunityToolkit.Mvvm.ComponentModel;

namespace TesteAJD.Models
{
    public class ProductDetailModel : ObservableObject
    {
        private string _ImageUrl;
        private string _Name;
        private List<ReviewModel> _Reviews;
        private List<string> _Sizes;
        public Color _Colors;
        private double _Price;
        public string _Details;

        public string ImageUrl
        {
            get => _ImageUrl;
            set => SetProperty(ref _ImageUrl, value);
        }

        public string Name
        {
            get => _Name;
            set => SetProperty(ref _Name, value);
        }

        public List<string> Sizes
        {
            get => _Sizes;
            set => SetProperty(ref _Sizes, value);
        }

        public List<ReviewModel> Reviews
        {
            get => _Reviews;
            set => SetProperty(ref _Reviews, value);
        }

        public Color Colors
        {
            get => _Colors;
            set => SetProperty(ref _Colors, value);
        }

        public string Details
        {
            get => _Details;
            set => SetProperty(ref _Details, value);
        }

        public double Price
        {
            get => _Price;
            set => SetProperty(ref _Price, value);
        }
    }

    public class ReviewModel
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Review { get; set; }
        public float Rating { get; set; }
    }
}