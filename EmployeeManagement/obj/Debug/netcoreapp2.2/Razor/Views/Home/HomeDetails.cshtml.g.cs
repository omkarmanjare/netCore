#pragma checksum "C:\Learning\NetCore\EmployeeManagement\Views\Home\HomeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6561dabe0623bf3fddf2356ce350fabfa16ef894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomeDetails), @"mvc.1.0.view", @"/Views/Home/HomeDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/HomeDetails.cshtml", typeof(AspNetCore.Views_Home_HomeDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6561dabe0623bf3fddf2356ce350fabfa16ef894", @"/Views/Home/HomeDetails.cshtml")]
    public class Views_Home_HomeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeManagement.Models.ViewModel.HomeDetailsViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(132, 47, true);
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            EndContext();
            BeginContext(179, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6561dabe0623bf3fddf2356ce350fabfa16ef8942989", async() => {
                BeginContext(185, 23, true);
                WriteLiteral("\r\n    <title></title>\r\n");
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
            BeginContext(215, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(217, 363, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6561dabe0623bf3fddf2356ce350fabfa16ef8944194", async() => {
                BeginContext(223, 53, true);
                WriteLiteral("\r\n    <h3>By Using ViewModel- HomeDetailsViewModel : ");
                EndContext();
                BeginContext(277, 15, false);
#line 8 "C:\Learning\NetCore\EmployeeManagement\Views\Home\HomeDetails.cshtml"
                                              Write(Model.PageTitle);

#line default
#line hidden
                EndContext();
                BeginContext(292, 36, true);
                WriteLiteral(" </h3>\r\n\r\n    <div>\r\n        Name : ");
                EndContext();
                BeginContext(329, 19, false);
#line 11 "C:\Learning\NetCore\EmployeeManagement\Views\Home\HomeDetails.cshtml"
          Write(Model.Employee.Name);

#line default
#line hidden
                EndContext();
                BeginContext(348, 49, true);
                WriteLiteral(";\r\n    </div>\r\n\r\n    <div>\r\n        Department : ");
                EndContext();
                BeginContext(398, 25, false);
#line 15 "C:\Learning\NetCore\EmployeeManagement\Views\Home\HomeDetails.cshtml"
                Write(Model.Employee.Department);

#line default
#line hidden
                EndContext();
                BeginContext(423, 41, true);
                WriteLiteral(";\r\n    </div>\r\n\r\n    <div>\r\n        Id : ");
                EndContext();
                BeginContext(465, 14, false);
#line 19 "C:\Learning\NetCore\EmployeeManagement\Views\Home\HomeDetails.cshtml"
        Write(Model.Employee);

#line default
#line hidden
                EndContext();
                BeginContext(479, 48, true);
                WriteLiteral("..Id;\r\n    </div>\r\n\r\n    <div>\r\n        Email : ");
                EndContext();
                BeginContext(528, 22, false);
#line 23 "C:\Learning\NetCore\EmployeeManagement\Views\Home\HomeDetails.cshtml"
           Write(Model.Employee.EmailId);

#line default
#line hidden
                EndContext();
                BeginContext(550, 23, true);
                WriteLiteral(";\r\n    </div>\r\n\r\n    \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(580, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeManagement.Models.ViewModel.HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
