namespace Sale.ViewModels
{
    public class MainViewModel
    {
        private ProductsViewModel Products { get; set; }

        public MainViewModel()
        {
            this.Products = new ProductsViewModel();
        }

    }
}
