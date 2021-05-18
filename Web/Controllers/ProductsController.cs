using DataAccess;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;

        private ProductService _productService;
        private CategoryService _categoryService;
        public EcommerceContext _context { get; set; }

        private readonly UserManager<AppUser> _userManager;


        public ProductsController(ILogger<ProductsController> logger, EcommerceContext context, UserManager<AppUser> userManager)
        {
            _productService = new ProductService(context);
            _categoryService = new CategoryService(context);
            _logger = logger;
            _userManager = userManager;
            _context = context;
        }

        [Authorize(Roles = "User")]
        public async Task<IActionResult> Checkout()
        {
            var productIds = Request.Cookies["CartProduct"];
            CheckoutVM vm = new CheckoutVM();
            if (productIds != null && !string.IsNullOrEmpty(productIds))
            {
                var ProIDs = productIds.Split('-').Select(p => int.Parse(p)).ToList();
                vm.Products = _productService.FindProductIDs(ProIDs);
                vm.AppUser = await _userManager.GetUserAsync(User);
                vm.ProductIds = ProIDs;
            }
            return View(vm);
        }


        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task<IActionResult> Checkout(CheckoutVM model)
        {
            JsonResult jsonResult = new JsonResult(new { });

            var productIds = Request.Cookies["CartProduct"];
            if (productIds != null && !string.IsNullOrEmpty(productIds))
            {
                var ProIDs = productIds.Split('-').Select(p => int.Parse(p)).ToList();
                model.Products = _productService.FindProductIDs(ProIDs);
                model.ProductIds = ProIDs;
                if (User.Identity.IsAuthenticated)
                {
                    var newOrder = new Order();
                    newOrder.CustomerID = _userManager.GetUserId(User);
                    newOrder.CustomerName = model.FullName;
                    newOrder.CustomerEmail = model.Email;
                    newOrder.CustomerPhone = model.PhoneNumber;
                    newOrder.CustomerAddress = model.Address;
                    newOrder.OrderItems = new List<OrderItem>();
                    foreach (var product in model.Products)
                    {
                        var orderItem = new OrderItem()
                        {
                            ProductID = product.ID,
                            ProductName = product.Name,
                            ItemPrice = product.Price,
                            Quantity = ProIDs.Where(x => product.ID == x).Count()
                        };
                        newOrder.OrderItems.Add(orderItem);
                        newOrder.OrderCode = Guid.NewGuid().ToString();
                        newOrder.TotalAmmount = newOrder.OrderItems.Sum(x => (x.ItemPrice * x.Quantity));
                        newOrder.OrderHistory = new List<OrderHistory>()
                        {
                            //OrderStatus = (int)OrderStatus.Placed,
                            //ModifiedOn = DateTime.Now,
                            //Note = "Order Placed."
                        };
                        newOrder.PlacedOn = DateTime.Now;

                    }
                    _context.Add(newOrder);
                    await _context.SaveChangesAsync();
                }

            }
            Response.Cookies.Delete("CartProduct");
            return jsonResult;
        }

        public IActionResult Index(int? id,string search,int? sortBy)
        {
            ShopProductViewModel vm = new ShopProductViewModel()
            {
                Products = _productService.SearchProduct(id,search,sortBy),
                Categories = _categoryService.GetCatagories()
            };
            return View(vm);
        }

        public IActionResult SearchProduct(int? id, string search, int? sortBy)
        {
            ShopProductViewModel vm = new ShopProductViewModel()
            {
                Products = _productService.SearchProduct(id, search, sortBy),
                Categories = _categoryService.GetCatagories()
            };
            return PartialView("ProductPartial", vm);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }
            ProductViewModel vm = new ProductViewModel();
            vm.Product = _productService.GetProductByID(id.Value);
            return View(vm);
        }
    }
}
