#pragma checksum "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22f69e9cdbb55e1e066b180c8766469bf9f33791"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresas_Delete), @"mvc.1.0.view", @"/Views/Empresas/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empresas/Delete.cshtml", typeof(AspNetCore.Views_Empresas_Delete))]
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
#line 1 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\_ViewImports.cshtml"
using pim2;

#line default
#line hidden
#line 2 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\_ViewImports.cshtml"
using pim2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22f69e9cdbb55e1e066b180c8766469bf9f33791", @"/Views/Empresas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8823da1095977e4ad4583b955bc5d091f9b2682", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<pim2.Models.Empresa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(67, 159, true);
            WriteLiteral("\n<h2>Delete</h2>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Empresa</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(227, 40, false);
#line 15 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(267, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(308, 36, false);
#line 18 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(344, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(385, 40, false);
#line 21 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CNPJ));

#line default
#line hidden
            EndContext();
            BeginContext(425, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(466, 36, false);
#line 24 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CNPJ));

#line default
#line hidden
            EndContext();
            BeginContext(502, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(543, 44, false);
#line 27 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(587, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(628, 40, false);
#line 30 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(668, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(709, 41, false);
#line 33 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(750, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(791, 37, false);
#line 36 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(828, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(869, 44, false);
#line 39 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.endereco));

#line default
#line hidden
            EndContext();
            BeginContext(913, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(954, 40, false);
#line 42 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.endereco));

#line default
#line hidden
            EndContext();
            BeginContext(994, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1035, 42, false);
#line 45 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.numero));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1118, 38, false);
#line 48 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.numero));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1197, 42, false);
#line 51 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1280, 38, false);
#line 54 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1359, 42, false);
#line 57 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1442, 38, false);
#line 60 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(1514, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54349b0f5b8d451b8168f0a11b70eaef", async() => {
                BeginContext(1540, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1549, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "15d81bf6a58f4959a45fe8378c126488", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Empresas\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1585, 82, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\n        ");
                EndContext();
                BeginContext(1667, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9d629907dec4446b38bc0a9184f43a5", async() => {
                    BeginContext(1689, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1705, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1717, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<pim2.Models.Empresa> Html { get; private set; }
    }
}
#pragma warning restore 1591
