#pragma checksum "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc18dabf3311dac6ee0de09207d05f0888073594"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customers_Views_MyFavourite_Index), @"mvc.1.0.view", @"/Areas/Customers/Views/MyFavourite/Index.cshtml")]
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
#line 1 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\_ViewImports.cshtml"
using WebSite.EndPoint;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\_ViewImports.cshtml"
using WebSite.EndPoint.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
using Application.Catalogs.CatalohItems.CatalogItemServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
using Application.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc18dabf3311dac6ee0de09207d05f0888073594", @"/Areas/Customers/Views/MyFavourite/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62ee0a0cb6668523ee8e2a13b58077c50bd2301a", @"/Areas/Customers/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Customers_Views_MyFavourite_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedItemsDto<FavouriteCatalogItemDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-add-to-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
  
    ViewData["Title"] = "لیست علاقه‌مندی‌ها";
    Layout = "~/Views/Shared/_LayoutCustomerPanel.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"shadow-around\">\r\n    <div class=\"listing-items row\">\r\n\r\n");
#nullable restore
#line 15 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
         foreach (var item in Model.Data)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-6 px-0\">\r\n                <div class=\"product-card product-card-horizontal\">\r\n                    <div class=\"product-card-top\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 571, "\"", 578, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"product-image\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 636, "\"", 653, 1);
#nullable restore
#line 21 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
WriteAttributeValue("", 642, item.Image, 642, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 654, "\"", 670, 1);
#nullable restore
#line 21 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
WriteAttributeValue("", 660, item.Name, 660, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                        <div class=""product-card-actions"">
                            <button class=""add-to-wishlist added""><i class=""fas fa-heart""></i></button>
                            <button class=""add-to-compare""><i class=""fas fa-random""></i></button>
                        </div>
                    </div>
                    <div class=""product-card-middle"">
                        <div class=""ratings-container"">
                            <div class=""ratings"">
");
#nullable restore
#line 31 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
                                   int rate = item.Rate * 20; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"ratings-val\"");
            BeginWriteAttribute("style", " style=\"", 1312, "\"", 1334, 3);
            WriteAttributeValue("", 1320, "width:", 1320, 6, true);
#nullable restore
#line 32 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
WriteAttributeValue(" ", 1326, rate, 1327, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1332, "%;", 1332, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                            </div>\r\n                        </div>\r\n                        <h6 class=\"product-name\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc18dabf3311dac6ee0de09207d05f08880735948067", async() => {
                WriteLiteral("\r\n                                ");
#nullable restore
#line 37 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </h6>\r\n                        <div class=\"product-price product-price-clone\">650,000 تومان</div>\r\n                    </div>\r\n                    <div class=\"product-card-bottom\">\r\n");
#nullable restore
#line 43 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
                         if (item.AvailableStock > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"product-price\">\r\n                                ");
#nullable restore
#line 46 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
                           Write(item.Price.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  تومان\r\n                            </div>\r\n");
#nullable restore
#line 48 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"product-price\">\r\n                                <b class=\"text-danger\">ناموجود </b>\r\n                            </div>\r\n");
#nullable restore
#line 54 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc18dabf3311dac6ee0de09207d05f088807359412447", async() => {
                WriteLiteral("\r\n                            <i class=\"fad fa-cart-plus\"></i>\r\n                            مشاهده محصول\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 62 "D:\MyProje\ASP.Net\Shop_MVC_Core\WebSite.EndPoint\Areas\Customers\Views\MyFavourite\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedItemsDto<FavouriteCatalogItemDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591