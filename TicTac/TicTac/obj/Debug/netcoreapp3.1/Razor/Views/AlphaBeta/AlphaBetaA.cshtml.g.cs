#pragma checksum "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d620d289744d62fabf982d874c805631090d0005"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AlphaBeta_AlphaBetaA), @"mvc.1.0.view", @"/Views/AlphaBeta/AlphaBetaA.cshtml")]
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
#line 1 "C:\Users\XX\source\repos\TicTac\TicTac\Views\_ViewImports.cshtml"
using TicTac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\XX\source\repos\TicTac\TicTac\Views\_ViewImports.cshtml"
using TicTac.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d620d289744d62fabf982d874c805631090d0005", @"/Views/AlphaBeta/AlphaBetaA.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"220c60ced84943470facc918dea4f0313d9a4271", @"/Views/_ViewImports.cshtml")]
    public class Views_AlphaBeta_AlphaBetaA : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicTac.ViewModel.AlphaBetaVM>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
  
    ViewData["Title"] = "AlphaBetaA";
    int brojac = 0;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d620d289744d62fabf982d874c805631090d00053294", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 7 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.isLeaf);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<input id=\"playerID\"");
            BeginWriteAttribute("value", " value=", 162, "", 182, 1);
#nullable restore
#line 8 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
WriteAttributeValue("", 169, Model.player, 169, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d620d289744d62fabf982d874c805631090d00055410", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 9 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.heuristic);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d620d289744d62fabf982d874c805631090d00057143", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 10 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.player);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d620d289744d62fabf982d874c805631090d00058874", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 11 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.playerScore);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d620d289744d62fabf982d874c805631090d000510610", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 12 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.compScore);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d620d289744d62fabf982d874c805631090d000512345", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 13 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.equalScore);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
 for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"square\" onclick=\"alphaBetaReset()\">\r\n");
#nullable restore
#line 19 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
             if (Model.array[brojac] != '0')
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input");
            BeginWriteAttribute("id", " id=", 597, "", 618, 1);
#nullable restore
#line 21 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
WriteAttributeValue("", 601, "index"+brojac, 601, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 618, "", 645, 1);
#nullable restore
#line 21 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
WriteAttributeValue("", 625, Model.array[brojac], 625, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n                <p style=\"font-size:60px; text-align:center\">");
#nullable restore
#line 22 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
                                                        Write(Model.array[brojac]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 23 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"width:100%;height:100%;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 844, "\"", 872, 3);
            WriteAttributeValue("", 854, "alphaBeta(", 854, 10, true);
#nullable restore
#line 26 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
WriteAttributeValue("", 864, brojac, 864, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 871, ")", 871, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <input");
            BeginWriteAttribute("id", " id=", 904, "", 925, 1);
#nullable restore
#line 28 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
WriteAttributeValue("", 908, "index"+brojac, 908, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 925, "", 952, 1);
#nullable restore
#line 28 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
WriteAttributeValue("", 932, Model.array[brojac], 932, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 32 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
        brojac++;
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table>
    <tr>
        <td style=""padding:10px; text-align:center;"">Player</td>
        <td style=""padding:10px; text-align:center;"">Draw</td>
        <td style=""padding:10px;text-align:center;"">Computer</td>
    </tr>
    <tr>
        <td style=""padding:10px;text-align:center;""><input id=""playerScoreID""");
            BeginWriteAttribute("value", " value=", 1362, "", 1387, 1);
#nullable restore
#line 42 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
WriteAttributeValue("", 1369, Model.playerScore, 1369, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly/></td>\r\n        <td style=\"padding:10px;text-align:center;\"><input id=\"equalScoreID\"");
            BeginWriteAttribute("value", " value=", 1481, "", 1505, 1);
#nullable restore
#line 43 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
WriteAttributeValue("", 1488, Model.equalScore, 1488, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly/></td>\r\n        <td style=\"padding:10px;text-align:center;\"><input id=\"compScoreID\"");
            BeginWriteAttribute("value", " value=", 1598, "", 1621, 1);
#nullable restore
#line 44 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\AlphaBetaA.cshtml"
WriteAttributeValue("", 1605, Model.compScore, 1605, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly/></td>\r\n    </tr>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TicTac.ViewModel.AlphaBetaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
