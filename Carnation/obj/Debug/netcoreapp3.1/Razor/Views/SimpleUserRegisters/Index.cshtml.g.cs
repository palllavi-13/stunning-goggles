#pragma checksum "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62400c9b9e1f6bef9ea8de3bc817412e57d83648"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SimpleUserRegisters_Index), @"mvc.1.0.view", @"/Views/SimpleUserRegisters/Index.cshtml")]
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
#line 6 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62400c9b9e1f6bef9ea8de3bc817412e57d83648", @"/Views/SimpleUserRegisters/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6710861d01e1dfa70b1fadadc8c527ac62f6b92", @"/Views/_ViewImports.cshtml")]
    public class Views_SimpleUserRegisters_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Carnation.NewModels.SimpleUserRegister>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:green"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:red"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62400c9b9e1f6bef9ea8de3bc817412e57d836485976", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n");
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
            WriteLiteral("\n\n<div class=\"align-top\">\n    <nav class=\"navbar navbar-expand-lg navbar-dark bg-dark\" style=\"background-color: rgba(0,0,0,0.5) !important;top:0\">\n        <a class=\"navbar-brand\"");
            BeginWriteAttribute("href", " href=\"", 447, "\"", 481, 1);
#nullable restore
#line 14 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
WriteAttributeValue("", 454, Url.Action("Index","Home"), 454, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Carnation</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavAltMarkup"" aria-controls=""navbarNavAltMarkup"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarNavAltMarkup"">
            <div class=""navbar-nav"">
                <a class=""nav-link active""");
            BeginWriteAttribute("href", " href=\"", 918, "\"", 952, 1);
#nullable restore
#line 20 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
WriteAttributeValue("", 925, Url.Action("Index","Home"), 925, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home <span class=\"sr-only\">(current)</span></a>\n                <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1037, "\"", 1075, 1);
#nullable restore
#line 21 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
WriteAttributeValue("", 1044, Url.Action("Index","Products"), 1044, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Buy Now</a>\n                <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1124, "\"", 1174, 1);
#nullable restore
#line 22 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
WriteAttributeValue("", 1131, Url.Action("Create","SimpleUserRegisters"), 1131, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sign Up</a>\n                <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1223, "\"", 1260, 1);
#nullable restore
#line 23 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
WriteAttributeValue("", 1230, Url.Action("Login","Account"), 1230, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Login</a>\n                <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1307, "\"", 1347, 1);
#nullable restore
#line 24 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
WriteAttributeValue("", 1314, Url.Action("Create","Feedbacks"), 1314, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Feedback</a>\n");
#nullable restore
#line 25 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                 if (HttpContextAccessor.HttpContext.Session.GetString("usertype") == "merchant" || HttpContextAccessor.HttpContext.Session.GetString("usertype") == "admin")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1585, "\"", 1636, 1);
#nullable restore
#line 27 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
WriteAttributeValue("", 1592, Url.Action("Index","MerchantUserRegisters"), 1592, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Business Account🔑</a>");
#nullable restore
#line 27 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                                                                                                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                 if (HttpContextAccessor.HttpContext.Session.GetString("usertype") == "simple" || HttpContextAccessor.HttpContext.Session.GetString("usertype") == "admin")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1883, "\"", 1932, 1);
#nullable restore
#line 30 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
WriteAttributeValue("", 1890, Url.Action("Index","SimpleUserRegisters"), 1890, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">My Account🔑</a>");
#nullable restore
#line 30 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                                                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1987, "\"", 2025, 1);
#nullable restore
#line 31 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
WriteAttributeValue("", 1994, Url.Action("LogOut","Account"), 1994, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">LogOut</a>\n            </div>\n        </div>\n    </nav>\n</div>\n\n<h1 class=\"display-4\">Your Profile Details </h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62400c9b9e1f6bef9ea8de3bc817412e57d8364813128", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table table-bordered\">\n\n    <thead style=\"background-color:lightgray\">\n        <tr>\n            <th scope=\"col\">\n                ");
#nullable restore
#line 47 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th scope=\"col\">\n                ");
#nullable restore
#line 50 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th scope=\"col\">\n                ");
#nullable restore
#line 53 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th scope=\"col\">\n                ");
#nullable restore
#line 56 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th scope=\"col\">\n                ");
#nullable restore
#line 59 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th scope=\"col\">\n                ");
#nullable restore
#line 62 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th scope=\"col\">\n                ");
#nullable restore
#line 65 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th scope=\"col\">\n                ");
#nullable restore
#line 68 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th scope=\"col\">\n                ");
#nullable restore
#line 71 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 77 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
         foreach (var item in Model)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
             if (HttpContextAccessor.HttpContext.Session.GetString("usertype") == "simple" && HttpContextAccessor.HttpContext.Session.GetString("username") == item.UserName)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 84 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 87 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 90 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 93 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 96 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 99 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 102 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 105 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Pass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 108 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62400c9b9e1f6bef9ea8de3bc817412e57d8364821360", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                                                                   WriteLiteral(item.Suid);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62400c9b9e1f6bef9ea8de3bc817412e57d8364823657", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                                                                      WriteLiteral(item.Suid);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62400c9b9e1f6bef9ea8de3bc817412e57d8364825960", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                                                                   WriteLiteral(item.Suid);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n                    </td>\n                </tr>\n");
#nullable restore
#line 116 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"

            }

            else if (HttpContextAccessor.HttpContext.Session.GetString("usertype") == "admin")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 123 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 126 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 129 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 132 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 135 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 138 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 141 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 144 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Pass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 147 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62400c9b9e1f6bef9ea8de3bc817412e57d8364831870", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 150 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                                                                   WriteLiteral(item.Suid);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62400c9b9e1f6bef9ea8de3bc817412e57d8364834167", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 151 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                                                                      WriteLiteral(item.Suid);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62400c9b9e1f6bef9ea8de3bc817412e57d8364836470", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 152 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
                                                                   WriteLiteral(item.Suid);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n                    </td>\n                </tr>\n");
#nullable restore
#line 155 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"


            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "D:\Carnation\carnationpr-master\Carnation\Carnation\Views\SimpleUserRegisters\Index.cshtml"
             

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Carnation.NewModels.SimpleUserRegister>> Html { get; private set; }
    }
}
#pragma warning restore 1591
