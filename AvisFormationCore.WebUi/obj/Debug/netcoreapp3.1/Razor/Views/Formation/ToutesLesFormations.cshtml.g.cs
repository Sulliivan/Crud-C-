#pragma checksum "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\Formation\ToutesLesFormations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d63cb3a6fec2d4ac1f5d51dd3cce89be09dedc11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Formation_ToutesLesFormations), @"mvc.1.0.view", @"/Views/Formation/ToutesLesFormations.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d63cb3a6fec2d4ac1f5d51dd3cce89be09dedc11", @"/Views/Formation/ToutesLesFormations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90f1597720f99807d4568152226eb082105039d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Formation_ToutesLesFormations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Data.Formation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Formation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsFormation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\Formation\ToutesLesFormations.cshtml"
  
    ViewData["Title"] = "ToutesLesFormations";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Toutes nos formations</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\Formation\ToutesLesFormations.cshtml"
 foreach (var formation in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Nom de la formation : ");
#nullable restore
#line 10 "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\Formation\ToutesLesFormations.cshtml"
                        Write(formation.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d63cb3a6fec2d4ac1f5d51dd3cce89be09dedc114793", async() => {
#nullable restore
#line 14 "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\Formation\ToutesLesFormations.cshtml"
                            Write(formation.Nom);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\Formation\ToutesLesFormations.cshtml"
      WriteLiteral(formation.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    <p>Nom de la formation : formation.Nom</p>\r\n    <p>Description de la formation : ");
#nullable restore
#line 20 "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\Formation\ToutesLesFormations.cshtml"
                                Write(formation.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>NomSeo de la formation : ");
#nullable restore
#line 21 "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\Formation\ToutesLesFormations.cshtml"
                           Write(formation.NomSeo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <br/>\r\n");
#nullable restore
#line 23 "C:\Users\arinfo\source\repos\AvisFormationCore.WebUi\AvisFormationCore.WebUi\Views\Formation\ToutesLesFormations.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Data.Formation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
