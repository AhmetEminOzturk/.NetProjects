#pragma checksum "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1f4dd71a9432ab0084dc1704303e1fb243b3cca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__GalleryPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_GalleryPartial/Default.cshtml")]
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
#line 1 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1f4dd71a9432ab0084dc1704303e1fb243b3cca", @"/Views/Shared/Components/_GalleryPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daa27564c578f8bd032750b8d5a0983009bfabfa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__GalleryPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Image>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""gallery"" id=""gallery"">
	<div class=""container"">
		<h3 class=""tittle"">Fotoğraf Galerisi</h3>
		<p class=""heading-btm-w3ls"">Organik ürünlerimiz ve bahçelerimizden görüntüler.</p>
		<div class=""agile_gallery_grids w3-agile"">
			<ul class=""clearfix demo"">
");
#nullable restore
#line 10 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
                 foreach (var item in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<li>\r\n\t\t\t\t\t<div class=\"gallery-grid1\">\r\n\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 415, "\"", 435, 1);
#nullable restore
#line 14 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
WriteAttributeValue("", 421, item.ImageUrl, 421, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" \" class=\"img-responsive\" />\r\n\t\t\t\t\t\t<div class=\"p-mask\">\r\n\t\t\t\t\t\t\t<h4><span>");
#nullable restore
#line 16 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n\t\t\t\t\t\t\t<p>");
#nullable restore
#line 17 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</li>\n");
#nullable restore
#line 21 "D:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</ul>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Image>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
