#pragma checksum "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abaed481e61a077bd3343d30c4d51874e3e3138c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_PatientDetails), @"mvc.1.0.view", @"/Views/Patient/PatientDetails.cshtml")]
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
#line 1 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\_ViewImports.cshtml"
using MVCTraining1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\_ViewImports.cshtml"
using MVCTraining1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abaed481e61a077bd3343d30c4d51874e3e3138c", @"/Views/Patient/PatientDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9f971111cf0c7a9675a2c6e8c09ee1105f1ab37", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_PatientDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PatientAdmitViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abaed481e61a077bd3343d30c4d51874e3e3138c4793", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    <title>PatientDetails</title>
    <style>
        table, th, td {
            border: 1px solid black;
        }
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abaed481e61a077bd3343d30c4d51874e3e3138c6307", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome</h1>\r\n        <p>Learn about <a href=\"Index.cshtml\">ASP.NET Core Hospital System</a>.</p>\r\n        <div class=\"float-sm-right\">\r\n            <p>Search Details...</p>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abaed481e61a077bd3343d30c4d51874e3e3138c6835", async() => {
                    WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label for=\"name\">Search By Name Of The Patient:</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"search\" placeholder=\"Enter Name\" name=\"txtsearch\"");
                    BeginWriteAttribute("value", " value=\"", 1187, "\"", 1195, 0);
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-default\"");
                    BeginWriteAttribute("value", " value=\"", 1286, "\"", 1294, 0);
                    EndWriteAttribute();
                    WriteLiteral(" name=\"submit\">Search</button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
    </div>

    <div class=""container"">
        <p>Your Details...</p>
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Number</th>
                    <th>Address</th>
                    <th>Email</th>
                </tr>
            </thead>
");
#nullable restore
#line 50 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
             foreach (var item in Model.allPatients)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tbody>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
                       Write(item.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
                       Write(item.number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
                       Write(item.address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
                       Write(item.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n");
#nullable restore
#line 60 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </table>
    </div>

    <div class=""container"">
        <p>Problems Mapped ( One To Many ) To Treatments</p>
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Problem Name</th>
                    <th>Treatment Provided</th>
                </tr>
            </thead>
");
#nullable restore
#line 73 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
             foreach (var item in Model.allPatients)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
                 foreach (var prob in item.problems)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tbody>\r\n                        <tr>\r\n                            <td>");
#nullable restore
#line 79 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
                           Write(prob.problem);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 81 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
                                 foreach (var treat in prob.treatments)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p>Treatment Name : ");
#nullable restore
#line 83 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
                                                   Write(treat.treatmentName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p>Treatment Dose : ");
#nullable restore
#line 84 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
                                                   Write(treat.dose);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 85 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 89 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\Aayush\source\repos\MVCTraining1\MVCTraining1\Views\Patient\PatientDetails.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PatientAdmitViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
