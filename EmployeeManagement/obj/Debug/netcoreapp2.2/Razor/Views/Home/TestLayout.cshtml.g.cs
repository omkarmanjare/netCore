#pragma checksum "C:\Learning\NetCore\EmployeeManagement\Views\Home\TestLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2895fc1dc33d5dc64ea99cfc083a671195163b8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TestLayout), @"mvc.1.0.view", @"/Views/Home/TestLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TestLayout.cshtml", typeof(AspNetCore.Views_Home_TestLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2895fc1dc33d5dc64ea99cfc083a671195163b8b", @"/Views/Home/TestLayout.cshtml")]
    public class Views_Home_TestLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeManagement.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Learning\NetCore\EmployeeManagement\Views\Home\TestLayout.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "TestLayout";    

#line default
#line hidden
            BeginContext(152, 229, true);
            WriteLiteral("\r\n<table>\r\n        <thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>Name</th>\r\n                <th>Department</th>\r\n                <th>Email</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 18 "C:\Learning\NetCore\EmployeeManagement\Views\Home\TestLayout.cshtml"
             foreach (var employee in Model)
            {

#line default
#line hidden
            BeginContext(442, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(489, 11, false);
#line 21 "C:\Learning\NetCore\EmployeeManagement\Views\Home\TestLayout.cshtml"
                   Write(employee.Id);

#line default
#line hidden
            EndContext();
            BeginContext(500, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(532, 13, false);
#line 22 "C:\Learning\NetCore\EmployeeManagement\Views\Home\TestLayout.cshtml"
                   Write(employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(545, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(577, 19, false);
#line 23 "C:\Learning\NetCore\EmployeeManagement\Views\Home\TestLayout.cshtml"
                   Write(employee.Department);

#line default
#line hidden
            EndContext();
            BeginContext(596, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(628, 16, false);
#line 24 "C:\Learning\NetCore\EmployeeManagement\Views\Home\TestLayout.cshtml"
                   Write(employee.EmailId);

#line default
#line hidden
            EndContext();
            BeginContext(644, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 26 "C:\Learning\NetCore\EmployeeManagement\Views\Home\TestLayout.cshtml"
            }

#line default
#line hidden
            BeginContext(689, 36, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeManagement.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
