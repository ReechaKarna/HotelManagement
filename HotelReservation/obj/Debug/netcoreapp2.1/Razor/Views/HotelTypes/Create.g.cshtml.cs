#pragma checksum "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelTypes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d94f0f277a1e6227414188f795381e07a53fe55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HotelTypes_Create), @"mvc.1.0.view", @"/Views/HotelTypes/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HotelTypes/Create.cshtml", typeof(AspNetCore.Views_HotelTypes_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d94f0f277a1e6227414188f795381e07a53fe55", @"/Views/HotelTypes/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02279de2eb6a262d20244d4e795db8416ab4198b", @"/Views/_ViewImports.cshtml")]
    public class Views_HotelTypes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelReservation.Models.HotelType>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black; padding-top:5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:45px;border:1px solid black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelTypes\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_BlankLayout.cshtml";

#line default
#line hidden
            BeginContext(138, 154, true);
            WriteLiteral("\r\n\r\n<div id=\"bg\">\r\n    <div class=\"modal-header\" style=\"border:1px solid black; background-color: #777\">\r\n        <h2>Add  Hotel TYPE</h2>\r\n    </div>\r\n\r\n");
            EndContext();
#line 14 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelTypes\Create.cshtml"
     using (Html.BeginForm("Create", "HotelTypes", FormMethod.Post, new { enctype = "multipart/form-data", @class = "wizard-big wizard clearfix" }))
    {
        

#line default
#line hidden
            BeginContext(458, 23, false);
#line 16 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelTypes\Create.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(487, 172, true);
            WriteLiteral("        <div class=\"modal-body\" style=\"border:1px solid black; margin-top:2px\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(659, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfdd04c3f0414ace950ae17714430e71", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 22 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelTypes\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HotelTypeName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(757, 86, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(843, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5cc257246ac64a5c9f62eb9f658cbd27", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 25 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelTypes\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HotelTypeName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(940, 349, true);
            WriteLiteral(@"
                </div>

            </div>
       
        
        </div>
        <div class=""modal-footer"" style=""border:1px solid black; background-color: #777; margin-top:2px"">
            <input type=""submit"" value=""Create"" class=""btn btn-outline-dark btn-sm"" />

            <button type=""button"" class=""btn btn-outline-dark btn-sm""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\'", 1289, "\'", 1357, 4);
            WriteAttributeValue("", 1299, "window.location.href=\"", 1299, 22, true);
#line 35 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelTypes\Create.cshtml"
WriteAttributeValue("", 1321, Url.Action("Index", "HotelTypes"), 1321, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 1355, "\"", 1355, 1, true);
            WriteAttributeValue(" ", 1356, "", 1357, 1, true);
            EndWriteAttribute();
            BeginContext(1358, 35, true);
            WriteLiteral(">Close</button>\r\n\r\n        </div>\r\n");
            EndContext();
#line 38 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelTypes\Create.cshtml"
    }

#line default
#line hidden
            BeginContext(1400, 40, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1458, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 57 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelTypes\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelReservation.Models.HotelType> Html { get; private set; }
    }
}
#pragma warning restore 1591