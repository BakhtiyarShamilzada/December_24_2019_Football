#pragma checksum "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f87869cde64d6d0cbc237d905a7738dbcc62f48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FootballPlayerGameTime_Update), @"mvc.1.0.view", @"/Views/FootballPlayerGameTime/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FootballPlayerGameTime/Update.cshtml", typeof(AspNetCore.Views_FootballPlayerGameTime_Update))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f87869cde64d6d0cbc237d905a7738dbcc62f48", @"/Views/FootballPlayerGameTime/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d91fdcc959dfe0ec553e0ca60d1a3ac86e6bad", @"/Views/_ViewImports.cshtml")]
    public class Views_FootballPlayerGameTime_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GameTime", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
  
    ViewData["Title"] = "Update";

#line default
#line hidden
            BeginContext(64, 52, true);
            WriteLiteral("\r\n<section id=\"home\">\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 8 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
         if (TempData["Operation"] != null)
        {

#line default
#line hidden
            BeginContext(172, 515, true);
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
#line 20 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
        }

#line default
#line hidden
            BeginContext(698, 302, true);
            WriteLiteral(@"        <div class=""row pt-3"">
            <div class=""col-12"">
                <h3 class=""mb-0 text-center"">Update Football Player in Game time</h3>
            </div>
        </div>
        <div class=""row py-3"">
            <div class=""col-12 d-flex justify-content-between"">
                ");
            EndContext();
            BeginContext(1000, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ed5e85c6ace400f87be32c9f44da5fe", async() => {
                BeginContext(1072, 42, true);
                WriteLiteral("<i class=\"fas fa-long-arrow-alt-left\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1118, 46, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(1164, 3026, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "764a13ff58324d78b708f6c09172567e", async() => {
                BeginContext(1184, 685, true);
                WriteLiteral(@"
            <div class=""row py-3"">
                <div class=""col-12"">
                    <table class=""table table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th scope=""col"">Number</th>
                                <th scope=""col"">Select</th>
                                <th scope=""col"">Firstname</th>
                                <th scope=""col"">Lastname</th>
                                <th scope=""col"">Age</th>
                                <th scope=""col"">Position</th>
                            </tr>
                        </thead>
                        <tbody>
");
                EndContext();
#line 46 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
                              
                                int counter = 0;
                                foreach (var item in Model.FootballPlayers)
                                {

#line default
#line hidden
                BeginContext(2063, 98, true);
                WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
                EndContext();
                BeginContext(2163, 9, false);
#line 51 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
                                                    Write(++counter);

#line default
#line hidden
                EndContext();
                BeginContext(2173, 143, true);
                WriteLiteral("</th>\r\n                                        <td>\r\n                                            <div class=\"custom-control custom-checkbox\">\r\n");
                EndContext();
#line 54 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
                                                 if (Model.FootballPlayerGameTimes.Where(fpg => fpg.FootballPlayerId == item.Id).Count() != 0)
                                                {

#line default
#line hidden
                BeginContext(2511, 85, true);
                WriteLiteral("                                                    <input data-football-players-id=\"");
                EndContext();
                BeginContext(2597, 7, false);
#line 56 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
                                                                                Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(2604, 74, true);
                WriteLiteral("\" type=\"checkbox\" checked class=\"custom-control-input football-players-id\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2678, "\"", 2704, 2);
                WriteAttributeValue("", 2683, "customCheck", 2683, 11, true);
#line 56 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
WriteAttributeValue("", 2694, counter, 2694, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2705, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 57 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
                BeginContext(2864, 85, true);
                WriteLiteral("                                                    <input data-football-players-id=\"");
                EndContext();
                BeginContext(2950, 7, false);
#line 60 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
                                                                                Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(2957, 66, true);
                WriteLiteral("\" type=\"checkbox\" class=\"custom-control-input football-players-id\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3023, "\"", 3049, 2);
                WriteAttributeValue("", 3028, "customCheck", 3028, 11, true);
#line 60 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
WriteAttributeValue("", 3039, counter, 3039, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3050, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 61 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
                                                }

#line default
#line hidden
                BeginContext(3104, 100, true);
                WriteLiteral("                                                <label class=\"custom-control-label pointer-checkbox\"");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 3204, "\"", 3231, 2);
                WriteAttributeValue("", 3210, "customCheck", 3210, 11, true);
#line 62 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
WriteAttributeValue("", 3221, counter, 3221, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3232, 154, true);
                WriteLiteral("></label>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td>");
                EndContext();
                BeginContext(3387, 14, false);
#line 65 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
                                       Write(item.Firstname);

#line default
#line hidden
                EndContext();
                BeginContext(3401, 51, true);
                WriteLiteral("</td>\r\n                                        <td>");
                EndContext();
                BeginContext(3453, 13, false);
#line 66 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
                                       Write(item.Lastname);

#line default
#line hidden
                EndContext();
                BeginContext(3466, 51, true);
                WriteLiteral("</td>\r\n                                        <td>");
                EndContext();
                BeginContext(3518, 8, false);
#line 67 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
                                       Write(item.Age);

#line default
#line hidden
                EndContext();
                BeginContext(3526, 51, true);
                WriteLiteral("</td>\r\n                                        <td>");
                EndContext();
                BeginContext(3578, 65, false);
#line 68 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
                                       Write(Model.Positions.FirstOrDefault(p => p.Id == item.PositionId).Name);

#line default
#line hidden
                EndContext();
                BeginContext(3643, 50, true);
                WriteLiteral("</td>\r\n                                    </tr>\r\n");
                EndContext();
#line 70 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
                                }
                            

#line default
#line hidden
                BeginContext(3759, 189, true);
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group d-flex justify-content-end\">\r\n                ");
                EndContext();
                BeginContext(3948, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73ef470ae13f4a80a71ff5cb4fe65a6d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 77 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FootballPlayersId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4006, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(4024, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51d84ef091e74027a8784656c7789627", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 78 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\FootballPlayerGameTime\Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.GameTimeId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4075, 108, true);
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-success\"> Edit</button>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4190, 26, true);
            WriteLiteral("\r\n    </div>\r\n</section>\r\n");
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
