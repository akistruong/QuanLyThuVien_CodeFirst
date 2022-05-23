using Microsoft.AspNetCore.Mvc;
using QLTV2._0.Models;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using QLTV2._0.Models.CartComponentModels;

namespace QLTV2._0.Views.Shared.Components.CartComponent
{
    public class CartComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = HttpContext.Session.Get("Cart");
            int count = 0;
            if(items !=null)
            {
                var data = JsonSerializer.Deserialize<List<CartItems>>(items);
                count = data.Sum(x => x.qty);
            }
           
            return View("CartComponentView",count);
        }
    }
}
