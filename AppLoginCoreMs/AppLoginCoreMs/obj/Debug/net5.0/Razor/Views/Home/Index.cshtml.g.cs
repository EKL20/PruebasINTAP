#pragma checksum "C:\Users\Elkin\source\repos\AppLoginCoreMs\AppLoginCoreMs\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee1a05eea348e8e9ff53ce6517d6cec21003a76d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Elkin\source\repos\AppLoginCoreMs\AppLoginCoreMs\Views\_ViewImports.cshtml"
using AppLoginCoreMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elkin\source\repos\AppLoginCoreMs\AppLoginCoreMs\Views\_ViewImports.cshtml"
using AppLoginCoreMs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee1a05eea348e8e9ff53ce6517d6cec21003a76d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d97b9cdcc5b32e25ad0f166ab6284fb9be70aaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Elkin\source\repos\AppLoginCoreMs\AppLoginCoreMs\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Hola  ");
#nullable restore
#line 6 "C:\Users\Elkin\source\repos\AppLoginCoreMs\AppLoginCoreMs\Views\Home\Index.cshtml"
                           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@", Bienvenido</h1>
    <div class=""display-3"">
    <p> <h6>Queremos que disfrutes de todos los beneficios de nuestra solución, y para ello es necesario
         que estes registrado. Si ya lo estas, perfecto! Haz Loguin, sino lo estas, registrate, hazlo ahora!</h6></p>
        </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591