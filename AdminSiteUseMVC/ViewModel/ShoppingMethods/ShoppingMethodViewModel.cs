using System.ComponentModel.DataAnnotations;

namespace AdminSiteUseMVC.ViewModel.ShoppingMethods
{
    public class ShoppingMethodViewModel
    {
        public int Id { get; set; }
      
        [MinLength(3), MaxLength(100)]
        public string? Name { get; set; }
        public decimal Price { get; set; }
      
    }
}
