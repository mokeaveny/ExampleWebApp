#pragma checksum "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\NotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a1bb14630b3706ae241a7f95f56aaeac357546b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExampleWebApp.Pages.Pages_NotFound), @"mvc.1.0.razor-page", @"/Pages/NotFound.cshtml")]
namespace ExampleWebApp.Pages
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
#line 3 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\NotFound.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\NotFound.cshtml"
using ExampleWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/noid")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a1bb14630b3706ae241a7f95f56aaeac357546b", @"/Pages/NotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99a9098832cd4193a2678bdd569b861948b350a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_NotFound : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1bb14630b3706ae241a7f95f56aaeac357546b3428", async() => {
                WriteLiteral("\r\n    <link href=\"/lib/twitter-bootstrap/css/bootstrap.min.css\" rel=\"stylesheet\" />\r\n    <title>Not Found</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1bb14630b3706ae241a7f95f56aaeac357546b4515", async() => {
                WriteLiteral("\r\n    <div class=\"bg-primary text-white text-center m-2 p-2\">No Matching ID</div>\r\n    <ul class=\"list-group m-2\">\r\n");
#nullable restore
#line 15 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\NotFound.cshtml"
         foreach (Product p in Model.Products)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li class=\"list-group-item\">");
#nullable restore
#line 17 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\NotFound.cshtml"
                                   Write(p.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (ID: ");
#nullable restore
#line 17 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\NotFound.cshtml"
                                                Write(p.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</li>\r\n");
#nullable restore
#line 18 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\NotFound.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\NotFound.cshtml"
            
    public class NotFoundModel : PageModel
    {
        private DataContext context;

        public IEnumerable<Product> Products { get; set; }

        public NotFoundModel(DataContext ctx)
        {
            context = ctx;
        }

        public void OnGetAsync(long id = 1)
        {
            Products = context.Products;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NotFoundModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NotFoundModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NotFoundModel>)PageContext?.ViewData;
        public NotFoundModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
