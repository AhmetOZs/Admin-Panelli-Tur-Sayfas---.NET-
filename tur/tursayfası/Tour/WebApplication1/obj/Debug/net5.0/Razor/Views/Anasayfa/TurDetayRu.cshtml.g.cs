#pragma checksum "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74c9fa915f39e101d7d911457adb08dbefad3659"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_TurDetayRu), @"mvc.1.0.view", @"/Views/Anasayfa/TurDetayRu.cshtml")]
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
#line 1 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
using WebApplication1.Models.sınıflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c9fa915f39e101d7d911457adb08dbefad3659", @"/Views/Anasayfa/TurDetayRu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Anasayfa_TurDetayRu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TurlarRU>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Anasayfa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TurDetayRu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search divider-skew"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
  
    ViewData["Title"] = "TurDetayEn";
    Layout = "~/Views/Shared/enfooter.cshtml";
    List<turdetayRU> turdetays = ViewBag.detay ?? new List<turdetayRU>();
    List<DetayGorselRU> detayGorsels = ViewBag.gorsel ?? new List<DetayGorselRU>();
    List<hizmetRU> hizmets = ViewBag.hizmet ?? new List<hizmetRU>();
     List<TurTarihRU> tarih = ViewBag.tarih ?? new List<TurTarihRU>();
    
    TurlarRU turlar = ViewBag.turlar ?? new TurlarRU();
    List<Iletisim> iletisims = ViewBag.iletisim ?? new List<Iletisim>();
    
    
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


 <div class=""content-body"">
      <section class=""page-section pt-0 pb-50"">
        <div class=""container"">
          <div class=""menu-widget with-switch mt-30 mb-30"">
            <ul class=""magic-line"">
              <li class=""current_item""><a href=""#overview"" class=""scrollto"">Обзор</a></li>
              
            </ul>
          </div>
        </div>
        <div class=""container"">
          <div id=""flex-slider"" class=""flexslider"">
            <ul class=""slides"">
