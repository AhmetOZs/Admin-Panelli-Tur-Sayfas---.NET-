#pragma checksum "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d79ab191ae996a06ac6216d983d55a11cebb5989"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Yorum_YorumGetir), @"mvc.1.0.view", @"/Views/Yorum/YorumGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d79ab191ae996a06ac6216d983d55a11cebb5989", @"/Views/Yorum/YorumGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Yorum_YorumGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.sınıflar.Yorum>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
  
    ViewBag.Title = "YorumGetir";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h2>Ana başlık Güncelleme Ekranı</h2>\r\n<br />\r\n");
#nullable restore
#line 10 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
 using (Html.BeginForm("YorumGüncelle", "Yorum", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\">\r\n    ");
#nullable restore
#line 13 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
Write(Html.HiddenFor(x => x.YorumID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   \r\n\r\n   <br/>\r\n    <br />\r\n    ");
#nullable restore
#line 18 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
Write(Html.LabelFor(x => x.tur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 19 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
Write(Html.TextBoxFor(x => x.tur, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 21 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
Write(Html.LabelFor(x => x.ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 22 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
Write(Html.TextBoxFor(x => x.ad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 24 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
Write(Html.LabelFor(x => x.soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 25 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
Write(Html.TextBoxFor(x => x.soyad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 27 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
Write(Html.LabelFor(x => x.yorum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 28 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
Write(Html.TextBoxFor(x => x.yorum, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 30 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
Write(Html.LabelFor(x => x.puan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 31 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
Write(Html.TextBoxFor(x => x.puan, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 34 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
Write(Html.LabelFor(x => x.resim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <input type=\"file\"");
            BeginWriteAttribute("src", " src=\"", 1021, "\"", 1039, 1);
#nullable restore
#line 35 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
WriteAttributeValue("", 1027, Model.resim, 1027, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"fileImg\"/>\r\n    <br/>\r\n    <br/>\r\n    \r\n    \r\n    <button class=\"btn btn-default\" style=\"background-color:yellowgreen\">Güncelle</button>\r\n\r\n</div>\r\n");
#nullable restore
#line 43 "C:\tursayfası\Tour\WebApplication1\Views\Yorum\YorumGetir.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.sınıflar.Yorum> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
