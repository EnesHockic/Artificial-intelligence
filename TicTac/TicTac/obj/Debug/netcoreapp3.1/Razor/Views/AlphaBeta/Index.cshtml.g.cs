#pragma checksum "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4e3f79e5afe6120d527ddc26b6095b43baa6214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AlphaBeta_Index), @"mvc.1.0.view", @"/Views/AlphaBeta/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4e3f79e5afe6120d527ddc26b6095b43baa6214", @"/Views/AlphaBeta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"220c60ced84943470facc918dea4f0313d9a4271", @"/Views/_ViewImports.cshtml")]
    public class Views_AlphaBeta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicTac.ViewModel.AlphaBetaVM>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int brojac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .mid-square {
        height: 100px;
        width: 100px;
        border-right: 1px solid black;
        border-left: 1px solid black;
        border-bottom: 1px solid black;
        float: left;
        box-sizing: border-box;
    }
    .left-square {
        height: 100px;
        width: 100px;
        border-bottom: 1px solid black;
        float: left;
        box-sizing: border-box;
    }
    .right-square {
        height: 100px;
        width: 100px;
        border-bottom: 1px solid black;
        float: left;
        box-sizing: border-box;
    }
    .square {
        height: 100px;
        width: 100px;
        border: 1px solid black;
        float: left;
        box-sizing: border-box;
    }

    .row {
        width: 300px;
    }
    td{
        font-size:25px;
    }
</style>
<h1>Index</h1>

<div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4e3f79e5afe6120d527ddc26b6095b43baa62144402", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4e3f79e5afe6120d527ddc26b6095b43baa62144670", async() => {
                    WriteLiteral("Difficulty");
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 49 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.depth);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 49 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.depths;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div id=\"TargetDiv\" class=\"row\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4e3f79e5afe6120d527ddc26b6095b43baa62147401", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 54 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4e3f79e5afe6120d527ddc26b6095b43baa62149131", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 55 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4e3f79e5afe6120d527ddc26b6095b43baa621410861", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 56 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4e3f79e5afe6120d527ddc26b6095b43baa621412595", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 57 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4e3f79e5afe6120d527ddc26b6095b43baa621414331", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 58 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4e3f79e5afe6120d527ddc26b6095b43baa621416065", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 59 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
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
#line 60 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
     for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"square\">\r\n");
#nullable restore
#line 65 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
                 if (Model.array[brojac] != '0')
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input");
            BeginWriteAttribute("id", " id=", 1592, "", 1613, 1);
#nullable restore
#line 67 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
WriteAttributeValue("", 1596, "index"+brojac, 1596, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 1613, "", 1640, 1);
#nullable restore
#line 67 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
WriteAttributeValue("", 1620, Model.array[brojac], 1620, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n                    <p style=\"font-size:60px; text-align:center\">");
#nullable restore
#line 68 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
                                                            Write(Model.array[brojac]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 69 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"width:100%;height:100%;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1859, "\"", 1887, 3);
            WriteAttributeValue("", 1869, "alphaBeta(", 1869, 10, true);
#nullable restore
#line 72 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
WriteAttributeValue("", 1879, brojac, 1879, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1886, ")", 1886, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                        <input");
            BeginWriteAttribute("id", " id=", 1923, "", 1944, 1);
#nullable restore
#line 74 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
WriteAttributeValue("", 1927, "index"+brojac, 1927, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 1944, "", 1971, 1);
#nullable restore
#line 74 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
WriteAttributeValue("", 1951, Model.array[brojac], 1951, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n                    </div>\r\n");
#nullable restore
#line 76 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 78 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
            brojac++;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <br />
    <table>
        <tr>
            <td style=""padding:10px;text-align:center;"">Player</td>
            <td style=""padding:10px;text-align:center;"">Draw</td>
            <td style=""padding:10px;text-align:center;"">Computer</td>
        </tr>
        <tr>
            <td style=""padding:10px;text-align:center;""><input id=""playerScoreID""");
            BeginWriteAttribute("value", " value=", 2447, "", 2472, 1);
#nullable restore
#line 89 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
WriteAttributeValue("", 2454, Model.playerScore, 2454, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly/></td>\r\n            <td style=\"padding:10px;text-align:center;\"><input id=\"equalScoreID\"");
            BeginWriteAttribute("value", " value=", 2570, "", 2594, 1);
#nullable restore
#line 90 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
WriteAttributeValue("", 2577, Model.equalScore, 2577, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly/></td>\r\n            <td style=\"padding:10px;text-align:center;\"><input id=\"compScoreID\"");
            BeginWriteAttribute("value", " value=", 2691, "", 2714, 1);
#nullable restore
#line 91 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
WriteAttributeValue("", 2698, Model.compScore, 2698, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly /></td>\r\n        </tr>\r\n    </table>\r\n");
            WriteLiteral("\r\n</div>\r\n<script>\r\n    function alphaBeta(index) {\r\n        \r\n        if (document.getElementById(\"isLeaf\").value == \"true\") {\r\n            return;\r\n        }\r\n        //var Array = \"");
#nullable restore
#line 119 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
                   Write(Model.array == null ? string.Empty : string.Join("", Model.array));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
        var Array=[];
        for (var i = 0; i < 9; i++) {
            Array[i] = document.getElementById(""index""+i).value;               
        }
        if(document.getElementById(""player"").value==""MIN"")
            Array[index] = 'X';
        else
            Array[index] = 'O';
        var a = Array.join("""");
        $.ajax({
            url: '");
#nullable restore
#line 130 "C:\Users\XX\source\repos\TicTac\TicTac\Views\AlphaBeta\Index.cshtml"
             Write(Url.Action("AlphaBetaA", "AlphaBeta"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            method: 'POST',
            data: {
                stringArray: a,
                depth:$(""#depth"").val(),
                player: $(""#player"").val(),
                PlayerScore:$(""#playerScoreID"").val(),
                EqualScore:$(""#equalScoreID"").val(),
                CompScore:$(""#compScoreID"").val()
            },
            success: function (data) {
                $(""#TargetDiv"").html(data);
                
            }
        });
    }
    
    function alphaBetaReset() {
        
        if (document.getElementById(""isLeaf"").value == ""true"") {
            window.location.href = ""/AlphaBeta/Index?Depth="" + document.getElementById(""depth"").value +
                ""&player="" + document.getElementById(""playerID"").value + ""&PlayerScore="" + document.getElementById(""playerScoreID"").value +
                ""&EqualScore=""+document.getElementById(""equalScoreID"").value+""&CompScore=""+document.getElementById(""compScoreID"").value;
            
        }
    }
</sc");
            WriteLiteral("ript>\r\n");
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
