#pragma checksum "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d63ef882b273330c53a5304191b603f449da9f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_en_Details), @"mvc.1.0.view", @"/Views/Employee/en/Details.cshtml")]
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
#line 1 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\_ViewImports.cshtml"
using HrSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\_ViewImports.cshtml"
using HrSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d63ef882b273330c53a5304191b603f449da9f3", @"/Views/Employee/en/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c400f7145c886ca6899f3334292d2f6d3f90f9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_en_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HrSystem.Models.EmployeeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imgs/pdf.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
   //Layout = null;
    ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""list-group-item-info modal-title text-center"">
    <h2>Employees-Details</h2>
</div>
<hr />
<div class=""form-row"">
    <div class=""col-md-12"">
        <div class=""row"">
            <div class=""col-md-2"" style=""margin:15px;"">
                <img");
            BeginWriteAttribute("src", " src=\"", 357, "\"", 407, 2);
            WriteAttributeValue("", 363, "/MediaFiles/Employees/Images/", 363, 29, true);
#nullable restore
#line 14 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
WriteAttributeValue("", 392, Model.Img_Name, 392, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 408, "\"", 434, 1);
#nullable restore
#line 14 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
WriteAttributeValue("", 414, Model.First_Name_En, 414, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px;height:auto;\" />\n\n            </div>\n");
#nullable restore
#line 17 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
             if(Model.AttachmentFile!=null&&!string.IsNullOrEmpty(Model.AttachmentFile))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-2\">\n                <div class=\"card\" style=\"margin: 15px; width: 150px; height: auto;\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1d63ef882b273330c53a5304191b603f449da9f36738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <div class=\"card-body\">\n                        <h5>View PDF</h5>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 905, "\"", 987, 1);
