
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace BotanicShop.Models
{
    public class Cart
    {
        // ######################################################################### Properties
        public Dictionary<string, int> CartItems= new();

        // ######################################################################### Constructors
        public Cart() { 
            CartItems.Clear();
        }
        public Cart(string productId, int amount) {
            CartItems.Add(productId, amount);
        }
        public Cart(Product product, int amount)
        {
            EditProductAmount(product, amount);            
        }

        
        // ######################################################################### Methods
        public void AddToCart(Product product,int amount){ 
            this.CartItems.Add(product.Id, amount);
        }
        public void RemoveFromCart(Product product) {
            this.CartItems .Remove (product.Id);
        }
        public void EditProductAmount(Product product,int amount) {
            if (CartItems.ContainsKey(product.Id))
            {
                this.CartItems[product.Id] = amount;
            }
            else
            {
                this.CartItems.Add(product.Id, amount);
            }
        }
    }
}
