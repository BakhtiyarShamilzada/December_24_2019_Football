#pragma checksum "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf57482839aa8174abdc3533a916a2eb8f45e292"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FootballPlayer_Index), @"mvc.1.0.view", @"/Views/FootballPlayer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FootballPlayer/Index.cshtml", typeof(AspNetCore.Views_FootballPlayer_Index))]
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
#line 1 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\_ViewImports.cshtml"
using December_24_2019_Football;

#line default
#line hidden
#line 2 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\_ViewImports.cshtml"
using December_24_2019_Football.Models;

#line default
#line hidden
#line 3 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\_ViewImports.cshtml"
using December_24_2019_Football.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf57482839aa8174abdc3533a916a2eb8f45e292", @"/Views/FootballPlayer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d91fdcc959dfe0ec553e0ca60d1a3ac86e6bad", @"/Views/_ViewImports.cshtml")]
    public class Views_FootballPlayer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Düzəliş et"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DeleteFootballPlayer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Sil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(63, 52, true);
            WriteLiteral("\r\n<section id=\"home\">\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 8 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
         if (TempData["Operation"] != null)
        {

#line default
#line hidden
            BeginContext(171, 515, true);
            WriteLiteral(@"            <div class=""row pt-3"">
                <div class=""col-12"">
                    <div class=""alert alert-success alert-dismissible fade show"" role=""alert"">
                        <p class=""mb-0"">Operation successful.</p>
                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 20 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(697, 113, true);
            WriteLiteral("        <div class=\"row py-3\">\r\n            <div class=\"col-12 d-flex justify-content-between\">\r\n                ");
            EndContext();
            BeginContext(810, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa3d295b08534c599afc12368893b733", async() => {
                BeginContext(859, 42, true);
                WriteLiteral("<i class=\"fas fa-long-arrow-alt-left\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(905, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(923, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d7a979d4bdf4decb00fe30165461d64", async() => {
                BeginContext(970, 27, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1001, 654, true);
            WriteLiteral(@"
            </div>
        </div>
        <div class=""row py-3"">
            <div class=""col-12"">
                <table class=""table table-bordered table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Firstname</th>
                            <th scope=""col"">Lastname</th>
                            <th scope=""col"">Age</th>
                            <th scope=""col"">Position</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 41 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
                          
                            int counter = 1;
                            foreach (var item in Model.FootballPlayers)
                            {

#line default
#line hidden
            BeginContext(1833, 90, true);
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
            EndContext();
            BeginContext(1925, 9, false);
#line 46 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
                                                Write(counter++);

#line default
#line hidden
            EndContext();
            BeginContext(1935, 47, true);
            WriteLiteral("</th>\r\n                                    <td>");
            EndContext();
            BeginContext(1983, 14, false);
#line 47 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
                                   Write(item.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(1997, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2045, 13, false);
#line 48 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
                                   Write(item.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(2058, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2106, 8, false);
#line 49 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
                                   Write(item.Age);

#line default
#line hidden
            EndContext();
            BeginContext(2114, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2162, 18, false);
#line 50 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
                                   Write(item.Position.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2180, 89, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2269, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d361d338a04a4ec7850695e9fc4bba89", async() => {
                BeginContext(2372, 27, true);
                WriteLiteral("<i class=\"far fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2403, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
                                         if (Model.FootballPlayers.Count() > 1)
                                        {

#line default
#line hidden
            BeginContext(2529, 64, true);
            WriteLiteral("                                            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2593, "\"", 2609, 1);
#line 55 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
WriteAttributeValue("", 2601, item.Id, 2601, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2610, 49, true);
            WriteLiteral(" />\r\n                                            ");
            EndContext();
            BeginContext(2659, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d487d721e87b4769b50891c13d48974f", async() => {
                BeginContext(2775, 33, true);
                WriteLiteral(" <i class=\"far fa-trash-alt\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2812, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 57 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2857, 82, true);
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 60 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayer\Index.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(2997, 118, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591