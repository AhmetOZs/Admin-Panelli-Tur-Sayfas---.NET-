#pragma checksum "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "033e9cc86c61aa7284dfbc9cccea7b96c0a30ee0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_TurlarEn), @"mvc.1.0.view", @"/Views/Anasayfa/TurlarEn.cshtml")]
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
#line 1 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
using WebApplication1.Models.sınıflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033e9cc86c61aa7284dfbc9cccea7b96c0a30ee0", @"/Views/Anasayfa/TurlarEn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Anasayfa_TurlarEn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Turlar>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Anasayfa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TurlarEn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search divider-skew"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
  
    ViewData["Title"] = "TurlarEn";
    Layout = "~/Views/Shared/enfooter.cshtml";
    List<bolge> bolges = ViewBag.bolge ?? new List<bolge>();
     List<TurTarih> turTarihs = ViewBag.tarih ?? new List<TurTarih>();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-body"">
      <div class=""container page"">
        <div class=""row"">
          <div class=""search-tours-wrap"">
              <div class=""search-tours-tabs"">
                <div class=""search-tabs-wrap"">
                  <div data-tours-cat=""tab-cat-1"" class=""tours-tab-btn active""><span>Tours</span><i style=""padding:10px; color:#ffc107;""  class="" flaticon-suntour-world""></i></div>
                  </div>
              </div>
              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "033e9cc86c61aa7284dfbc9cccea7b96c0a30ee06037", async() => {
                WriteLiteral("\r\n              <div class=\"search-tours-content\">\r\n                <div data-tours-cat=\"tab-cat-1\" class=\"tours-container active\">\r\n                  <div class=\"tours-box\">\r\n                    <div class=\"tours-search\">\r\n                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "033e9cc86c61aa7284dfbc9cccea7b96c0a30ee06557", async() => {
                    WriteLiteral(@"
                        <div style=""width:200px;"" class=""search-wrap"">
                          <div class=""selection-box""><i class=""flaticon-suntour-map box-icon""></i>
                        <select onchange=""myFunction()"" name=""search"" id=""tarihfunc""><!--onchange ve id lazım -->
                           
");
#nullable restore
#line 29 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
                            foreach (var a in bolges)
                                                    {
                                                            
                                                       

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "033e9cc86c61aa7284dfbc9cccea7b96c0a30ee07599", async() => {
#nullable restore
#line 33 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
                                   Write(a.bolgeismi);

#line default
#line hidden
#nullable disable
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
                    WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                       </select>\r\n                        </div>\r\n                      </div>\r\n                      ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    
                      <div style=""width:200px;"" class=""search-wrap"">
                          <div class=""selection-box""><i class=""flaticon-suntour-calendar box-icon""></i>
                       <select  name=""date"" id=""date"">
                           
");
#nullable restore
#line 44 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
                            foreach (var a in turTarihs)
                                                    {
                                                            
                                                       

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "033e9cc86c61aa7284dfbc9cccea7b96c0a30ee011247", async() => {
#nullable restore
#line 48 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
                                     Write(a.tarih);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                       </select>
                        </div>
                      </div>
                      
                      <div class=""selection-box""><i class=""flaticon-suntour-adult box-icon""></i>
                        <select name=""adults"" id=""adults"">
                          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "033e9cc86c61aa7284dfbc9cccea7b96c0a30ee012964", async() => {
                    WriteLiteral("Person");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "033e9cc86c61aa7284dfbc9cccea7b96c0a30ee014005", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "033e9cc86c61aa7284dfbc9cccea7b96c0a30ee015041", async() => {
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
                      <button style=""background-color:#000000; width:50px; "" type=""submit"" class=""button-search"">Search</button>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <br />\r\n            <br />\r\n           <div class=\"row\">\r\n");
#nullable restore
#line 73 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
                foreach (var a in Model)
                {
                    
               

#line default
#line hidden
#nullable disable
            WriteLiteral("          <!-- Recomended item-->\r\n          <div class=\"col-md-6\">\r\n            <div class=\"recom-item border\">\r\n              <div class=\"recom-media\"><a");
            BeginWriteAttribute("href", " href=\"", 3673, "\"", 3733, 1);
#nullable restore
#line 80 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
WriteAttributeValue("", 3680, Url.Action("TurDetayEn","Anasayfa",new {id=a.turID}), 3680, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                  <div  class=\"pic\"><img style=\"width:511px;height: 350px\"");
            BeginWriteAttribute("src", " src=\"", 3811, "\"", 3830, 1);
#nullable restore
#line 81 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
WriteAttributeValue("", 3817, a.girisresim, 3817, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-at2x=\"");
#nullable restore
#line 81 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
                                                                                                     Write(a.girisresim);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" alt></div></a>\r\n                <div class=\"location\"><i class=\"flaticon-suntour-map\"></i> ");
#nullable restore
#line 82 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
                                                                      Write(a.sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Turkey</div>\r\n              </div>\r\n              <!-- Recomended Content-->\r\n              <div class=\"recom-item-body\"><a href=\"hotels-details.html\">\r\n                  <h6 class=\"blog-title\">");
#nullable restore
#line 86 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
                                    Write(a.turismi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></a>\r\n                \r\n                <div class=\"recom-price\"><span class=\"font-4\">");
#nullable restore
#line 88 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
                                                         Write(a.ucret);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> per person</div>\r\n                <p class=\"mb-30\"></p><a");
            BeginWriteAttribute("href", " href=\"", 4327, "\"", 4387, 1);
#nullable restore
#line 89 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
WriteAttributeValue("", 4334, Url.Action("TurDetayEn","Anasayfa",new {id=a.turID}), 4334, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"recom-button\">Details</a><a");
            BeginWriteAttribute("href", " href=\"", 4423, "\"", 4483, 1);
#nullable restore
#line 89 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
WriteAttributeValue("", 4430, Url.Action("TurDetayEn","Anasayfa",new {id=a.turID}), 4430, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"cws-button small alt\">Book now</a>\r\n                \r\n              </div>\r\n              <!-- Recomended Image-->\r\n            </div>\r\n          </div>\r\n          <!-- ! Recomended item-->\r\n");
#nullable restore
#line 96 "C:\tursayfası\Tour\WebApplication1\Views\Anasayfa\TurlarEn.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        </div>\r\n      </div>\r\n    \r\n    </div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
        <script>
            function myFunction(){
    var myVar = document.getElementById('tarihfunc').value;
    $.ajax({
                type: ""POST"",
                url: ""/Anasayfa/tarihEn"",//controller açılacak
                dataType: 'text',               
                data:{ name: myVar },
               //""[{""tarihID"":5,""tarih"":""2022-10-23"",""turID"":6,""turlarTR"":null}]""
                success: function (data) {
                    //$(""#btnGondert"").removeAttr(""disabled"");
                         //Clear the select list    
                            $('#date').empty();

                     $.each(JSON.parse(data), function(i, tarihobj) {
                        $('#date').append($('<option>').text(tarihobj.tarih).attr('value', tarihobj.tarih));
                    });
 
                },
                error: function (data) {
                    //$(""#btnGondert"").removeAttr(""disabled"");
                }
 
            });
}  </script>
    
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Turlar>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
