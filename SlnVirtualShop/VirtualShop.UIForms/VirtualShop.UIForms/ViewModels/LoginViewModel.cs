namespace VirtualShop.UIForms.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    using VirtualShop.UIForms.Views;
    using Xamarin.Forms;

    public class LoginViewModel
    {
        #region Properties
        public string Email { get; set; }
        public string Password { get; set; }

        #endregion

        #region Commands
        public ICommand LoginCommand => new RelayCommand(Login);

        #endregion

        #region Methods
        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.
                    DisplayAlert
                    (
                    "Error",
                    "You must enter an Email",
                    "Accept"
                    );
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.
                    DisplayAlert
                    (
                    "Error",
                    "You must enter a password",
                    "Accept"
                    );
                return;
            }

            MainViewModel.GetInstance().Products = new ProductsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ProductsPage());

        }
        #endregion


    }
}
