using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Navigation.ViewModels
{
    public partial class ProductItemViewModel : ObservableObject
    {

        public string Name { get; }
        public decimal Price { get; }

        public ProductItemViewModel(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }

    public class ProductViewModel : ObservableObject
    {
        private readonly ObservableCollection<ProductItemViewModel> _products;

        public ObservableCollection<ProductItemViewModel> Products => _products;

        public ProductViewModel()
        {
            _products = new ObservableCollection<ProductItemViewModel>()
            {
                new ProductItemViewModel("Grip Tape", 9.99m),
                new ProductItemViewModel("Deck", 9.99m),
                new ProductItemViewModel("Wheels", 9.99m),
                new ProductItemViewModel("Bearings", 9.99m),
                new ProductItemViewModel("Trucks", 9.99m)
            };
        }
    }
}
