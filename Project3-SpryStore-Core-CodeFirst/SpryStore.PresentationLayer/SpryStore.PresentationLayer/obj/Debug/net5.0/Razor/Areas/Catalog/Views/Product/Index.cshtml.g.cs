#pragma checksum "D:\GitHub\.NetProjects\Project3-SpryStore-Core-CodeFirst\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Areas\Catalog\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eafb317d7919ce03b6eadecceddcbb937d15a9ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Catalog_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Catalog/Views/Product/Index.cshtml")]
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
#line 1 "D:\GitHub\.NetProjects\Project3-SpryStore-Core-CodeFirst\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Areas\Catalog\Views\_ViewImports.cshtml"
using SpryStore.PresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\.NetProjects\Project3-SpryStore-Core-CodeFirst\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Areas\Catalog\Views\_ViewImports.cshtml"
using SpryStore.PresentationLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\.NetProjects\Project3-SpryStore-Core-CodeFirst\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Areas\Catalog\Views\_ViewImports.cshtml"
using SpryStore.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eafb317d7919ce03b6eadecceddcbb937d15a9ab", @"/Areas/Catalog/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1e3c4da9e3b8bf8a4842de529a09f62fed93dff", @"/Areas/Catalog/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Catalog_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GitHub\.NetProjects\Project3-SpryStore-Core-CodeFirst\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Areas\Catalog\Views\Product\Index.cshtml"
  
    Layout = "~/Areas/Catalog/Views/Layout/_CatalogLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
   <div class=""page-heading products-heading header-text"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""text-content"">
                        <h4>Son Gelen Ürünler</h4>
                        <h2>Binlerce Ürün Uygun Fiyata</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>

<div class=""products"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""filters"">
                    <ul>
                        <li class=""active"" data-filter=""*"">Ürünler</li>
                        <li data-filter="".des"">Kampanyalılar</li>
                        <li data-filter="".dev"">Günün Fırsatları</li>
                        <li data-filter="".gra"">En Beğenilenler</li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-12"">
                <div clas");
            WriteLiteral("s=\"filters-content\">\r\n                    <div class=\"row grid\">\r\n");
#nullable restore
#line 35 "D:\GitHub\.NetProjects\Project3-SpryStore-Core-CodeFirst\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Areas\Catalog\Views\Product\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <div class=\"col-lg-4 col-md-4 all des\">\r\n                            <div class=\"product-item\">\r\n                                <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 1438, "\"", 1455, 1);
#nullable restore
#line 39 "D:\GitHub\.NetProjects\Project3-SpryStore-Core-CodeFirst\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Areas\Catalog\Views\Product\Index.cshtml"
WriteAttributeValue("", 1444, item.Image, 1444, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1456, "\"", 1462, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                <div class=\"down-content\">\r\n                                    <a href=\"#\"><h4> ");
#nullable restore
#line 41 "D:\GitHub\.NetProjects\Project3-SpryStore-Core-CodeFirst\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Areas\Catalog\Views\Product\Index.cshtml"
                                                Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4></a>\r\n                                    <h6>");
#nullable restore
#line 42 "D:\GitHub\.NetProjects\Project3-SpryStore-Core-CodeFirst\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Areas\Catalog\Views\Product\Index.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <p>");
#nullable restore
#line 43 "D:\GitHub\.NetProjects\Project3-SpryStore-Core-CodeFirst\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Areas\Catalog\Views\Product\Index.cshtml"
                                  Write(item.Description.Substring(0,75));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"...</p>
                                    <ul class=""stars"">
                                        <li><i class=""fa fa-star""></i></li>
                                        <li><i class=""fa fa-star""></i></li>
                                        <li><i class=""fa fa-star""></i></li>
                                        <li><i class=""fa fa-star""></i></li>
                                        <li><i class=""fa fa-star""></i></li>
                                    </ul>
                                    <span>Değerlendirmeler (12)</span>
                                </div>
                            </div>
                        </div>      
");
#nullable restore
#line 55 "D:\GitHub\.NetProjects\Project3-SpryStore-Core-CodeFirst\SpryStore.PresentationLayer\SpryStore.PresentationLayer\Areas\Catalog\Views\Product\Index.cshtml"
                        }                                     

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""col-md-12"">
                <ul class=""pages"">
                    <li><a href=""#"">1</a></li>
                    <li class=""active""><a href=""#"">2</a></li>
                    <li><a href=""#"">3</a></li>
                    <li><a href=""#"">4</a></li>
                    <li><a href=""#""><i class=""fa fa-angle-double-right""></i></a></li>
                </ul>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