");
#nullable restore
#line 33 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                 foreach (var a in detayGorsels)
                    {
                        
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("              <li><img style=\"max-height:540px; max-width:960px;  margin:auto\"");
            BeginWriteAttribute("src", " src=\"", 1308, "\"", 1327, 1);
#nullable restore
#line 37 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
WriteAttributeValue("", 1314, a.DetayResim, 1314, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ></li>\r\n");
#nullable restore
#line 38 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n          </div>\r\n          <div id=\"flex-carousel\" class=\"flexslider\">\r\n            <ul class=\"slides\">\r\n");
#nullable restore
#line 43 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                 foreach (var a in detayGorsels)
                    {
                        
                  

#line default
#line hidden
#nullable disable
            WriteLiteral("              <li><img style=\"width:162px; height:112px;\"");
            BeginWriteAttribute("src", " src=\"", 1654, "\"", 1673, 1);
#nullable restore
#line 47 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
WriteAttributeValue("", 1660, a.DetayResim, 1660, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-at2x=\"~/pic/flexslider/1@2x.jpg\" ></li>\r\n");
#nullable restore
#line 48 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n          </div>\r\n        </div>\r\n        <div class=\"container mt-30\">\r\n          <h3 class=\"mb-20\">");
#nullable restore
#line 53 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                       Write(turlar.turismi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n          <div class=\"row\">\r\n            <div class=\"col-md-8\">\r\n");
#nullable restore
#line 56 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                 foreach (var a in turdetays)

               {
                   
               

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5 style=\"color: #000;\"><span>");
#nullable restore
#line 61 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                                          Write(a.detaybaslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n              <p class=\"mb-15\">");
#nullable restore
#line 62 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                          Write(a.detayaciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 63 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("              \r\n            </div>\r\n            <div class=\"col-md-4\">\r\n              <div class=\"bg-gray-3 p-30-40\">\r\n                <ul  class=\"style-1 mb-0\">\r\n");
#nullable restore
#line 69 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                     foreach (var a in tarih.Take(10))
                            {
                                
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li >");
#nullable restore
#line 73 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                  Write(DateTime.Parse(@a.tarih).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 74 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n        <!-- section prices-->\r\n        <div id=\"prices\" class=\"container mb-50 mt-40\">\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74c9fa915f39e101d7d911457adb08dbefad365910815", async() => {
                WriteLiteral(@"
          <div class=""search-hotels room-search pattern"">
            <div class=""search-room-title"">
              <h5>
Выберите дату тура</h5>
            </div>
            <div class=""tours-container"">
              <div class=""tours-box"">
                <div class=""tours-search mb-20"">
              
                  <div class=""tours-calendar divider-skew""> 
                   <input placeholder=""
Дата тура"" name=""date"" id=""date"" type=""text"" onfocus=""(this.type='date')"" onblur=""(this.type='text')"" class=""calendar-default textbox-n""><i class=""flaticon-suntour-calendar calendar-icon""></i>
                  </div>
               
                   <div class=""selection-box""><i class=""flaticon-suntour-adult box-icon""></i>
                        <select name=""adults"" id=""adults"">
                          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74c9fa915f39e101d7d911457adb08dbefad365911947", async() => {
                    WriteLiteral("Человек");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74c9fa915f39e101d7d911457adb08dbefad365912989", async() => {
                    WriteLiteral("6");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74c9fa915f39e101d7d911457adb08dbefad365914025", async() => {
                    WriteLiteral("12");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    
                        </select>
                      </div>
                 
                  <button style=""background-color:#ffc107;  "" type=""submit"" class=""button-search"">
Поиск</button>
                </div>
              </div>
            </div>
          </div>
          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
          <div class=""room-table"">
            <table class=""table alt-2"">
              <thead>
                <tr>
                  <th>
Название тура</th>
                  <th>
квота</th>
                  <th>
Опции</th>
                  <th>
Цена</th>
                  
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td> <img style=""max-width:200px;""");
            BeginWriteAttribute("src", " src=\"", 4628, "\"", 4652, 1);
#nullable restore
#line 130 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
WriteAttributeValue("", 4634, turlar.girisresim, 4634, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-at2x=\"");
#nullable restore
#line 130 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                                                                                    Write(turlar.girisresim);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" alt>\r\n                    <h6>");
#nullable restore
#line 131 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                   Write(turlar.turismi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                   
                  </td>
                  <td> 
                    <div class=""table-icon""><i class=""flaticon-people""></i><i class=""flaticon-people""></i><i class=""flaticon-people""></i><i class=""flaticon-people""></i><i class=""flaticon-people""></i></div>
                    <p>");
#nullable restore
#line 136 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                  Write(turlar.kontejyan);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\nчеловек</p>\r\n                  </td>\r\n                  <td> \r\n                    <ul class=\"style-1\">\r\n");
#nullable restore
#line 141 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                         foreach (var a in hizmets)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <li><h6>");
#nullable restore
#line 143 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                         Write(a.hizmetad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</h6> <br>");
#nullable restore
#line 143 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                                                Write(a.hizmetaciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (+");
#nullable restore
#line 143 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                                                                    Write(a.ucret);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</li>\r\n");
#nullable restore
#line 144 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                  </td>\r\n                  <td class=\"room-price\">");
#nullable restore
#line 147 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                                    Write(turlar.ucret);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  \r\n                </tr>\r\n            \r\n              </tbody>\r\n            </table>\r\n          </div>\r\n        </div>\r\n        <!-- section location-->\r\n");
#nullable restore
#line 156 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
         foreach (var a in iletisims)
        {
            
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div id=""location"" class=""container mb-50"">
          <div class=""row"">
            <div class=""col-md-12"">
              <h4 class=""trans-uppercase mb-10"">
Расположение</h4>
              <div class=""cws_divider mb-30""></div>
              <!-- google map-->
              <div class=""map-wrapper"">
                <iframe");
            BeginWriteAttribute("src", " src=\"", 6064, "\"", 6078, 1);
#nullable restore
#line 168 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
WriteAttributeValue("", 6070, a.konum, 6070, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 6079, "\"", 6097, 0);
            EndWriteAttribute();
            WriteLiteral("></iframe>\r\n              </div>\r\n              <ul class=\"icon inline mt-20\">\r\n                <li> <a href=\"#\">");
#nullable restore
#line 171 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                            Write(a.adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"flaticon-suntour-map\"></i></a></li>\r\n                <li> <a href=\"#\">");
#nullable restore
#line 172 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                            Write(a.telefoncep);

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"flaticon-suntour-phone\"></i></a></li>\r\n                <li> <a href=\"#\">");
#nullable restore
#line 173 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                            Write(a.telefonsabit);

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"flaticon-suntour-phone\"></i></a></li>\r\n                <li> <a href=\"#\">");
#nullable restore
#line 174 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
                            Write(a.mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"flaticon-suntour-email\"></i></a></li>\r\n              </ul>\r\n            </div>\r\n          </div>\r\n        </div>\r\n");
#nullable restore
#line 179 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurDetayRu.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </section>\r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TurlarRU>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
