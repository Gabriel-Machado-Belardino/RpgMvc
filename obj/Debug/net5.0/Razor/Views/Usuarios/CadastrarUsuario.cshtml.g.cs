#pragma checksum "D:\Documentos\Etec\VS code\RpgMvc\Views\Usuarios\CadastrarUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4117fc44f6d2840683872dcdba4ddc1823ca9b94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_CadastrarUsuario), @"mvc.1.0.view", @"/Views/Usuarios/CadastrarUsuario.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4117fc44f6d2840683872dcdba4ddc1823ca9b94", @"/Views/Usuarios/CadastrarUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuarios_CadastrarUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.UsuarioViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--Namespace da classe de Modelo-->\r\n");
            WriteLiteral("<!--Título da View-->\r\n");
#nullable restore
#line 4 "D:\Documentos\Etec\VS code\RpgMvc\Views\Usuarios\CadastrarUsuario.cshtml"
      
    ViewBag.Title = "Registrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Configuração de mensagem temporária-->\r\n");
#nullable restore
#line 8 "D:\Documentos\Etec\VS code\RpgMvc\Views\Usuarios\CadastrarUsuario.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 11 "D:\Documentos\Etec\VS code\RpgMvc\Views\Usuarios\CadastrarUsuario.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 13 "D:\Documentos\Etec\VS code\RpgMvc\Views\Usuarios\CadastrarUsuario.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Criação de novos Usuários</h2>\r\n<hr />\r\n<!-- Método que será chamado se o usuário fizer o Post -->\r\n");
#nullable restore
#line 17 "D:\Documentos\Etec\VS code\RpgMvc\Views\Usuarios\CadastrarUsuario.cshtml"
 using (Html.BeginForm("Registrar", "Usuarios", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Documentos\Etec\VS code\RpgMvc\Views\Usuarios\CadastrarUsuario.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Usuário</label>\r\n            <div class=\"col-md-6\">\r\n                <!--Campo TextBox -->\r\n                ");
#nullable restore
#line 25 "D:\Documentos\Etec\VS code\RpgMvc\Views\Usuarios\CadastrarUsuario.cshtml"
           Write(Html.EditorFor(model => model.Username, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Senha</label>\r\n            <div class=\"col-md-6\">\r\n                <!--TextBox de Senha-->\r\n                ");
#nullable restore
#line 32 "D:\Documentos\Etec\VS code\RpgMvc\Views\Usuarios\CadastrarUsuario.cshtml"
           Write(Html.PasswordFor(model => model.PasswordString, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <input type=\"submit\" value=\"Registrar\" class=\"btn btn-primary\" />\r\n        <!--Exemplo de Link (Texto, View, Controller) -->\r\n        ");
#nullable restore
#line 37 "D:\Documentos\Etec\VS code\RpgMvc\Views\Usuarios\CadastrarUsuario.cshtml"
   Write(Html.ActionLink("Retornar", "Index", "Home", null, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 39 "D:\Documentos\Etec\VS code\RpgMvc\Views\Usuarios\CadastrarUsuario.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.UsuarioViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
