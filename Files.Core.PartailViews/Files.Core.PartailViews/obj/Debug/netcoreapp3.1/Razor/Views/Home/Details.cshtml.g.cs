#pragma checksum "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63537b861d4dc77f24635bc876776f857db8035b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\_ViewImports.cshtml"
using Files.Core.PartailViews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\_ViewImports.cshtml"
using Files.Core.PartailViews.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Details.cshtml"
using Files.Core.PartailViews.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63537b861d4dc77f24635bc876776f857db8035b", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bda56ed2381f2334b01f2742ab63912c9009f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Films>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 10 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Details.cshtml"
Write(Html.Partial("Detailspartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Films> Html { get; private set; }
    }
}
#pragma warning restore 1591
