#pragma checksum "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Basket\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c01bb0429da4b27176baa9596d732a67d8c9c852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Checkout), @"mvc.1.0.view", @"/Views/Basket/Checkout.cshtml")]
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
#line 1 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\_ViewImports.cshtml"
using WebSite.EndPoint;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\_ViewImports.cshtml"
using WebSite.EndPoint.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c01bb0429da4b27176baa9596d732a67d8c9c852", @"/Views/Basket/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbd009ecef93b67a26d4c2022aef763916a9c9a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Basket\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Checkout</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 10 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Basket\Checkout.cshtml"
Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