#nullable restore
#line 24 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
WriteAttributeValue("", 912, Url.Action("ViewPdf", "Employee", new { fileName = Model.AttachmentFile }), 912, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\n                            View PDF\n                        </a>\n");
            WriteLiteral("                    </div>\n                </div>\n\n            </div>\n");
#nullable restore
#line 32 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col\">\n                <span class=\"badge badge-info\">First Name English:</span>\n                ");
#nullable restore
#line 35 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.First_Name_En));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n                <span class=\"badge badge-info\">Last Name English:</span>\n                ");
#nullable restore
#line 37 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.Last_Name_En));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n                <span class=\"badge badge-info\">First Name Arabic:</span>\n                ");
#nullable restore
#line 39 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.First_Name_Ar));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n                <span class=\"badge badge-info\">Last Name Arabic:</span>\n                ");
#nullable restore
#line 41 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.Last_Name_Ar));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n                <span class=\"badge badge-info\">Phone Number:</span>\n                ");
#nullable restore
#line 43 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.Phone_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n                <span class=\"badge badge-info\">Email:</span>\n                ");
#nullable restore
#line 45 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n                <span class=\"badge badge-info\">Added Date :</span>\n");
#nullable restore
#line 47 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                 if(Model.AddedDate!=null){
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Model.AddedDate.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                                                             
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n                <!--<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-4\">First Name English:</div>\n        <div class=\"col\">");
#nullable restore
#line 53 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                    Write(Html.DisplayFor(m => m.First_Name_En));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>-->\n                <!-- Force next columns to break to new line at md breakpoint and up -->\n                <!--<div class=\"w-100 d-none d-md-block\"></div>\n\n        <div class=\"col-4\">Last Name English:</div>\n        <div class=\"col\">");
#nullable restore
#line 58 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                    Write(Html.DisplayFor(m => m.Last_Name_En));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    </div>\n    <div class=\"row\">\n        <div class=\"col-4\">First Name Arabic:</div>\n        <div class=\"col\">");
#nullable restore
#line 62 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                    Write(Html.DisplayFor(m => m.First_Name_Ar));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>-->\n                <!-- Force next columns to break to new line at md breakpoint and up -->\n                <!--<div class=\"w-100 d-none d-md-block\"></div>\n\n            <div class=\"col-4\">Last Name Arabic:</div>\n            <div class=\"col\">");
#nullable restore
#line 67 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                        Write(Html.DisplayFor(m => m.Last_Name_Ar));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        </div>\n    </div>-->\n            </div>\n        </div>\n        <div class=\"row\">\n            <div class=\"col\">\n                <span class=\"badge badge-info\">Date Of Hire:</span>\n");
#nullable restore
#line 75 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                 if(Model.Hire_Date!=null){
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Model.Hire_Date.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                                                             
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n                <span class=\"badge badge-info h4\">Department Name:</span>\n                ");
#nullable restore
#line 79 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.Department.Name_En));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n\n                <span class=\"badge badge-info h4\">Birth Place:</span>\n                ");
#nullable restore
#line 82 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.BirthPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n                <span class=\"badge badge-info h4\">Birth Of Date:</span>\n");
#nullable restore
#line 84 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                 if(Model.BirthOfDate!=null){
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Model.BirthOfDate.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                                                               
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n                <span class=\"badge badge-info h4\">Identity Type :</span>\n                ");
#nullable restore
#line 88 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.IdentityTypeObject.Name_En));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n\n                <span class=\"badge badge-info h4\">Identity Issu Date:</span>\n");
#nullable restore
#line 91 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                 if(Model.IdentityIssuDate!=null){
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Model.IdentityIssuDate.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                                                                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n\n                <span class=\"badge badge-info h4\">Identity Issu Place:</span>\n                ");
#nullable restore
#line 96 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.IdentityIssuPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n            </div>\n            <div class=\"col\">\n                <span class=\"badge badge-info\">Address:</span>\n                ");
#nullable restore
#line 100 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n                <span class=\"badge badge-info h4\">City Name:</span>\n                ");
#nullable restore
#line 102 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.City.CityName_En));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n\n                <span class=\"badge badge-info h4\">Nationality :</span>\n                ");
#nullable restore
#line 105 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.Nationality.Nationality_En));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n                <span class=\"badge badge-info h3\">Country of Residence:</span>\n                ");
#nullable restore
#line 107 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.Country.CountryName_En));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n                <span class=\"badge badge-info h3\">Identity Number:</span>\n                ");
#nullable restore
#line 109 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.IdentityNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n                <span class=\"badge badge-info h3\">Identity Expired Date:</span>\n");
#nullable restore
#line 111 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                 if(Model.IdentityExpiredDate!=null){
                   

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
              Write(Model.IdentityExpiredDate.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
                                                                          
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\n                <span class=\"badge badge-info h3\">Blood Type:</span>\n                ");
#nullable restore
#line 116 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
           Write(Html.DisplayFor(m => m.BloodType));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n            </div>\n        </div>\n        <hr />\n        \n        <div class=\"row\">\n            <div class=\"col\">\n             <a");
            BeginWriteAttribute("href", " href=\"", 5769, "\"", 5800, 2);
            WriteAttributeValue("", 5776, "/employee/edit/", 5776, 15, true);
#nullable restore
#line 123 "E:\SharedApps\GitHub\HrSystemMvcNetCore\Views\Employee\en\Details.cshtml"
WriteAttributeValue("", 5791, Model.Id, 5791, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-block\">Edit</a>\n            </div>\n\n            <div class=\"col\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d63ef882b273330c53a5304191b603f449da9f321093", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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

    </div>
</div>

<script>function IsValidImage() {
        var fileInput = document.getElementById('fileupload');
        var filePath = fileInput.value;
        var allowedExtensions = /(\.jpg|\.jpeg|\.png|\.bmp|\.gif)$/i;
        if (!allowedExtensions.exec(filePath)) {
            alert('Please upload file having extensions .jpeg/.jpg/.png/.gif/.bmp only.');
            fileInput.value = '';
            return false;
        }
    }</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HrSystem.Models.EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
