#pragma checksum "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Takmicenja.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67c722489dc857327b3d0b872ff113eec50d4e28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Takmicenje_Takmicenja), @"mvc.1.0.view", @"/Views/Takmicenje/Takmicenja.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Takmicenje/Takmicenja.cshtml", typeof(AspNetCore.Views_Takmicenje_Takmicenja))]
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
#line 2 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\_ViewImports.cshtml"
using RS1_Ispit_asp.net_core.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c722489dc857327b3d0b872ff113eec50d4e28", @"/Views/Takmicenje/Takmicenja.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600467cbcd045f3bdd3ec5a651a16a7a379db5f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Takmicenje_Takmicenja : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrikaziTakmicenja>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rezultati", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dodaj", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(33, 293, true);
            WriteLiteral(@"<table class=""table table-striped"">
    <thead>
        <tr>
            <th>Skola</th>
            <th>Razred</th>
            <th>Datum</th>
            <th>Predmet</th>
            <th>Najbolji ucesnik</th>
            <th>Akcija</th>
        </tr>
    </thead>
        <tbody>
");
            EndContext();
#line 16 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Takmicenja.cshtml"
             foreach (var item in Model.Rows)
            {

#line default
#line hidden
            BeginContext(388, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(435, 10, false);
#line 19 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Takmicenja.cshtml"
                   Write(item.Skola);

#line default
#line hidden
            EndContext();
            BeginContext(445, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(477, 11, false);
#line 20 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Takmicenja.cshtml"
                   Write(item.Razred);

#line default
#line hidden
            EndContext();
            BeginContext(488, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(520, 10, false);
#line 21 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Takmicenja.cshtml"
                   Write(item.Datum);

#line default
#line hidden
            EndContext();
            BeginContext(530, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(562, 12, false);
#line 22 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Takmicenja.cshtml"
                   Write(item.Predmet);

#line default
#line hidden
            EndContext();
            BeginContext(574, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(606, 25, false);
#line 23 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Takmicenja.cshtml"
                   Write(item.NajboljiUcesnikSkola);

#line default
#line hidden
            EndContext();
            BeginContext(631, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(635, 30, false);
#line 23 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Takmicenja.cshtml"
                                                Write(item.NajboljiUcesnikOdjeljenje);

#line default
#line hidden
            EndContext();
            BeginContext(665, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(669, 30, false);
#line 23 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Takmicenja.cshtml"
                                                                                  Write(item.NajboljiUcesnikImePrezime);

#line default
#line hidden
            EndContext();
            BeginContext(699, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(730, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c6f7a245654534b66514b4fa78f8cf", async() => {
                BeginContext(790, 9, true);
                WriteLiteral("Rezultati");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Takmicenja.cshtml"
                                                    WriteLiteral(item.TakmicenjeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(803, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 26 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Takmicenja.cshtml"
            }

#line default
#line hidden
            BeginContext(848, 28, true);
            WriteLiteral("        </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(876, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ede6e910770469f9ac1070077e9ec76", async() => {
                BeginContext(949, 5, true);
                WriteLiteral("Dodaj");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Takmicenja.cshtml"
                        WriteLiteral(Model.sID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrikaziTakmicenja> Html { get; private set; }
    }
}
#pragma warning restore 1591