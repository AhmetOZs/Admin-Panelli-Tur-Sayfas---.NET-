#pragma checksum "C:\tursayfasÄ±\Tour\WebApplication1\Views\Shared\Adminlayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b488c71c9308c8f01ec623d4d72429f85527711d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Adminlayout), @"mvc.1.0.view", @"/Views/Shared/Adminlayout.cshtml")]
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
#line 1 "C:\tursayfasÄ±\Tour\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\tursayfasÄ±\Tour\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b488c71c9308c8f01ec623d4d72429f85527711d", @"/Views/Shared/Adminlayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Adminlayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/dist/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-md-inline-block form-inline ml-auto mr-0 mr-md-3 my-2 my-md-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/dist/js/scripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\tursayfasÄ±\Tour\WebApplication1\Views\Shared\Adminlayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b488c71c9308c8f01ec623d4d72429f85527711d5439", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 295, "\"", 305, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 334, "\"", 344, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <title>Admin Paneli</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b488c71c9308c8f01ec623d4d72429f85527711d6318", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.11.2/js/all.min.js\" crossorigin=\"anonymous\"></script>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b488c71c9308c8f01ec623d4d72429f85527711d8332", async() => {
                WriteLiteral(@"
    <nav class=""sb-topnav navbar navbar-expand navbar-dark bg-dark"" style=""position:fixed; width:100%;"">
        <a class=""navbar-brand"" href=""index.html"">Admin Panel</a><button class=""btn btn-link btn-sm order-1 order-lg-0"" id=""sidebarToggle"" href=""#"">
            <i class=""fas fa-bars""></i>
        </button><!-- Navbar Search-->
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b488c71c9308c8f01ec623d4d72429f85527711d8950", async() => {
                    WriteLiteral("\r\n          \r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <!-- Navbar-->
        <ul class=""navbar-nav ml-auto ml-md-0"">
            <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle"" id=""userDropdown"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><i class=""fas fa-user fa-fw""></i></a>
                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
                   
                    <div class=""dropdown-divider""></div>
                    <a");
                BeginWriteAttribute("class", " class=\"", 1565, "\"", 1605, 1);
#nullable restore
#line 37 "C:\tursayfasÄ±\Tour\WebApplication1\Views\Shared\Adminlayout.cshtml"
WriteAttributeValue("", 1573, Url.Action("Index", "Anasayfa"), 1573, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" href=""login.html"">ÃÄ±kÄ±Å Yap</a>
                </div>
            </li>
        </ul>
    </nav>
    <div id=""layoutSidenav"">
        <div id=""layoutSidenav_nav""style=""position:fixed; height:100%; "" >
            <nav class=""sb-sidenav accordion sb-sidenav-dark"" id=""sidenavAccordion"" >
                <div class=""sb-sidenav-menu"" >
                    <div class=""nav"">
                        <div class=""sb-sidenav-menu-heading"">Ä°Ålemler</div>
                        <ul>Ä°ngilizce sayfa 
                            <li>
                        <a class=""nav-link"" href=""/Turlar/Index"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-tachometer-alt""></i></div>
                            Turlar
                        </a>
                        </li>
                 
                        

                       
                        <li>
                        <a class=""nav-link"" href=""/hakkimizdaen/Index/"">
                            <div  class=");
                WriteLiteral(@"""sb-nav-link-icon""><i class=""fas fa-street-view""></i></div>
                            HakkÄ±mda 
                        </a>
                        </li>
                         <li>
                        <a class=""nav-link"" href=""/bolge/Index/"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-street-view""></i></div>
                            BÃ¶lge 
                        </a>
                        </li>
                        <li>
                        <a class=""nav-link"" href=""/AnaGirisEN/Index/"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-street-view""></i></div>
                            GiriÅ EkranÄ± 
                        </a>
                        </li>
                        </ul>
                        <ul>TÃ¼rkÃ§e sayfa dÃ¼zenleme
                            <li>
                        <a class=""nav-link"" href=""/TurlarTR/Index"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-t");
                WriteLiteral(@"achometer-alt""></i></div>
                            Turlar
                        </a>
                        </li>
                      
                        <li>
                        <a class=""nav-link"" href=""/hakkimizdaTR/Index/"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-street-view""></i></div>
                            HakkÄ±mda 
                        </a>
                        </li>
                         <li>
                        <a class=""nav-link"" href=""/bolgeTR/Index/"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-street-view""></i></div>
                            BÃ¶lge 
                        </a>
                        </li>
                        <li>
                        <a class=""nav-link"" href=""/AnaGirisTR/Index/"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-street-view""></i></div>
                            GiriÅ EkranÄ± 
                        </a>
");
                WriteLiteral(@"                        </li>
                        </ul>
                        <ul>RusÃ§a sayfa dÃ¼zenleme
                            <li>
                        <a class=""nav-link"" href=""/TurlarRU/Index"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-tachometer-alt""></i></div>
                            Turlar
                        </a>
                        </li>
                      
                        <li>
                        <a class=""nav-link"" href=""/hakkimizdaRU/Index/"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-street-view""></i></div>
                            HakkÄ±mda 
                        </a>
                        </li>
                        <li>
                        <a class=""nav-link"" href=""/bolgeRU/Index/"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-street-view""></i></div>
                            BÃ¶lge 
                        </a>
               ");
                WriteLiteral(@"         </li>
                        <li>
                        <a class=""nav-link"" href=""/AnaGirisRU/Index/"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-street-view""></i></div>
                            GiriÅ EkranÄ± 
                        </a>
                        </li>
                        </ul>
                        <ul>Genel DÃ¼zenlemeler

                            <li>
                                 <a class=""nav-link"" href=""/Iletisim/Index/"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-street-view""></i></div>
                            Ä°letiÅim 
                        </a>
                            </li>
                            <li>
                        <a class=""nav-link"" href=""/fotogaleri/Index/"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-street-view""></i></div>
                            Galeri 
                        </a>
                        </li>
");
                WriteLiteral(@"                          <li>
                        <a class=""nav-link"" href=""/Yorum/Index/"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-street-view""></i></div>
                            Yorum 
                        </a>
                        </li>
                         <li>
                        <a class=""nav-link"" href=""/Ana/Index/"">
                            <div class=""sb-nav-link-icon""><i class=""fas fa-street-view""></i></div>
                            Anasayfa DÃ¼zenlemeler 
                        </a>
                        </li>
                        </ul>
                        
                 </div>
                 </div>
               
            </nav>
        </div>
        <div id=""layoutSidenav_content"">
            <main style=""padding-left:250px; padding-top:50px;"">
                <div class=""container-fluid"">
                  ");
#nullable restore
#line 168 "C:\tursayfasÄ±\Tour\WebApplication1\Views\Shared\Adminlayout.cshtml"
             Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </main>
           
        </div>
    </div>
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js"" crossorigin=""anonymous""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b488c71c9308c8f01ec623d4d72429f85527711d18214", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
