#pragma checksum "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deb1308c749dea2e37c4c181942e6baf73714624"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Takmicenje_Rezultati), @"mvc.1.0.view", @"/Views/Takmicenje/Rezultati.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Takmicenje/Rezultati.cshtml", typeof(AspNetCore.Views_Takmicenje_Rezultati))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deb1308c749dea2e37c4c181942e6baf73714624", @"/Views/Takmicenje/Rezultati.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600467cbcd045f3bdd3ec5a651a16a7a379db5f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Takmicenje_Rezultati : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RezultatiTakmicenja>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Zakljucaj", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pristupio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DodajUcesnika", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ajax-poziv", new global::Microsoft.AspNetCore.Html.HtmlString("da"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ajax-rezultat", new global::Microsoft.AspNetCore.Html.HtmlString("ajaxDiv"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dodaj", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 33, true);
            WriteLiteral("\r\n<h2>Rezultati takmicenja</h2>\r\n");
            EndContext();
            BeginContext(68, 941, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2dfe1308fb24f128b513ecd254eb058", async() => {
                BeginContext(146, 162, true);
                WriteLiteral("\r\n    <table class=\"table table-condensed\">\r\n        <tr>\r\n            <td>\r\n                Skola domacin:\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(309, 18, false);
#line 13 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
           Write(Model.SkolaDomacin);

#line default
#line hidden
                EndContext();
                BeginContext(327, 147, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Predmet:\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(475, 13, false);
#line 21 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
           Write(Model.Predmet);

#line default
#line hidden
                EndContext();
                BeginContext(488, 146, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Razred:\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(635, 12, false);
#line 29 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
           Write(Model.Razred);

#line default
#line hidden
                EndContext();
                BeginContext(647, 145, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Datum:\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(793, 11, false);
#line 37 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
           Write(Model.Datum);

#line default
#line hidden
                EndContext();
                BeginContext(804, 198, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Zakljucaj</button>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 6 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                                             WriteLiteral(Model.TakmicenjeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1009, 353, true);
            WriteLiteral(@"
<div id=""ajaxDiv"">
    <table class=""table table-condensed"">
        <thead>
            <tr>
                <th>Odjeljenje</th>
                <th>Broj u dnevniku</th>
                <th>Pristupio</th>
                <th>Rezultat bodovi(max 100)</th>
                <th>Akcija</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 59 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
             foreach (var item in Model.UcesniciRows)
            {

#line default
#line hidden
            BeginContext(1432, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1471, 15, false);
#line 62 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
               Write(item.Odjeljenje);

#line default
#line hidden
            EndContext();
            BeginContext(1486, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1514, 18, false);
#line 63 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
               Write(item.BrojUDnevniku);

#line default
#line hidden
            EndContext();
            BeginContext(1532, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 64 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                 if (Model.isZakljucano)
                {
                    

#line default
#line hidden
#line 66 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                     if (@item.IsPristupio)
                    {

#line default
#line hidden
            BeginContext(1668, 156, true);
            WriteLiteral("                        <td>\r\n                            <a class=\"btn btn-success\" href=\"#\" style=\"cursor:default\">DA</a>\r\n                        </td>\r\n");
            EndContext();
#line 71 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1896, 155, true);
            WriteLiteral("                        <td>\r\n                            <a class=\"btn btn-danger\" href=\"#\" style=\"cursor:default\">NE</a>\r\n                        </td>\r\n");
            EndContext();
#line 77 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                    }

#line default
#line hidden
#line 77 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                     
                }
                else
                {
                    

#line default
#line hidden
#line 81 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                     if (@item.IsPristupio)
                    {

#line default
#line hidden
            BeginContext(2202, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2260, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f505388bb4c244838ece768d8d803f64", async() => {
                BeginContext(2341, 2, true);
                WriteLiteral("DA");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                                                                                WriteLiteral(item.UcesnikID);

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
            BeginContext(2347, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 86 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2452, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2510, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "530eed998c9e4bfb96175c479337ebcf", async() => {
                BeginContext(2590, 2, true);
                WriteLiteral("NE");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                                                                               WriteLiteral(item.UcesnikID);

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
            BeginContext(2596, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 92 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                    }

#line default
#line hidden
#line 92 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(2671, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(2692, 11, false);
#line 94 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
               Write(item.Bodovi);

#line default
#line hidden
            EndContext();
            BeginContext(2703, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2730, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd909662ac954592a54e2032295cadce", async() => {
                BeginContext(2859, 5, true);
                WriteLiteral("Uredi");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                                                    WriteLiteral(Model.TakmicenjeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2868, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 97 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
            }

#line default
#line hidden
            BeginContext(2909, 36, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
            EndContext();
            BeginContext(2945, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c659a845f50b4012a6e367af6626114d", async() => {
                BeginContext(3074, 14, true);
                WriteLiteral("Dodaj ucesnika");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "C:\Users\LENOVO\Desktop\RS1_Ispit_2020_02_20_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                                    WriteLiteral(Model.TakmicenjeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3092, 18, true);
            WriteLiteral("<br /><br />\r\n    ");
            EndContext();
            BeginContext(3110, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98b6e232b0c9465d9f133b3091853ec3", async() => {
                BeginContext(3156, 15, true);
                WriteLiteral("Novo takmicenje");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3175, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RezultatiTakmicenja> Html { get; private set; }
    }
}
#pragma warning restore 1591
