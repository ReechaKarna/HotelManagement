#pragma checksum "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa0fd215ebeee3bf37628abf2e589933ee533ec8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 1 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\_ViewImports.cshtml"
using HotelReservation;

#line default
#line hidden
#line 2 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\_ViewImports.cshtml"
using HotelReservation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa0fd215ebeee3bf37628abf2e589933ee533ec8", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02279de2eb6a262d20244d4e795db8416ab4198b", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelReservation.Models.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/easy-responsive-tabs.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = null;

#line default
#line hidden
            BeginContext(114, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(139, 474, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23c6223e3fb84fe2ad78746ccf92df45", async() => {
                BeginContext(145, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(151, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e87fe6a9100a453391b4af2b12c8f972", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(203, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(209, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c9f9e48f670406992b5311311ecfbb0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(257, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(263, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb96b5fa3b894c6f98652f1d96ba50b3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(326, 280, true);
                WriteLiteral(@"
    <link href=""//fonts.googleapis.com/css?family=Prompt:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i&amp;subset=latin-ext,thai,vietnamese"" rel=""stylesheet"">
    <link href=""//fonts.googleapis.com/css?family=Merriweather"" rel=""stylesheet"">
");
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
            BeginContext(613, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(615, 2512, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "897baaf9e1f74951993e80068f2eda46", async() => {
                BeginContext(621, 413, true);
                WriteLiteral(@"
    <div class=""header"" style=""background-color:black"">
        <div class=""container"">
            <div class=""w3_agile_logo"">
                <h1 style=""color:red"">BOOKING HOTELS </h1>
                <h4 style=""color:white; text-align:right"">IN NEPAL</h4>
            </div>

        </div>
    </div>
    <div class=""header"">

        <h1 style=""padding-left:80px"">Register</h1>

    </div>

");
                EndContext();
#line 31 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\Account\Register.cshtml"
     using (Html.BeginForm("Register", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
    {
        

#line default
#line hidden
                BeginContext(1170, 23, false);
#line 33 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\Account\Register.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(1202, 100, true);
                WriteLiteral("        <h4 style=\"padding-left:40px; padding-top:30px\">Create a new account.</h4>\r\n        <hr />\r\n");
                EndContext();
                BeginContext(1311, 24, false);
#line 37 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\Account\Register.cshtml"
   Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(1337, 192, true);
                WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-6\" style=\"padding-left:60px\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-4\">\r\n                        ");
                EndContext();
                BeginContext(1530, 64, false);
#line 42 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\Account\Register.cshtml"
                   Write(Html.LabelFor(m => m.UserName, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1594, 98, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-8\">\r\n                        ");
                EndContext();
                BeginContext(1693, 65, false);
#line 45 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\Account\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1758, 182, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\" style=\"padding-top:10px\">\r\n                    <div class=\"col-sm-4\">\r\n                        ");
                EndContext();
                BeginContext(1941, 64, false);
#line 50 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\Account\Register.cshtml"
                   Write(Html.LabelFor(m => m.Password, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(2005, 98, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n                        ");
                EndContext();
                BeginContext(2104, 66, false);
#line 53 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\Account\Register.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2170, 182, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\" style=\"padding-top:10px\">\r\n                    <div class=\"col-sm-4\">\r\n                        ");
                EndContext();
                BeginContext(2353, 71, false);
#line 58 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\Account\Register.cshtml"
                   Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(2424, 98, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n                        ");
                EndContext();
                BeginContext(2523, 73, false);
#line 61 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\Account\Register.cshtml"
                   Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2596, 515, true);
                WriteLiteral(@"
                    </div>
                </div>
           


                <div>




                    <div class=""row"" style=""padding-top:10px"">
                        <div class=""col-sm-10"">

                        </div>
                        <div class=""col-md-2"">
                            <input type=""submit"" class=""btn btn-default"" value=""Register"" />
                        </div>
                    </div>
                </div>


            </div>
        </div>
");
                EndContext();
#line 85 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\Account\Register.cshtml"
    }

#line default
#line hidden
                BeginContext(3118, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(3127, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelReservation.Models.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591