#pragma checksum "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e94a0cee238a182a2c4680c73e7d05f7eddfe9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Views\_ViewImports.cshtml"
using ExampleWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Views\_ViewImports.cshtml"
using ExampleWebApp.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e94a0cee238a182a2c4680c73e7d05f7eddfe9c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c96481a4dbfd7440afa72b846a2b9afa4ce18d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("bg-color", "dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("theme", "primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("theme", "secondary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("theme", "info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table table-striped table-bordered table-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::ExampleWebApp.TagHelpers.SelectiveTagHelper __ExampleWebApp_TagHelpers_SelectiveTagHelper;
        private global::ExampleWebApp.TagHelpers.TableFooterSelector __ExampleWebApp_TagHelpers_TableFooterSelector;
        private global::ExampleWebApp.TagHelpers.TableHeadTagHelper __ExampleWebApp_TagHelpers_TableHeadTagHelper;
        private global::ExampleWebApp.TagHelpers.RowTagHelper __ExampleWebApp_TagHelpers_RowTagHelper;
        private global::ExampleWebApp.TagHelpers.CellTagHelper __ExampleWebApp_TagHelpers_CellTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Views\Home\Index.cshtml"
   
    Layout = "_SimpleLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e94a0cee238a182a2c4680c73e7d05f7eddfe9c5342", async() => {
                WriteLiteral("\r\n    <h5 class=\"bg-danger text-white text-center p-2\">\r\n        Warning: Expensive Item\r\n    </h5>\r\n");
            }
            );
            __ExampleWebApp_TagHelpers_SelectiveTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.SelectiveTagHelper>();
            __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_SelectiveTagHelper);
#nullable restore
#line 6 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Views\Home\Index.cshtml"
__ExampleWebApp_TagHelpers_SelectiveTagHelper.ShowWhenGt = 500;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-when-gt", __ExampleWebApp_TagHelpers_SelectiveTagHelper.ShowWhenGt, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 6 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Views\Home\Index.cshtml"
__ExampleWebApp_TagHelpers_SelectiveTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Price);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __ExampleWebApp_TagHelpers_SelectiveTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("table", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e94a0cee238a182a2c4680c73e7d05f7eddfe9c7363", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tablehead", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e94a0cee238a182a2c4680c73e7d05f7eddfe9c7626", async() => {
                    WriteLiteral("Product Summary");
                }
                );
                __ExampleWebApp_TagHelpers_TableHeadTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.TableHeadTagHelper>();
                __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_TableHeadTagHelper);
                __ExampleWebApp_TagHelpers_TableHeadTagHelper.BgColor = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <tbody>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e94a0cee238a182a2c4680c73e7d05f7eddfe9c8854", async() => {
                    WriteLiteral("\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("th", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e94a0cee238a182a2c4680c73e7d05f7eddfe9c9130", async() => {
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
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e94a0cee238a182a2c4680c73e7d05f7eddfe9c10112", async() => {
#nullable restore
#line 16 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Views\Home\Index.cshtml"
                        Write(Model.Name);

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
                    WriteLiteral("\r\n        ");
                }
                );
                __ExampleWebApp_TagHelpers_RowTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.RowTagHelper>();
                __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_RowTagHelper);
                __ExampleWebApp_TagHelpers_RowTagHelper.Theme = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e94a0cee238a182a2c4680c73e7d05f7eddfe9c12225", async() => {
                    WriteLiteral("\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("th", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e94a0cee238a182a2c4680c73e7d05f7eddfe9c12502", async() => {
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
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e94a0cee238a182a2c4680c73e7d05f7eddfe9c13486", async() => {
#nullable restore
#line 19 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Views\Home\Index.cshtml"
                         Write(Model.Price.ToString("c"));

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
                    WriteLiteral("\r\n        ");
                }
                );
                __ExampleWebApp_TagHelpers_RowTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.RowTagHelper>();
                __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_RowTagHelper);
                __ExampleWebApp_TagHelpers_RowTagHelper.Theme = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e94a0cee238a182a2c4680c73e7d05f7eddfe9c15615", async() => {
                    WriteLiteral("\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("th", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e94a0cee238a182a2c4680c73e7d05f7eddfe9c15892", async() => {
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
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e94a0cee238a182a2c4680c73e7d05f7eddfe9c16879", async() => {
#nullable restore
#line 22 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Views\Home\Index.cshtml"
                            Write(Model.CategoryId);

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
                    WriteLiteral("\r\n        ");
                }
                );
                __ExampleWebApp_TagHelpers_RowTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.RowTagHelper>();
                __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_RowTagHelper);
                __ExampleWebApp_TagHelpers_RowTagHelper.Theme = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </tbody>\r\n");
            }
            );
            __ExampleWebApp_TagHelpers_TableFooterSelector = CreateTagHelper<global::ExampleWebApp.TagHelpers.TableFooterSelector>();
            __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_TableFooterSelector);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
