#pragma checksum "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "944e401a1d75ba114dc387e79acf046006b049bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Employee\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"944e401a1d75ba114dc387e79acf046006b049bb", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daa27564c578f8bd032750b8d5a0983009bfabfa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/MajesticAdmin-Free-Bootstrap-Admin-Template-master/template/images/faces/face1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"col-lg-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Personel Listesi</h4>\r\n            <div class=\"table-responsive\">\r\n");
#nullable restore
#line 14 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Employee\Index.cshtml"
                 if (Model.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-striped"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>ID</th>
                                <th>Ad</th>
                                <th>Görev</th>
                                <th>Sil</th>
                                <th>Düzenle</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 28 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Employee\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"py-1\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "944e401a1d75ba114dc387e79acf046006b049bb6207", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 34 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Employee\Index.cshtml"
                                   Write(item.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 35 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Employee\Index.cshtml"
                                   Write(item.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 36 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Employee\Index.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1525, "\"", 1573, 2);
            WriteAttributeValue("", 1532, "/Employee/DeleteEmployee/", 1532, 25, true);
#nullable restore
#line 37 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1557, item.EmployeeID, 1557, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1662, "\"", 1708, 2);
            WriteAttributeValue("", 1669, "/Employee/EditEmployee/", 1669, 23, true);
#nullable restore
#line 38 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1692, item.EmployeeID, 1692, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Güncelle</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 40 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Employee\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 43 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Employee\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""alert alert-danger"">
                        <strong>UYARI!</strong> Veri Tabanınızda Personel Bulunamamıştır.
                    </div>
                    <div class=""alert alert-warning"">
                        <strong>UYARI!</strong> Lütfen Personel Girişi Yapınız.
                    </div>
");
#nullable restore
#line 52 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Employee\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n            <br />\r\n            <a href=\"/Employee/AddEmployee\" class=\"btn btn-outline-success\">Yeni Personel Girişi</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
