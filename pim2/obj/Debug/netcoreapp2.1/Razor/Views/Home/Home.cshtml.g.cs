#pragma checksum "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35a94520c41e72723d52b13b39479322a4d604e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35a94520c41e72723d52b13b39479322a4d604e2", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8823da1095977e4ad4583b955bc5d091f9b2682", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<pim2.Models.Empresa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LoginPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("header-btn-portal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banco-de-dados.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/grafico.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/frota.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\55169\Downloads\iFleet.Net-master\pim2\Views\Home\Home.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(65, 440, true);
            WriteLiteral(@"


<!-- HEADER -->
<div class=""header"">

    <h1 class=""title-font"">iFleet</h1>

    <nav class=""header-nav"">
        <ul class=""header-nav-menu"">
            <li class=""header-menu-item""><a href=""#iFleet"">Por que nós</a></li>
            <li class=""header-menu-item""><a href=""#sobre"">Sobre</a></li>
            <li class=""header-menu-item""><a href=""#contato"">Contato</a></li>
        </ul>
    </nav>

    <div class=""header-btn"">
        ");
            EndContext();
            BeginContext(505, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4110d48664754b16a9ca27c2b79c39d4", async() => {
                BeginContext(557, 6, true);
                WriteLiteral("Entrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(567, 582, true);
            WriteLiteral(@"
    </div>
</div>
<!-- END HEADER -->
<!-- HERO -->
<section class=""hero"">
    <div class=""hero-text"">
        <h2 class=""hero-title"">iFleet</h2>
        <p class=""hero-paragraph"">O melhor sistema para controle da sua frota</p>
    </div>

    <a href="""" class=""hero-btn"">Ir ao portal</a>
</section>
<!-- END HERO -->
<!-- MAIN -->
<section class=""main"">

    <div class=""main-ifleet"">
        <h2 id=""iFleet"" class=""title-font"">Porque o iFleet?</h2>

        <div class=""flex"">
            <div class=""main-card"">
                <div class=""main-card-image"">
                    ");
            EndContext();
            BeginContext(1149, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6010758fb5f8414c9860fcb668f73135", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(1197, 547, true);
            WriteLiteral(@"
                </div>
                <div class=""main-card-text"">
                    <h3>Segurança</h3>
                    <p>
                        O sistema por ser do tipo cliente servidor permite a configuração de backup(s) para subisidiar a perda de dados, além de comportar praticas para proteger a integridade e a segurança dos dados ou informações dos clientes!
                    </p>
                </div>
            </div>

            <div class=""main-card"">
                <div class=""main-card-image"">
                    ");
            EndContext();
            BeginContext(1744, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "947a7b80ffc9479fbf341457a2447e5e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1785, 427, true);
            WriteLiteral(@"
                </div>
                <div class=""main-card-text"">
                    <h3>Controle</h3>
                    <p>O sistema permite gerenciar uma frota de veiculos, a medida em que o cliente dispõe informações para que assim o sistema seja efetivamente pratico.</p>
                </div>
            </div>

            <div class=""main-card"">
                <div class=""main-card-image"">
                    ");
            EndContext();
            BeginContext(2212, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "75b851b46b1d4b5096b433ab31e219a0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2251, 1201, true);
            WriteLiteral(@"
                </div>
                <div class=""main-card-text"">
                    <h3>Frota</h3>
                    <p> O sistema armazena os dados de uma frota podendo ser registrado as manutenções e viagens do mesmo, além de poder registar o consumo de combustivel,quilometragem dentre outras coisas.</p>
                </div>
            </div>
        </div>

    </div><!-- END MAIN-IFLEET-->
</section>
<!-- END MAIN -->


<section class=""about"">
    <h2 id=""sobre"" class=""about-title title-font pa"">Sobre nós</h2>
    <p class=""pa"">
        Por ser uma empresa sedimentada no ramo de TI, podemos citar como base que nossa relação e conversa
        com nossos clientes ocorre de maneira fluida e confiavél, permitindo assim compreendermos e retornarmos
        a expectativa deles para conosco, retribuindo sempre com um otimo software de qualidade e praticidade!
        Além de nosso foco ser a tecnologia, contribuimos com a natureza também em prol de um mundo melhor!
        Possuimos o chamado TI verde");
            WriteLiteral(", que visa criar projetos de conscientização a preservação a nossa fauna e nossa flora!\n        qualquer duvida entre em contato conosco e conheça a 2VJMIG.\n    </p>\n</section>\n");
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
