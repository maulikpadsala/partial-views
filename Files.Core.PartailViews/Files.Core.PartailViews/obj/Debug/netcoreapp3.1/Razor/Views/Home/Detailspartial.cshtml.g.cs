#pragma checksum "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Detailspartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25adca3379511cfba98b22acc2fc92f9196a929d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detailspartial), @"mvc.1.0.view", @"/Views/Home/Detailspartial.cshtml")]
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
#line 1 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Detailspartial.cshtml"
using Files.Core.PartailViews.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25adca3379511cfba98b22acc2fc92f9196a929d", @"/Views/Home/Detailspartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bda56ed2381f2334b01f2742ab63912c9009f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detailspartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Films>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div style=\"border: 1px solid black; margin: 15px; font-size:15px\">\r\n    <h2>");
#nullable restore
#line 4 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Detailspartial.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    <time><b>Duration:</b> ");
#nullable restore
#line 6 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Detailspartial.cshtml"
                      Write(Model.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</time>\r\n\r\n    <p><b>Description:</b> ");
#nullable restore
#line 8 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Detailspartial.cshtml"
                      Write(Model.Discritption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n</div>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
#nullable restore
#line 12 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Detailspartial.cshtml"
                                     Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
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
