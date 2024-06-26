﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAJD.Model;
using TesteAJD.Services;
using TesteAJD.Views;

namespace TesteAJD.ViewModels
{
    [QueryProperty(nameof(SourceItems), "SourceItems")]
    public partial class ReplacementViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<ProductListModel> _sourceItems;

        [ObservableProperty]
        private ObservableCollection<ProductListModel> _outPutItems;

        public ReplacementViewModel(INavigationService navigationService) : base(navigationService)
        {
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            await Task.Delay(3000);

            OutPutItems = new ObservableCollection<ProductListModel>();

            IsLoaded = true;
            IsFooterVisible = true;
        }

        [RelayCommand]
        private void AddProduct(ProductListModel sourceItem)
        {
            var foundProduct = OutPutItems.ToList().Find(x => x.Name == sourceItem.Name);

            if (foundProduct != null)
            {
                var updatedProduct = new ProductListModel()
                {
                    BrandName = foundProduct.BrandName,
                    Qty = foundProduct.Qty + 1,
                    Details = foundProduct.Details,
                    ImageUrl = foundProduct.ImageUrl,
                    Name = foundProduct.Name,
                    Price = foundProduct.Price
                };

                var index = OutPutItems.IndexOf(foundProduct);

                if (index >= 0)
                {
                    OutPutItems[index] = updatedProduct;
                }
            }
            else
            {
                OutPutItems.Add(new ProductListModel()
                {
                    BrandName = sourceItem.BrandName,
                    Qty = 1,
                    Details = sourceItem.Details,
                    ImageUrl = sourceItem.ImageUrl,
                    Name = sourceItem.Name,
                    Price = sourceItem.Price
                });
            }
        }

        [RelayCommand]
        private void RemoveProduct(ProductListModel sourceItem)
        {
            OutPutItems.Remove(sourceItem);
        }
    }
}
