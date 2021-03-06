#pragma checksum "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "692a4eb705cb8fee3e0634d097760474ab69cce9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Checkout), @"mvc.1.0.view", @"/Views/Products/Checkout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\_ViewImports.cshtml"
using Web.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"692a4eb705cb8fee3e0634d097760474ab69cce9", @"/Views/Products/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6391e842b62abea06a0f612747a70aafe1c06c43", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckoutVM>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml"
   decimal totalPrice = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 9 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml"
 if (Model.Products != null && Model.Products.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""checkout-area ptb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12"">
                <div class=""user-actions"">
                    <i class=""bx bx-log-in-circle""></i>
                    <span>Returning customer? <a href=""log-in.html"">Click here to login</a></span>
                </div>
            </div>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "692a4eb705cb8fee3e0634d097760474ab69cce94416", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-lg-6 col-md-12"">
                    <div class=""billing-details"">
                        <h3 class=""title"">Billing Details</h3>
                        <div class=""row"">

                            <div class=""col-lg-12 col-md-12"">
                                <div class=""form-group"">
                                    <label>First Name <span class=""required"">*</span></label>
                                    <input type=""text"" name=""FullName""");
                BeginWriteAttribute("value", " value=\"", 1227, "\"", 1258, 1);
#nullable restore
#line 31 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml"
WriteAttributeValue("", 1235, Model.AppUser.FullName, 1235, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-lg-12 col-md-6"">
                                <div class=""form-group"">
                                    <label>Address <span class=""required"">*</span></label>
                                    <input name=""Address"" type=""text"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-lg-12 col-md-6"">
                                <div class=""form-group"">
                                    <label>Town / City <span class=""required"">*</span></label>
                                    <input type=""text"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6"">
                                <div class=""form-group"">
                                    <label>State / County <span class=""");
                WriteLiteral(@"required"">*</span></label>
                                    <input type=""text"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6"">
                                <div class=""form-group"">
                                    <label>Email Address <span class=""required"">*</span></label>
                                    <input readonly type=""email"" name=""Email""");
                BeginWriteAttribute("value", " value=\"", 2752, "\"", 2780, 1);
#nullable restore
#line 55 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml"
WriteAttributeValue("", 2760, Model.AppUser.Email, 2760, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6"">
                                <div class=""form-group"">
                                    <label>Phone <span class=""required"">*</span></label>
                                    <input type=""text"" name=""PhoneNumber""");
                BeginWriteAttribute("value", " value=\"", 3157, "\"", 3191, 1);
#nullable restore
#line 61 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml"
WriteAttributeValue("", 3165, Model.AppUser.PhoneNumber, 3165, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-lg-12 col-md-12"">
                                <div class=""form-check"">
                                    <input type=""checkbox"" class=""form-check-input"" id=""create-an-account"">
                                    <label class=""form-check-label"" for=""create-an-account"">Create an account?</label>
                                </div>
                            </div>
                            <div class=""col-lg-12 col-md-12"">
                                <div class=""form-check"">
                                    <input type=""checkbox"" class=""form-check-input"" id=""ship-different-address"">
                                    <label class=""form-check-label"" for=""ship-different-address"">Ship to a different address?</label>
                                </div>
                            </div>
                            <div class=""col-lg-12 col-md-12"">
     ");
                WriteLiteral(@"                           <div class=""form-group"">
<textarea name=""notes"" id=""notes"" cols=""30"" rows=""5"" placeholder=""Order Notes"" class=""form-control""></textarea>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-12"">
                    <div class=""order-details"">
                        <div class=""order-table table-responsive"">
                            <h3 class=""title"">Your Order</h3>
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">Product Name</th>
                                        <th scope=""col"">Total</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 96 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml"
                                     foreach (var product in Model.Products)
                                    {
                                        var quantity = Model.ProductIds.Where(p => p == product.ID).Count();
                                        totalPrice += quantity * product.Price;

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <td class=\"product-name\">\n                            <a href=\"#\">");
#nullable restore
#line 102 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml"
                                   Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" x ");
#nullable restore
#line 102 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml"
                                                   Write(quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n                        </td>\n                        <td class=\"product-total\">\n                            <span class=\"subtotal-amount\"> ");
#nullable restore
#line 105 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml"
                                                       Write(product.Price*quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Azn</span>\n                        </td>\n                    </tr>");
#nullable restore
#line 107 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml"
                         }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    <tr>
                                        <td class=""order-subtotal"">
                                            <span>Cart Subtotal</span>
                                        </td>
                                        <td class=""order-subtotal-price"">
                                            <span class=""order-subtotal-amount"">
");
                WriteLiteral("                                                ");
#nullable restore
#line 116 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml"
                                           Write(totalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class=""order-shipping"">
                                            <span>Shipping</span>
                                        </td>
                                        <td class=""shipping-price"">
                                            <span>$5.00</span>
                                        </td>
                                    </tr>
                                    <tr>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class=""payment-box"">
                            <div class=""payment-method"">
                                <p>
                                    <input type=""radio"" id=""direct-bank-transfer"" name=""radio-group""");
                BeginWriteAttribute("checked", " checked=\"", 7450, "\"", 7460, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <label for=""direct-bank-transfer"">Direct Bank Transfer</label>
                                    Make your payment directly into our bank account. Please use your Order ID as the payment reference. Your order will not be shipped until the funds have cleared in our account.
                                </p>
                                <p>
                                    <input type=""radio"" id=""paypal"" name=""radio-group"">
                                    <label for=""paypal"">PayPal</label>
                                </p>
                                <p>
                                    <input type=""radio"" id=""cash-on-delivery"" name=""radio-group"">
                                    <label for=""cash-on-delivery"">Cash On Delivery</label>
                                </p>
                            </div>
                            <a href=""#"" class=""default-btn btn btn-dark"">
                                Place Order
                          ");
                WriteLiteral("      <i class=\"flaticon-right\"></i>\n                            </a>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</section> ");
#nullable restore
#line 159 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml"
           }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"text-center alert alert-warning\">Cart is Empty</p>\n                <a class=\"btn btn-outline-primary\" style=\"width:100%\" href=\"/\">Go to Home</a>            \n");
#nullable restore
#line 164 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Checkout.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
      $("".placeOrder"").click(function(e){

          var myData = $(""#checkoutForm"").serialize()
          console.log(myData)
          $.ajax({
              url: ""/Products/Checkout"",
              method: ""post"",
              data: myData,
              success: function () {
                  window.location.reload()
              }
          })

          e.preventDefault()
      })
    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.UserManager<AppUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckoutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
