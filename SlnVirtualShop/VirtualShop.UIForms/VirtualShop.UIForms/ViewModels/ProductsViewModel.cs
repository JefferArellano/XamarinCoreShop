namespace VirtualShop.UIForms.ViewModels
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using VirtualShop.Common.Models;
    using VirtualShop.Common.Services;

    public class ProductsViewModel : BaseViewModel
    {
        #region Service
        private ApiService apiService;
        #endregion

        #region Atributtes

        private ObservableCollection<Product> products;

        #endregion

        #region Properties
        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
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
            var response = await apiService.GetListAsync<Product>(
                "https://localhost:44314",
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

            var productsList = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(productsList);
        }
        #endregion

        #region Methods

        #endregion

    }
}
