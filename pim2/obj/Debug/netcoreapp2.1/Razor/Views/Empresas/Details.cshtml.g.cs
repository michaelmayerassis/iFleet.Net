#pragma checksum "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf0353b3b217c5fedf2a841accc77c9a9f1e74df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresas_Details), @"mvc.1.0.view", @"/Views/Empresas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empresas/Details.cshtml", typeof(AspNetCore.Views_Empresas_Details))]
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
#line 1 "C:\Users\55169\source\repos\pim2\pim2\Views\_ViewImports.cshtml"
using pim2;

#line default
#line hidden
#line 2 "C:\Users\55169\source\repos\pim2\pim2\Views\_ViewImports.cshtml"
using pim2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0353b3b217c5fedf2a841accc77c9a9f1e74df", @"/Views/Empresas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d21f64d710af32500c15ce2eb240602ca553025", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<pim2.Models.Empresa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(73, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Empresa</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(195, 40, false);
#line 14 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(235, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(279, 36, false);
#line 17 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(315, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(359, 40, false);
#line 20 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CNPJ));

#line default
#line hidden
            EndContext();
            BeginContext(399, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(443, 36, false);
#line 23 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayFor(model => model.CNPJ));

#line default
#line hidden
            EndContext();
            BeginContext(479, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(523, 44, false);
#line 26 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(567, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(611, 40, false);
#line 29 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayFor(model => model.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(651, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(695, 41, false);
#line 32 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(736, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(780, 37, false);
#line 35 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(817, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(861, 44, false);
#line 38 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.endereco));

#line default
#line hidden
            EndContext();
            BeginContext(905, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(949, 40, false);
#line 41 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayFor(model => model.endereco));

#line default
#line hidden
            EndContext();
            BeginContext(989, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1033, 42, false);
#line 44 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.numero));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1119, 38, false);
#line 47 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayFor(model => model.numero));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1201, 42, false);
#line 50 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1287, 38, false);
#line 53 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayFor(model => model.cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1369, 42, false);
#line 56 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1455, 38, false);
#line 59 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
       Write(Html.DisplayFor(model => model.bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1540, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f36da61d13d84035859d0bd0a5535f3e", async() => {
                BeginContext(1586, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\55169\source\repos\pim2\pim2\Views\Empresas\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1594, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1602, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d0a56962618435984e0a57feb6afa6f", async() => {
                BeginContext(1624, 12, true);
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
            BeginContext(1640, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
