#pragma checksum "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\Home\Merchant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4143d5d9a4a01321c5a70d5bd0de69be61e5b45d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Merchant), @"mvc.1.0.view", @"/Views/Home/Merchant.cshtml")]
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
#line 1 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\_ViewImports.cshtml"
using Carnation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\_ViewImports.cshtml"
using Carnation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\Home\Merchant.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4143d5d9a4a01321c5a70d5bd0de69be61e5b45d", @"/Views/Home/Merchant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6710861d01e1dfa70b1fadadc8c527ac62f6b92", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Merchant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-image: url(\'https://wallpaperaccess.com/full/1675302.jpg\'); color: white;background-size:cover;background-repeat:no-repeat;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\Home\Merchant.cshtml"
  
    ViewData["Title"] = "Merchant";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4143d5d9a4a01321c5a70d5bd0de69be61e5b45d3941", async() => {
                WriteLiteral("\n    <h3 class=\"display-4\" style=\"text-align:center\">We Welcome you Mr./Mrs. ");
#nullable restore
#line 8 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\Home\Merchant.cshtml"
                                                                       Write(HttpContextAccessor.HttpContext.Session.GetString("username"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ☺</h3>\n    <br />\n    <h4>Start selling Now !  <a");
                BeginWriteAttribute("href", " href=\"", 463, "\"", 502, 1);
#nullable restore
#line 10 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\Home\Merchant.cshtml"
WriteAttributeValue("", 470, Url.Action("Create","Products"), 470, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><b>Sell</b></a> .</h4><br /><br /><br /><br /><br />\n    <h5>In business section you can manage your profile</h5>\n\n    <h5>Note: You can\'t buy as a merchant. If you want buy, sign in as a normal user</h5>\n    <br />\n    <h5>Thank you !</h5>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<br /><br />\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
