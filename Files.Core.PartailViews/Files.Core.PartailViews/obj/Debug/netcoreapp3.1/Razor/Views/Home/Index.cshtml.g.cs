#pragma checksum "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77314492a1181326901f3de761ecae65137b8699"
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
#line 1 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Index.cshtml"
using Files.Core.PartailViews.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77314492a1181326901f3de761ecae65137b8699", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bda56ed2381f2334b01f2742ab63912c9009f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>List of Films</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Title</th>\r\n");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Index.cshtml"
         foreach (var Filmes in Films.ListofFilms())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Index.cshtml"
               Write(Filmes.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                <td>");
#nullable restore
#line 23 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = Filmes.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "F:\Harpal\Proj\Files.Core.PartailViews\Files.Core.PartailViews\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IFilms Films { get; private set; }
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
