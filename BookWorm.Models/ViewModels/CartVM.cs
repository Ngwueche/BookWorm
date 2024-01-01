using BookWorm.Models.Models;

namespace BookWorm.Models.ViewModels
{
    public class CartVM
    {
        public IEnumerable<ShoppingCartVM> ShoppingCartList { get; set; }
        public OrderHeader OrderHeader { get; set; }
        public double OrderTotal { get; set; }
    }
}
