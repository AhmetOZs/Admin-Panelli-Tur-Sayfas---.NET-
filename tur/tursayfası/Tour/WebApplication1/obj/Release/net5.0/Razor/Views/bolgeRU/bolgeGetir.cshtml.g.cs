#pragma checksum "C:\tursayfası\Tour\WebApplication1\Views\bolgeRU\bolgeGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e959ef483896561d824d3efb1261a281c268b9e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_bolgeRU_bolgeGetir), @"mvc.1.0.view", @"/Views/bolgeRU/bolgeGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e959ef483896561d824d3efb1261a281c268b9e0", @"/Views/bolgeRU/bolgeGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_bolgeRU_bolgeGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.sınıflar.bolgeRU>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\tursayfası\Tour\WebApplication1\Views\bolgeRU\bolgeGetir.cshtml"
  
    ViewBag.Title = "bolgeGetir";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n<h2>Bölge Güncelleme</h2>\r\n<br />\r\n");
#nullable restore
#line 11 "C:\tursayfası\Tour\WebApplication1\Views\bolgeRU\bolgeGetir.cshtml"
 using (Html.BeginForm("bolgeGüncelle", "bolgeRU", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 14 "C:\tursayfası\Tour\WebApplication1\Views\bolgeRU\bolgeGetir.cshtml"
   Write(Html.LabelFor(x=>x.bolgeismi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "C:\tursayfası\Tour\WebApplication1\Views\bolgeRU\bolgeGetir.cshtml"
   Write(Html.TextBoxFor(x=>x.bolgeismi, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\tursayfası\Tour\WebApplication1\Views\bolgeRU\bolgeGetir.cshtml"
   Write(Html.HiddenFor(x=>x.bolgeismi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button class=\"btn btn-warning \">Güncelle</button>\r\n");
#nullable restore
#line 20 "C:\tursayfası\Tour\WebApplication1\Views\bolgeRU\bolgeGetir.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.sınıflar.bolgeRU> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
