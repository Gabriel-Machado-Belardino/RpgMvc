#pragma checksum "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ea6bc16ae67e6d20a636164cac7bdc21c0b4b25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personagens_Create), @"mvc.1.0.view", @"/Views/Personagens/Create.cshtml")]
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
#line 1 "D:\Documentos\Etec\VS code\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documentos\Etec\VS code\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ea6bc16ae67e6d20a636164cac7bdc21c0b4b25", @"/Views/Personagens/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Personagens_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.PersonagemViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
  
    ViewBag.Title = "Novo Personagem";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Insira aqui os TempData de Sucesso e Erro para evitar tela de morte-->\r\n<h2>Criar um Novo Personagem</h2>\r\n");
#nullable restore
#line 7 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 13 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 15 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 20 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
       Write(Html.LabelFor(model => model.PontosVida, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 22 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
           Write(Html.EditorFor(model => model.PontosVida, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
       Write(Html.LabelFor(model => model.Forca, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 29 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
           Write(Html.EditorFor(model => model.Forca, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 34 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
       Write(Html.LabelFor(model => model.Defesa, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 36 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
           Write(Html.EditorFor(model => model.Defesa, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 41 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
       Write(Html.LabelFor(model => model.Inteligencia, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 43 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
           Write(Html.EditorFor(model => model.Inteligencia, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 48 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
       Write(Html.LabelFor(model => model.Classe, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 50 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
           Write(Html.DropDownListFor(model => model.Classe, Html.GetEnumSelectList(typeof(RpgMvc.Models.Enuns.ClassEnum)),
                "---Selecione---", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-6\">\r\n                <input type=\"submit\" value=\"Salvar\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 61 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 64 "D:\Documentos\Etec\VS code\RpgMvc\Views\Personagens\Create.cshtml"
Write(Html.ActionLink("Retornar", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.PersonagemViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
