#pragma checksum "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcb8363b2c85dc4c6895c2caf778b9f6aac5e7b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Details), @"mvc.1.0.view", @"/Views/Usuarios/Details.cshtml")]
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
#line 1 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\_ViewImports.cshtml"
using WebApplicationProjeto1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\_ViewImports.cshtml"
using WebApplicationProjeto1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcb8363b2c85dc4c6895c2caf778b9f6aac5e7b0", @"/Views/Usuarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa68d8930dd24cbcdb7e6ee856c88bee605ee794", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplicationProjeto1.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
  
    ViewData["Title"] = "Detalhes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes</h1>\r\n\r\n<div>\r\n    <h4>Usuario</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.usu_nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.usu_nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.usu_cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.usu_cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.usu_rg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.usu_rg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.usu_endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.usu_endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.usu_cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.usu_cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.usu_estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.usu_estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.usu_nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.usu_nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.usu_telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.usu_telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcb8363b2c85dc4c6895c2caf778b9f6aac5e7b010463", async() => {
                WriteLiteral("Editar");
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
#nullable restore
#line 65 "A:\MEGA\Backup\Faculdade\Semestres\5 SEMESTRE\Jean\Prog IV\17 - 28-05\Aplicação Web\WebApplicationProjeto1\Views\Usuarios\Details.cshtml"
                           WriteLiteral(Model.usu_codigo);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcb8363b2c85dc4c6895c2caf778b9f6aac5e7b012673", async() => {
                WriteLiteral("Voltar para lista");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplicationProjeto1.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
