#pragma checksum "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\JavaScriptForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ce577d33115cf37207d3b3a1aceeebe5ea174be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExampleWebApp.Pages.Pages_JavaScriptForm), @"mvc.1.0.razor-page", @"/Pages/JavaScriptForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/pages/jsform")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ce577d33115cf37207d3b3a1aceeebe5ea174be", @"/Pages/JavaScriptForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99a9098832cd4193a2678bdd569b861948b350a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_JavaScriptForm : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script type=""text/javascript"">
    async function sendRequest() {
        const token = document.cookie
            .replace(/(?:(?:^|.*;s*)XSRF-TOKEN\s*\=\s*([^;]*).*$)|^.*$/, ""$1"");

        let form = new FormData();
        form.append(""name"", ""Paddle"");
        form.append(""price"", 100);
        form.append(""categoryId"", 1);
        form.append(""supplierId"", 1);

        let response = await fetch(""");
#nullable restore
#line 14 "C:\Users\micha\Desktop\Web Development\Pro ASP.NET Core 3\ExampleWebApp\Pages\JavaScriptForm.cshtml"
                               Write(Url.Page("FormHandler"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""", {
            method: ""POST"",
            headers: { ""X-XSRF-TOKEN"": token },
            body: form
        });
        document.getElementById(""content"").innerHTML = await response.text();
    }

    document.addEventListener(""DOMContentLoaded"",
        () => document.getElementById(""submit"").onclick = sendRequest);
</script>

<button class=""btn btn-primary m-2"" id=""submit"">Submit JavaScript Form</button>
<div id=""content""></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_JavaScriptForm> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_JavaScriptForm> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_JavaScriptForm>)PageContext?.ViewData;
        public Pages_JavaScriptForm Model => ViewData.Model;
    }
}
#pragma warning restore 1591