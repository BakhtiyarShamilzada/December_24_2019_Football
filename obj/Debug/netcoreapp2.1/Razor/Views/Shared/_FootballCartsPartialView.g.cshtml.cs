#pragma checksum "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d563bd661caab92451d6b504a85d979c9495d9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FootballCartsPartialView), @"mvc.1.0.view", @"/Views/Shared/_FootballCartsPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FootballCartsPartialView.cshtml", typeof(AspNetCore.Views_Shared__FootballCartsPartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d563bd661caab92451d6b504a85d979c9495d9a", @"/Views/Shared/_FootballCartsPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d91fdcc959dfe0ec553e0ca60d1a3ac86e6bad", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FootballCartsPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FootballCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Düzəliş et"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DeleteFootballCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Sil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
  
    int counter = 1;
    foreach (var item in Model.FootballCarts)
    {

#line default
#line hidden
            BeginContext(102, 42, true);
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
            EndContext();
            BeginContext(146, 9, false);
#line 7 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
                        Write(counter++);

#line default
#line hidden
            EndContext();
            BeginContext(156, 23, true);
            WriteLiteral("</th>\r\n            <td>");
            EndContext();
            BeginContext(180, 29, false);
#line 8 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
           Write(item.FootballPlayer.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(209, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(233, 28, false);
#line 9 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
           Write(item.FootballPlayer.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(261, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(285, 23, false);
#line 10 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
           Write(item.FootballPlayer.Age);

#line default
#line hidden
            EndContext();
            BeginContext(308, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(332, 80, false);
#line 11 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
           Write(Model.Positions.FirstOrDefault(c => c.Id == item.FootballPlayer.PositionId).Name);

#line default
#line hidden
            EndContext();
            BeginContext(412, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(436, 14, false);
#line 12 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
           Write(item.Cart.Name);

#line default
#line hidden
            EndContext();
            BeginContext(450, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(474, 37, false);
#line 13 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
           Write(item.Date.Date.ToString("MM.dd.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(511, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(552, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9a4ab23e4194f1ebc9063c92cc06e6a", async() => {
                BeginContext(685, 27, true);
                WriteLiteral("<i class=\"far fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(716, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
                 if (Model.FootballPlayers.Count() > 1)
                {

#line default
#line hidden
            BeginContext(794, 40, true);
            WriteLiteral("                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 834, "\"", 850, 1);
#line 18 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
WriteAttributeValue("", 842, item.Id, 842, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(851, 25, true);
            WriteLiteral(" />\r\n                    ");
            EndContext();
            BeginContext(876, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87e163fa6bb34b51ae9fb153c18d4a4f", async() => {
                BeginContext(990, 33, true);
                WriteLiteral(" <i class=\"far fa-trash-alt\"></i>");
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
#line 19 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1027, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
                }

#line default
#line hidden
            BeginContext(1048, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 23 "C:\Users\Bakht\OneDrive\Desktop\GTS\December_24_2019_Football\December_24_2019_Football\Views\Shared\_FootballCartsPartialView.cshtml"
    }

#line default
#line hidden
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
