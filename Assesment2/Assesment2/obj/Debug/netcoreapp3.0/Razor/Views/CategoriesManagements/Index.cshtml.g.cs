#pragma checksum "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b02a85c13787a28e939d8593850c7a6e5dd0154"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoriesManagements_Index), @"mvc.1.0.view", @"/Views/CategoriesManagements/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b02a85c13787a28e939d8593850c7a6e5dd0154", @"/Views/CategoriesManagements/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4e2d0433a77df8cb83ee90419a641138b9bc0bb", @"/Views/_ViewImports.cshtml")]
    public class Views_CategoriesManagements_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Assesment2.Models.CategoriesManagement>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/CategoriesManagements/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b02a85c13787a28e939d8593850c7a6e5dd01544679", async() => {
                WriteLiteral("\r\n    <input type=\"text\" name=\"temp\" />\r\n    <input type=\"submit\" value=\"Search\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b02a85c13787a28e939d8593850c7a6e5dd01546125", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 45 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
                 if (Context.Session.GetString("role") == "Admin")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1247, "\"", 1293, 2);
            WriteAttributeValue("", 1254, "/CategoriesManagements/Edit?id=", 1254, 31, true);
#nullable restore
#line 47 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
WriteAttributeValue("", 1285, item.Id, 1285, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"><i class=\"fa fa-pencil\"></i>Edit</a>\r\n                    <a href=\"#\" data-id=\"");
#nullable restore
#line 48 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger delete\"><i class=\"fa fa-bin\"></i>Delete</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1497, "\"", 1546, 2);
            WriteAttributeValue("", 1504, "/CategoriesManagements/Details?id=", 1504, 34, true);
#nullable restore
#line 49 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
WriteAttributeValue("", 1538, item.Id, 1538, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"><i class=\"fa fa-eye\"></i>Detail</a>\r\n");
#nullable restore
#line 50 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1691, "\"", 1740, 2);
            WriteAttributeValue("", 1698, "/CategoriesManagements/Details?id=", 1698, 34, true);
#nullable restore
#line 53 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
WriteAttributeValue("", 1732, item.Id, 1732, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"><i class=\"fa fa-eye\"></i>Detail</a>\r\n");
#nullable restore
#line 54 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 58 "C:\Users\user\source\repos\MuhammadAbubakar786\Assesment2\Assesment2\Assesment2\Views\CategoriesManagements\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        $(function () {

            $('.delete').click(function () {

                var DeleteButton = $(this);
                var Ajex_id = DeleteButton.data(""id"");
                DeleteButton.text(""Please Wait ...."");
                DeleteButton.removeClass(""btn-danger"");
                DeleteButton.addClass(""btn-success"");
                $.ajax({
                    url: '/CategoriesManagements/Delete',
                    type: 'Post',
                    data: {
                        id: Ajex_id
                    },
                    success: function (response) {
                        if (response == ""1"") {
                            //alert(""Data delted"");
                            DeleteButton.parent().parent().fadeOut(5000);
                        }
                    }
                });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Assesment2.Models.CategoriesManagement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
