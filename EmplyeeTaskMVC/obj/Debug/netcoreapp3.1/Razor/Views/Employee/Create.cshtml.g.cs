#pragma checksum "E:\ASP.NET\EmplyeeTaskMVC\Views\Employee\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88aaad6da494eafc4b3e72ad26377618f7bfe24e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Create), @"mvc.1.0.view", @"/Views/Employee/Create.cshtml")]
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
#line 1 "E:\ASP.NET\EmplyeeTaskMVC\Views\_ViewImports.cshtml"
using EmplyeeTaskMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ASP.NET\EmplyeeTaskMVC\Views\_ViewImports.cshtml"
using EmplyeeTaskMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88aaad6da494eafc4b3e72ad26377618f7bfe24e", @"/Views/Employee/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7133e3150f93a90a71aaaa5a76411e9db751f9eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ASP.NET\EmplyeeTaskMVC\Views\Employee\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n");
#nullable restore
#line 7 "E:\ASP.NET\EmplyeeTaskMVC\Views\Employee\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <td>Employee Id</td>\r\n        <td>");
#nullable restore
#line 12 "E:\ASP.NET\EmplyeeTaskMVC\Views\Employee\Create.cshtml"
       Write(Html.TextBoxFor(m => m.EmpId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Name</td>\r\n        <td>");
#nullable restore
#line 16 "E:\ASP.NET\EmplyeeTaskMVC\Views\Employee\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Country</td>\r\n        <td>");
#nullable restore
#line 20 "E:\ASP.NET\EmplyeeTaskMVC\Views\Employee\Create.cshtml"
       Write(Html.DropDownListFor(m => m.Designation, ViewBag.designation as SelectList));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Project Name</td>\r\n        <td>");
#nullable restore
#line 24 "E:\ASP.NET\EmplyeeTaskMVC\Views\Employee\Create.cshtml"
       Write(Html.DropDownListFor(m => m.ProjName, ViewBag.proj as SelectList));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Password</td>\r\n        <td>");
#nullable restore
#line 28 "E:\ASP.NET\EmplyeeTaskMVC\Views\Employee\Create.cshtml"
       Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td colspan=\"2\">\r\n            <input type=\"submit\" value=\"Register\" />\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 36 "E:\ASP.NET\EmplyeeTaskMVC\Views\Employee\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
