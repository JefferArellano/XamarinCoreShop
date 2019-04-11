namespace VirtualShop.UIForms.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MainViewModel
    {
        #region Attributes

        private static MainViewModel instance;

        #endregion

        #region ViewModels
        public LoginViewModel Login { get; set; }
        public ProductsViewModel Products { get; set; }

        #endregion

        #region Properties

        #endregion

        #region Constructor

        public MainViewModel()
        {
            instance = this;
        }
        #endregion

        #region Singlenton

        public static MainViewModel GetInstance()
        {
            if (instance ==  null )
            {
                return new MainViewModel();
            }
            return instance;
        }

        #endregion

        #region Commands

        #endregion

        #region Methods

        #endregion

    }
}
