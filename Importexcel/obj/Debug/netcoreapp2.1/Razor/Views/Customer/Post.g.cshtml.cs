#pragma checksum "C:\Users\beats\Desktop\test\ExcelImportIssue-master\Importexcel\Views\Customer\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "993dedc2eea19b9d0c8dac4f4a00be778c182674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Post), @"mvc.1.0.view", @"/Views/Customer/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Post.cshtml", typeof(AspNetCore.Views_Customer_Post))]
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
#line 1 "C:\Users\beats\Desktop\test\ExcelImportIssue-master\Importexcel\Views\_ViewImports.cshtml"
using Importexcel;

#line default
#line hidden
#line 2 "C:\Users\beats\Desktop\test\ExcelImportIssue-master\Importexcel\Views\_ViewImports.cshtml"
using Importexcel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"993dedc2eea19b9d0c8dac4f4a00be778c182674", @"/Views/Customer/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d31ca739d5098d0b2c8c11e9800e73ba38a447a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<response>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 1375, true);
            WriteLiteral(@"<style>
    #close_popup_div {
        position: absolute;
        text-align: center;
        right: 20px;
        top: 1px;
        cursor: pointer;
        text-decoration: none;
        color: white;
        display: none;
    }
    #popup_bg2 {
        position: fixed;
        top: 0;
        left: 0;
        background-color: rgba(0, 0,0, 0.7);
        width: 100%;
        height: 100%;
        display: block;
    }
    #popup_main_div2 {
        position: fixed;
        width: 800px;
        height: 400px;
        border-radius: 5px;
        background-color: white;
        left: 50%;
        margin-left: -400px;
        top: 50%;
        margin-top: -250px;
        box-sizing: border-box;
    }
    #header {
        text-align: center;
        font-family: sans-serif;
        font-size: 18px;
        margin-bottom: 10px;
        background-color: rgb(77, 77, 236);
        padding-top: 10px;
        padding-bottom: 5px;
        padding-left: 30px;
        margin");
            WriteLiteral(@"-top: 0;
        border-top-left-radius: 2px;
        border-top-right-radius: 2px;
        text-align: left;
        text-decoration: none;
        color: white;
    }
</style>
<div id=""popup_bg2"">
    <div id=""popup_main_div2"">
        <p id=""header"">

        </p>

        <p id=""javascript_desc"">
            <label>Upload status: ");
            EndContext();
            BeginContext(1393, 12, false);
#line 58 "C:\Users\beats\Desktop\test\ExcelImportIssue-master\Importexcel\Views\Customer\Post.cshtml"
                             Write(Model.answer);

#line default
#line hidden
            EndContext();
            BeginContext(1405, 497, true);
            WriteLiteral(@"</label>
        </p>


        <div id=""close_popup_div"" title=""close this popup menu"" onclick=""closePopupMenu2()"">
            <p>
                x
            </p>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    var popupDiv2 = document.getElementById(""popup_bg2"");
    function closePopupMenu2() {
        popupDiv2.style.display = ""none"";
    }
    setTimeout(function () { document.getElementById('close_popup_div').click(); }, 3000);
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<response> Html { get; private set; }
    }
}
#pragma warning restore 1591
