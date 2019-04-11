namespace VirtualShop.UIForms.Infrastructure
{
    using VirtualShop.UIForms.ViewModels;

    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
