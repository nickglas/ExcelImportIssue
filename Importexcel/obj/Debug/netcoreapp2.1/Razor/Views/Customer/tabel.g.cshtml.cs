#pragma checksum "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74aff062cdb633319bdaf4828bfb402bfd40169b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_tabel), @"mvc.1.0.view", @"/Views/Customer/tabel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/tabel.cshtml", typeof(AspNetCore.Views_Customer_tabel))]
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
#line 1 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\_ViewImports.cshtml"
using Importexcel;

#line default
#line hidden
#line 2 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\_ViewImports.cshtml"
using Importexcel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74aff062cdb633319bdaf4828bfb402bfd40169b", @"/Views/Customer/tabel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e0f4ce86ffbbe0a4040ed338d25ba31cf64521", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_tabel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Issue>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "leegmaken", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(22, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eed0d0aca6bc45798aefc046d573d3a5", async() => {
                BeginContext(28, 66, true);
                WriteLiteral("\r\n    <link href=\"style.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(101, 21, true);
            WriteLiteral("\r\n<h1>Issues</h1>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
            BeginContext(149, 539, true);
            WriteLiteral(@"    <table class=""sheettable"">
        <tr>
            <th>Id</th>
            <th>Gereed</th>
            <th>Project Code</th>
            <th>Organisatie Code</th>
            <th>Input Bron</th>
            <th>Aard Id</th>
            <th>Categorie</th>
            <th>ActieHouder</th>
            <th>Prioriteit</th>
            <th>Kenmerk</th>
            <th>Issues</th>
            <th>Antwoord</th>
            <th>Opmerking</th>
            <th>Aangever </th>
            <th>Manuren</th>


        </tr>
");
            EndContext();
#line 30 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
         foreach (var issue in Model)
        {

#line default
#line hidden
            BeginContext(738, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(777, 8, false);
#line 33 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.id);

#line default
#line hidden
            EndContext();
            BeginContext(785, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(813, 12, false);
#line 34 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.Gereed);

#line default
#line hidden
            EndContext();
            BeginContext(825, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(853, 18, false);
#line 35 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.Project_Code);

#line default
#line hidden
            EndContext();
            BeginContext(871, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(899, 22, false);
#line 36 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.Organisatie_Code);

#line default
#line hidden
            EndContext();
            BeginContext(921, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(949, 16, false);
#line 37 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.Input_Bron);

#line default
#line hidden
            EndContext();
            BeginContext(965, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(993, 12, false);
#line 38 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.AardId);

#line default
#line hidden
            EndContext();
            BeginContext(1005, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1033, 15, false);
#line 39 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.Categorie);

#line default
#line hidden
            EndContext();
            BeginContext(1048, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1076, 17, false);
#line 40 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.Actiehouder);

#line default
#line hidden
            EndContext();
            BeginContext(1093, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1121, 16, false);
#line 41 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.Prioriteit);

#line default
#line hidden
            EndContext();
            BeginContext(1137, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1165, 13, false);
#line 42 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.Kenmerk);

#line default
#line hidden
            EndContext();
            BeginContext(1178, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1206, 12, false);
#line 43 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.Issues);

#line default
#line hidden
            EndContext();
            BeginContext(1218, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1246, 14, false);
#line 44 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.Antwoord);

#line default
#line hidden
            EndContext();
            BeginContext(1260, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1288, 15, false);
#line 45 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.Opmerking);

#line default
#line hidden
            EndContext();
            BeginContext(1303, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1331, 14, false);
#line 46 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.Aangever);

#line default
#line hidden
            EndContext();
            BeginContext(1345, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1373, 13, false);
#line 47 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
               Write(issue.ManUren);

#line default
#line hidden
            EndContext();
            BeginContext(1386, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 50 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
        }

#line default
#line hidden
            BeginContext(1425, 18, true);
            WriteLiteral("    </table>\r\n    ");
            EndContext();
            BeginContext(1443, 172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18984a6aa6ea4c3b955065886c208e27", async() => {
                BeginContext(1542, 66, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Database leegmaken\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1615, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1629, 39, true);
            WriteLiteral("    <h3>Geen data in de database</h3>\r\n");
            EndContext();
#line 59 "C:\Users\dave\Desktop\Importexcel\Importexcel\Views\Customer\tabel.cshtml"
}

#line default
#line hidden
            BeginContext(1671, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Issue>> Html { get; private set; }
    }
}
#pragma warning restore 1591
