#pragma checksum "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Views\Shared\Components\CitySummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ccc7a56ae58bd89307c4b68278e7797de8c3561"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CitySummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CitySummary/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ccc7a56ae58bd89307c4b68278e7797de8c3561", @"/Views/Shared/Components/CitySummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c96481a4dbfd7440afa72b846a2b9afa4ce18d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CitySummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CityViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("colspan", new global::Microsoft.AspNetCore.Html.HtmlString("2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::ExampleWebApp.TagHelpers.TableFooterSelector __ExampleWebApp_TagHelpers_TableFooterSelector;
        private global::ExampleWebApp.TagHelpers.CellTagHelper __ExampleWebApp_TagHelpers_CellTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("table", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ccc7a56ae58bd89307c4b68278e7797de8c35614058", async() => {
                WriteLiteral("\r\n    <thead>\r\n        <tr>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("th", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ccc7a56ae58bd89307c4b68278e7797de8c35614344", async() => {
                    WriteLiteral("Cities Summary");
                }
                );
                __ExampleWebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.CellTagHelper>();
                __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_CellTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ccc7a56ae58bd89307c4b68278e7797de8c35615474", async() => {
                    WriteLiteral("Cities:");
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
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ccc7a56ae58bd89307c4b68278e7797de8c35616458", async() => {
                    WriteLiteral("\r\n                ");
#nullable restore
#line 11 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Views\Shared\Components\CitySummary\Default.cshtml"
           Write(Model.Cities);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            ");
                }
                );
                __ExampleWebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.CellTagHelper>();
                __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_CellTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </tr>\r\n        <tr>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ccc7a56ae58bd89307c4b68278e7797de8c35617867", async() => {
                    WriteLiteral("Population:");
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
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ccc7a56ae58bd89307c4b68278e7797de8c35618855", async() => {
                    WriteLiteral("\r\n                ");
#nullable restore
#line 17 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Views\Shared\Components\CitySummary\Default.cshtml"
           Write(Model.Population.ToString("#,###"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            ");
                }
                );
                __ExampleWebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::ExampleWebApp.TagHelpers.CellTagHelper>();
                __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_CellTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </tr>\r\n    </tbody>\r\n");
            }
            );
            __ExampleWebApp_TagHelpers_TableFooterSelector = CreateTagHelper<global::ExampleWebApp.TagHelpers.TableFooterSelector>();
            __tagHelperExecutionContext.Add(__ExampleWebApp_TagHelpers_TableFooterSelector);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 38, "table", 38, 5, true);
            AddHtmlAttributeValue(" ", 43, "table-sm", 44, 9, true);
            AddHtmlAttributeValue(" ", 52, "table-bordered", 53, 15, true);
            AddHtmlAttributeValue(" ", 67, "text-white", 68, 11, true);
            AddHtmlAttributeValue(" ", 78, "bg-", 79, 4, true);
#nullable restore
#line 3 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Views\Shared\Components\CitySummary\Default.cshtml"
AddHtmlAttributeValue("", 82, ViewBag.Theme, 82, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CityViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
