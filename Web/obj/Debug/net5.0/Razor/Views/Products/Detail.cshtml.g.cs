#pragma checksum "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb994ff931628d259c16e18665bfc38ce36f6b1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Detail), @"mvc.1.0.view", @"/Views/Products/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb994ff931628d259c16e18665bfc38ce36f6b1e", @"/Views/Products/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6391e842b62abea06a0f612747a70aafe1c06c43", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"MainDetails\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-lg-6 col-md-12 leftcl\">\n");
#nullable restore
#line 10 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Detail.cshtml"
                 foreach (var pro in Model.Product.ProductPictures)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb994ff931628d259c16e18665bfc38ce36f6b1e4430", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 309, "~/Uploads/", 309, 10, true);
#nullable restore
#line 12 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Detail.cshtml"
AddHtmlAttributeValue("", 319, pro.Picture.URL, 319, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 13 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n            <div class=\"col-lg-6 col-md-12 rightcl\">\n                <h4 class=\"proName\">");
#nullable restore
#line 16 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Detail.cshtml"
                               Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                <p class=\"tprev\">32 Reviews</p>\n                <p class=\"proPrice\">");
#nullable restore
#line 18 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Detail.cshtml"
                               Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <p class=""proAvailable"">Available: <span>In Stock</span></p>
                <div class=""qty"">
                    <div class=""input-group d-block"">
                        <span class=""input-group-btn"">
                            <button type=""button"" class=""quantity-right-plus btn "" data-type=""plus"" data-field="""">
                                <i class=""fas fa-plus""></i>
                            </button>
                        </span>
                        <input type=""text"" id=""quantity"" name=""quantity"" class=""form-control input-number"" value=""1"" min=""1"" max=""100"">
                        <span class=""input-group-btn"">
                            <button type=""button"" class=""quantity-left-minus btn "" data-type=""minus"" data-field="""">
                                <i class=""fas fa-minus""></i>
                            </button>
                        </span>
                    </div>
                </div>
                <input class=""btn"" type=""submit"" value=""ADD TO CAR");
            WriteLiteral(@"T"">
                <div class=""proSocialM"">
                    <ul>
                        <li><a class=""tweet"" href=""#""><i class=""fab fa-twitter""></i> Tweet</a></li>
                        <li><a class=""facebook"" href=""#""><i class=""fab fa-facebook-f""></i> Facebook</a></li>
                        <li><a class=""google"" href=""#""><i class=""fab fa-google-plus-g""></i> Google+</a></li>
                        <li><a class=""pinterest"" href=""#""><i class=""fab fa-pinterest""></i> Pinterest</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>

<div id=""Description"">
    <div class=""container"">
        <div class=""row"">
            <h4>Description</h4>
            <div class=""underLine""></div>
            <span>
                ");
#nullable restore
#line 55 "C:\Users\esahb\OneDrive\Desktop\Flo.-master\Web\Views\Products\Detail.cshtml"
           Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </span>\n        </div>\n    </div>\n</div>\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591