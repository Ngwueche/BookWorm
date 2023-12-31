namespace BookWorm.Models.ViewModels
{
    public class CartVM
    {
        public IEnumerable<ShoppingCartVM> ShoppingCartList { get; set; }
        public double OrderTotal { get; set; }
    }
}
