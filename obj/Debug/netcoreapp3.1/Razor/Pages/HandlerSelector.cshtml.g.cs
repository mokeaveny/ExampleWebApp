#pragma checksum "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\HandlerSelector.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61994239e671600334b53ff643b3f050525c2201"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExampleWebApp.Pages.Pages_HandlerSelector), @"mvc.1.0.razor-page", @"/Pages/HandlerSelector.cshtml")]
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
#line 2 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\_ViewImports.cshtml"
using ExampleWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\HandlerSelector.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\HandlerSelector.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61994239e671600334b53ff643b3f050525c2201", @"/Pages/HandlerSelector.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99a9098832cd4193a2678bdd569b861948b350a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_HandlerSelector : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table table-sm table-striped table-bordered"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::ExampleWebApp.TagHelpers.TableFooterSelector __ExampleWebApp_TagHelpers_TableFooterSelector;
        private global::ExampleWebApp.TagHelpers.CellTagHelper __ExampleWebApp_TagHelpers_CellTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61994239e671600334b53ff643b3f050525c22014189", async() => {
                WriteLiteral("\r\n    <link href=\"/lib/twitter-bootstrap/css/bootstrap.min.css\" rel=\"stylesheet\" />\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61994239e671600334b53ff643b3f050525c22015244", async() => {
                WriteLiteral("\r\n    <div class=\"bg-primary text-white text-center m-2 p-2\">Selector</div>\r\n    <div class=\"m-2\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("table", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61994239e671600334b53ff643b3f050525c22015616", async() => {
                    WriteLiteral("\r\n            <tbody>\r\n                <tr>");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("th", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61994239e671600334b53ff643b3f050525c22015926", async() => {
                        WriteLiteral("Name");
                    }
                    );
                    __ExampleWebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.CellTagHelper>();
                    __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_CellTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61994239e671600334b53ff643b3f050525c22016908", async() => {
#nullable restore
#line 16 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\HandlerSelector.cshtml"
                                Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __ExampleWebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.CellTagHelper>();
                    __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_CellTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("</tr>\r\n                <tr>");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("th", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61994239e671600334b53ff643b3f050525c22018153", async() => {
                        WriteLiteral("Price");
                    }
                    );
                    __ExampleWebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.CellTagHelper>();
                    __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_CellTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61994239e671600334b53ff643b3f050525c22019136", async() => {
#nullable restore
#line 17 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\HandlerSelector.cshtml"
                                 Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __ExampleWebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.CellTagHelper>();
                    __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_CellTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("</tr>\r\n                <tr>");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("th", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61994239e671600334b53ff643b3f050525c220110383", async() => {
                        WriteLiteral("Category");
                    }
                    );
                    __ExampleWebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.CellTagHelper>();
                    __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_CellTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61994239e671600334b53ff643b3f050525c220111370", async() => {
#nullable restore
#line 18 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\HandlerSelector.cshtml"
                                    Write(Model.Product.Category);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __ExampleWebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.CellTagHelper>();
                    __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_CellTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("</tr>\r\n                <tr>");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("th", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61994239e671600334b53ff643b3f050525c220112624", async() => {
                        WriteLiteral("Supplier");
                    }
                    );
                    __ExampleWebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.CellTagHelper>();
                    __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_CellTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61994239e671600334b53ff643b3f050525c220113611", async() => {
#nullable restore
#line 19 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\HandlerSelector.cshtml"
                                    Write(Model.Product.Supplier);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __ExampleWebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.CellTagHelper>();
                    __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_CellTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("</tr>\r\n            </tbody>\r\n        ");
                }
                );
                __ExampleWebApp_TagHelpers_TableFooterSelector = CreateTagHelper<global::ExampleWebApp.TagHelpers.TableFooterSelector>();
                __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_TableFooterSelector);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <a href=\"/handlerselector\" class=\"btn btn-primary\">Standard</a>\r\n        <a href=\"/handlerselector?handler=related\" class=\"btn btn-primary\">Related</a>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>  \r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\HandlerSelector.cshtml"
           
    public class HandlerSelectorModel : PageModel
    {
        private DataContext context;

        public Product Product { get; set; }

        public HandlerSelectorModel(DataContext ctx)
        {
            context = ctx;
        }

        public async Task OnGetAsync(long id = 1)
        {
            Product = await context.Products.FindAsync(id);
        }

        public async Task OnGetRelatedAsync(long id = 1)
        {
            Product = await context.Products
                .Include(p => p.Supplier)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.ProductId == id);
            Product.Supplier.Products = null;
            Product.Category.Products = null;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandlerSelectorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HandlerSelectorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HandlerSelectorModel>)PageContext?.ViewData;
        public HandlerSelectorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
