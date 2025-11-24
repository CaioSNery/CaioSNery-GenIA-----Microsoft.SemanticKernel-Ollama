using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.SemanticKernel;

namespace Demo4.Puglins
{
    public class ProductPuglin
    {
        private readonly List<Product> _products = [
        new(1,"MousePad",true,10),
        new(2,"Mouse Gamer",true,8),
        new(3,"Teclado Gamer",true,2),
        new(4,"Capa Monitor",false,8),
        new(5,"Monitor",true,5)
        ];

        [KernelFunction("get_state")]
        [Description("Change State of the product")]
        public async Task<Product?> ChangeStateAsync(
            [Description("The id of the product")]int id,
            [Description("The Content of the product to be modified")]Product model)
        {
            await Task.Delay(1);
            var product= _products.FirstOrDefault(x=>x.Id==id);

            if(product == null)
            return null;

            product = new Product(model.Id,model.Title,model.isActive,model.QuantityOnHand);

            return product; 
        }

        [KernelFunction("get_product")]
        [Description("Get a list of products and their current status")]
        public async Task<List<Product>>GetProductAsync()
        {
            await Task.Delay(1);
            return _products;
        }
    }

    public record Product(int Id, string Title, bool isActive, int QuantityOnHand);
}