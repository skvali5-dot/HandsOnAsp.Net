#pragma checksum "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9197a438bae2ead39e58c0690d47ee9e69ce56f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Create), @"mvc.1.0.view", @"/Views/Account/Create.cshtml")]
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
#line 1 "E:\ASP.NET\ModelValidations\Views\_ViewImports.cshtml"
using ModelValidations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ASP.NET\ModelValidations\Views\_ViewImports.cshtml"
using ModelValidations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9197a438bae2ead39e58c0690d47ee9e69ce56f2", @"/Views/Account/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63b7c22a5e7d95b3f21282103be995331cacfa32", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n");
#nullable restore
#line 7 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <td>");
#nullable restore
#line 11 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 12 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 13 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 16 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 21 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.MailID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m => m.MailID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.MailID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 26 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.mobileNO));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m => m.mobileNO));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.mobileNO));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 31 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 36 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 41 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.CmpPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 42 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m=>m.CmpPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 43 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.CmpPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td colspan=\"2\" align=\"center\">\r\n            <input type=\"submit\" value=\"Register\" class=\"btn btn-outline-primary\" />\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 51 "E:\ASP.NET\ModelValidations\Views\Account\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591