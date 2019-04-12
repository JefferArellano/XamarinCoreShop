namespace VirtualShop.UIForms.ViewModels
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using VirtualShop.Common.Models;
    using VirtualShop.Common.Services;
    using Xamarin.Forms;

    public class ProductsViewModel : BaseViewModel
    {
        #region Service
        private ApiService apiService;
        #endregion

        #region Atributtes

        private ObservableCollection<Product> products;
        private bool isRefreshing;

        #endregion

        #region Properties
        public ObservableCollection<Product> Products
        {
            get => this.products;
            set => this.SetValue(ref this.products, value);
        }

        public bool IsRefreshing
        {
            get => this.isRefreshing;
            set => this.SetValue(ref this.isRefreshing, value);
        }

        #endregion

        #region Constructor
        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
        }

        private async void LoadProducts()
        {
            this.IsRefreshing = true;

            var response = await apiService.GetListAsync<Product>(
                Application.Current.Resources["WebUrl"].ToString(),
                "/api",
                "/Products"
                );

            if (!response.IsSuccess)
            {
                await App.Current.MainPage.DisplayAlert
                    (
                    "Error",
                    "No Data Found",
                    "Accept"
                    );

                return;
            }

            this.IsRefreshing = false;
            var productsList = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(productsList);
        }
        #endregion

        #region Methods

        #endregion

    }
}
