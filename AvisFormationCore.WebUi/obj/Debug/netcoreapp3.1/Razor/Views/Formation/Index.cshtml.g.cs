#pragma checksum "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\Formation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd19fa53ab0a2a9ed93169909d0212fe0a8985cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Formation_Index), @"mvc.1.0.view", @"/Views/Formation/Index.cshtml")]
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
#line 1 "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\_ViewImports.cshtml"
using AvisFormationCore.WebUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\_ViewImports.cshtml"
using AvisFormationCore.WebUi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd19fa53ab0a2a9ed93169909d0212fe0a8985cf", @"/Views/Formation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90f1597720f99807d4568152226eb082105039d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Formation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToutesLesFormationsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\Formation\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Index</h1>\r\n<p>ceci et une vue</p>\r\n<p>");
#nullable restore
#line 9 "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\Formation\Index.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Ceci est ma valeur passée : ");
#nullable restore
#line 10 "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\Formation\Index.cshtml"
                          Write(Model.Nombre);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToutesLesFormationsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
