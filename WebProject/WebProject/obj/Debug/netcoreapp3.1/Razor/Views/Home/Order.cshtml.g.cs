#pragma checksum "C:\Users\eleen\source\repos\WebProject\WebProject\Views\Home\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ab0efa763715d6087de6f0e2674ce7565bf6a75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Order), @"mvc.1.0.view", @"/Views/Home/Order.cshtml")]
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
#line 2 "C:\Users\eleen\source\repos\WebProject\WebProject\Views\_ViewImports.cshtml"
using WebProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eleen\source\repos\WebProject\WebProject\Views\_ViewImports.cshtml"
using WebProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ab0efa763715d6087de6f0e2674ce7565bf6a75", @"/Views/Home/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba9efdd06f4e218db319a86e094c993be7cce083", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\eleen\source\repos\WebProject\WebProject\Views\Home\Order.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Order</h1>

<div class=""container"">
    <div class=""row"">
        <h2 class=""text-center"">Thank You for your order.</h2>
        <div class=""col-lg-10"">
            <p>Your Labtop will be available to you soon.</p>
        </div>
        <div class=""col-lg-10"">
            <p> <a href=""/Home/Products"" class=""btn btn-lg btn-primary"">Continue Shopping</a></p>
        </div>
    </div>
</div>
");
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
