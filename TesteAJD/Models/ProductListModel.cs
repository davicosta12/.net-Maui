using System.Collections.ObjectModel;

namespace TesteAJD.Model
{
    public class ProductListModel
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string Price { get; set; }
        public string Details { get; set; }
        public double Qty { get; set; } = 1;
    }

    public class ProductGroup : ObservableCollection<ProductListModel>
    {
        public string Name { get; private set; }

        public ProductGroup(string name, ObservableCollection<ProductListModel> products) : base(products)
        {
            Name = name;
        }
    }
}
