#pragma checksum "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7abb4761fb3eded89a36c12f3c5084f792139894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ana_Index), @"mvc.1.0.view", @"/Views/Ana/Index.cshtml")]
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
#line 1 "C:\tursayfası\Tour\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\tursayfası\Tour\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
using WebApplication1.Models.sınıflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7abb4761fb3eded89a36c12f3c5084f792139894", @"/Views/Ana/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ana_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ana>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\" style=\"margin-top:20px; width:100%;\">\r\n    <tr>\r\n        <th>Turlar Küçük Resim</th>\r\n        <th>Yorum Arka Resim</th>\r\n        <th>Hakkımda Arka Resim</th>\r\n        \r\n        \r\n        \r\n        \r\n\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
     foreach (var k in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            \r\n           \r\n            <td> <img");
            BeginWriteAttribute("src", " src=\"", 503, "\"", 528, 1);
#nullable restore
#line 25 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
WriteAttributeValue("", 509, k.TurlarKucukResim, 509, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px; height:80px;\"/></td>\r\n            <td> <img");
            BeginWriteAttribute("src", " src=\"", 593, "\"", 616, 1);
#nullable restore
#line 26 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
WriteAttributeValue("", 599, k.YorumArkaResim, 599, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px; height:80px;\"/></td>\r\n            <td> <img");
            BeginWriteAttribute("src", " src=\"", 681, "\"", 707, 1);
#nullable restore
#line 27 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
WriteAttributeValue("", 687, k.HakkimdaArkaResim, 687, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px; height:80px;\"/></td>\r\n           \r\n         \r\n            \r\n            \r\n        \r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 827, "\"", 877, 1);
#nullable restore
#line 33 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
WriteAttributeValue("", 834, Url.Action("AnaGetir","Ana",new {id=k.ID}), 834, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n        \r\n          </tr>\r\n");
#nullable restore
#line 36 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>
<br />  
<br /> 
<br /> 
<table class=""table table-bordered"" style=""margin-top:20px; width:100%;"">
    <tr>
        <th>Turlar Açıklama TR</th>
        <th>Turlar Açıklama EN</th>
        <th>Turlar Açıklama RU</th>
        <th>Galeri Açıklama TR</th>
        <th>Galeri Açıklama EN</th>
        <th>Galeri Açıklama RU</th>
        
        
        

    </tr>
");
#nullable restore
#line 54 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
     foreach (var k in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            \r\n           \r\n            <td> ");
#nullable restore
#line 60 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
            Write(k.TurlarAcıklamaTR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 61 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
            Write(k.TurlarAcıklamaEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 62 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
            Write(k.TurlarAcıklamaRU);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 63 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
            Write(k.GaleriAcıklamaTR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 64 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
            Write(k.GaleriAcıklamaEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 65 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
            Write(k.GaleriAcıklamaRU);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n            \r\n            \r\n        \r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 1745, "\"", 1795, 1);
#nullable restore
#line 70 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
WriteAttributeValue("", 1752, Url.Action("AnaGetir","Ana",new {id=k.ID}), 1752, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n        \r\n          </tr>\r\n");
#nullable restore
#line 73 "C:\tursayfası\Tour\WebApplication1\Views\Ana\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ana>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
