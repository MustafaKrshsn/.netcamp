#pragma checksum "C:\Users\Mustafa\Source\Repos\.netcamp\NetCamp\NetCampWeb\Views\Ogrenci\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1230fe71adfa3f0dd1cbd8cb81eb4ab4734a3bef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ogrenci_List), @"mvc.1.0.view", @"/Views/Ogrenci/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ogrenci/List.cshtml", typeof(AspNetCore.Views_Ogrenci_List))]
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
#line 1 "C:\Users\Mustafa\Source\Repos\.netcamp\NetCamp\NetCampWeb\Views\_ViewImports.cshtml"
using NetCampWeb;

#line default
#line hidden
#line 2 "C:\Users\Mustafa\Source\Repos\.netcamp\NetCamp\NetCampWeb\Views\_ViewImports.cshtml"
using NetCampWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1230fe71adfa3f0dd1cbd8cb81eb4ab4734a3bef", @"/Views/Ogrenci/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf9d163d04999da691ac8e24add865cd9b2b780", @"/Views/_ViewImports.cshtml")]
    public class Views_Ogrenci_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List< NetCampWeb.Models.Entities.Ogrenci>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Mustafa\Source\Repos\.netcamp\NetCamp\NetCampWeb\Views\Ogrenci\List.cshtml"
  
    ViewData["Title"] = "Öğrenci Listesi";

#line default
#line hidden
            BeginContext(101, 31, true);
            WriteLiteral("\r\n<h2>Öğrenci Listesi </h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Mustafa\Source\Repos\.netcamp\NetCamp\NetCampWeb\Views\Ogrenci\List.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
            BeginContext(164, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(172, 7, false);
#line 10 "C:\Users\Mustafa\Source\Repos\.netcamp\NetCamp\NetCampWeb\Views\Ogrenci\List.cshtml"
  Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(179, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(181, 8, false);
#line 10 "C:\Users\Mustafa\Source\Repos\.netcamp\NetCamp\NetCampWeb\Views\Ogrenci\List.cshtml"
           Write(item.Adi);

#line default
#line hidden
            EndContext();
            BeginContext(189, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(191, 11, false);
#line 10 "C:\Users\Mustafa\Source\Repos\.netcamp\NetCamp\NetCampWeb\Views\Ogrenci\List.cshtml"
                     Write(item.Soyadi);

#line default
#line hidden
            EndContext();
            BeginContext(202, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(204, 9, false);
#line 10 "C:\Users\Mustafa\Source\Repos\.netcamp\NetCamp\NetCampWeb\Views\Ogrenci\List.cshtml"
                                  Write(item.Yasi);

#line default
#line hidden
            EndContext();
            BeginContext(213, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "C:\Users\Mustafa\Source\Repos\.netcamp\NetCamp\NetCampWeb\Views\Ogrenci\List.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List< NetCampWeb.Models.Entities.Ogrenci>> Html { get; private set; }
    }
}
#pragma warning restore 1591
