#pragma checksum "C:\Users\yair\source\repos\2022\prueba-login\Login-JWT\Login-JWT\Views\Home\MainWindow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41f71e695ec1fa2785efd8a939a280bdf087334b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MainWindow), @"mvc.1.0.view", @"/Views/Home/MainWindow.cshtml")]
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
#line 1 "C:\Users\yair\source\repos\2022\prueba-login\Login-JWT\Login-JWT\Views\_ViewImports.cshtml"
using Login_JWT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yair\source\repos\2022\prueba-login\Login-JWT\Login-JWT\Views\_ViewImports.cshtml"
using Login_JWT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f71e695ec1fa2785efd8a939a280bdf087334b", @"/Views/Home/MainWindow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b779a7e617b73b26bc69be44b2d7be4bdf497df9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_MainWindow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\yair\source\repos\2022\prueba-login\Login-JWT\Login-JWT\Views\Home\MainWindow.cshtml"
  
  ViewBag.Title = "Demonstrating JWTs in ASP.NET Core MVC 5";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <li style=\"list-style:none\">\r\n        <a style=\"text-decoration:none\">");
#nullable restore
#line 6 "C:\Users\yair\source\repos\2022\prueba-login\Login-JWT\Login-JWT\Views\Home\MainWindow.cshtml"
                                   Write(Html.ActionLink("Cerrar Sesion","Logout","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
    </li>
</div>

<div class=""col-8"" style=""display: flex; align-items:center; justify-content:center;margin: 0 auto;flex-direction:column"">
    <h3>Bienvenido/a a WEB 3</h3>
    <img src=""https://static.vecteezy.com/system/resources/previews/005/163/928/non_2x/account-has-been-registered-login-success-concept-illustration-flat-design-eps10-modern-graphic-element-for-landing-page-empty-state-ui-infographic-icon-vector.jpg"" width=""200"" height=""200""/>
    <p class=""mt-5""><span style=""font-size:16px;font-weight:500;"">Token Generado </span> ");
#nullable restore
#line 13 "C:\Users\yair\source\repos\2022\prueba-login\Login-JWT\Login-JWT\Views\Home\MainWindow.cshtml"
                                                                                    Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
