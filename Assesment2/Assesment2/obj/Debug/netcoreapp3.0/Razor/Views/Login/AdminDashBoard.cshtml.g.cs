#pragma checksum "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\Login\AdminDashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78dea0b07cc0b8ccfb5e528994cedf812c4c935d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_AdminDashBoard), @"mvc.1.0.view", @"/Views/Login/AdminDashBoard.cshtml")]
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
#line 1 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\_ViewImports.cshtml"
using Assesment2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\_ViewImports.cshtml"
using Assesment2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78dea0b07cc0b8ccfb5e528994cedf812c4c935d", @"/Views/Login/AdminDashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4e2d0433a77df8cb83ee90419a641138b9bc0bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_AdminDashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\Login\AdminDashBoard.cshtml"
  
    ViewData["Title"] = "AdminDashBoard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AdminDashBoard</h1>\r\n\r\n<p>Welcome ");
#nullable restore
#line 8 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\Login\AdminDashBoard.cshtml"
      Write(Context.Session.GetString("Username"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
