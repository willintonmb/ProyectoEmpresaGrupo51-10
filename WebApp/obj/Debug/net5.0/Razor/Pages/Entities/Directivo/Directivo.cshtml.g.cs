#pragma checksum "C:\Repositorio Mintic\Ciclo 3\Proyecto Ciclo 3\webapp\Pages\Entities\Directivo\Directivo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdaa401cd4537da58be3a498095a224195550bde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Entities.Directivo.Pages_Entities_Directivo_Directivo), @"mvc.1.0.razor-page", @"/Pages/Entities/Directivo/Directivo.cshtml")]
namespace WebApp.Pages.Entities.Directivo
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
#line 1 "C:\Repositorio Mintic\Ciclo 3\Proyecto Ciclo 3\webapp\Pages\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdaa401cd4537da58be3a498095a224195550bde", @"/Pages/Entities/Directivo/Directivo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d1db1c25558096e535f8fd24d0fe24129c968a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Entities_Directivo_Directivo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Listado de Directivos</h1>\r\n<table class =\"Table\">\r\n");
#nullable restore
#line 7 "C:\Repositorio Mintic\Ciclo 3\Proyecto Ciclo 3\webapp\Pages\Entities\Directivo\Directivo.cshtml"
     foreach (var directivo in Model.Directivos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 11 "C:\Repositorio Mintic\Ciclo 3\Proyecto Ciclo 3\webapp\Pages\Entities\Directivo\Directivo.cshtml"
           Write(directivo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 15 "C:\Repositorio Mintic\Ciclo 3\Proyecto Ciclo 3\webapp\Pages\Entities\Directivo\Directivo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DirectivoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DirectivoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DirectivoModel>)PageContext?.ViewData;
        public MyApp.Namespace.DirectivoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
