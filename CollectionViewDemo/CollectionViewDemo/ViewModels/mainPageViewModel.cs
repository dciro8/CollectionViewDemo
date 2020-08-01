using CollectionViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CollectionViewDemo.ViewModels
{
  public  class mainPageViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public mainPageViewModel()
        {
            Products = new ObservableCollection<Product> {

                new Product{ Name="Yogurt",
                Image="yogurt.jpg",
                Price=58.0m,
                HasOffer=false},
                new Product{ Name="Peras",
                Image="peras.jpg",
                Price=158.0m,
                HasOffer=false},
                new Product{ Name="manzanas",
                Image="manzanas.jpg",
                Price=88.0m,
                OfferPrice=45.0m,
                HasOffer=false}
            };
        }
    }
}
