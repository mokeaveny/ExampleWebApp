#pragma checksum "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\Shared\_ProductPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6f1178c4aabbbac394b15f6f6b2a54c1dafe86d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExampleWebApp.Pages.Shared.Pages_Shared__ProductPartial), @"mvc.1.0.view", @"/Pages/Shared/_ProductPartial.cshtml")]
namespace ExampleWebApp.Pages.Shared
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
#line 2 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\_ViewImports.cshtml"
using ExampleWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6f1178c4aabbbac394b15f6f6b2a54c1dafe86d", @"/Pages/Shared/_ProductPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99a9098832cd4193a2678bdd569b861948b350a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__ProductPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"m-2\">\r\n    <table class=\"table table-sm table-striped table-bordered\">\r\n        <tbody>\r\n            <tr><th>Name</th><td>");
#nullable restore
#line 6 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\Shared\_ProductPartial.cshtml"
                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n            <tr><th>Price</th><td>");
#nullable restore
#line 7 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\Shared\_ProductPartial.cshtml"
                             Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
