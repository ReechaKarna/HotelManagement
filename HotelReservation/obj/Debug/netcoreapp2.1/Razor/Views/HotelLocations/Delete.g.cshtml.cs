#pragma checksum "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelLocations\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "136ca9b5722858a2f2aebc968c5171242284e457"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HotelLocations_Delete), @"mvc.1.0.view", @"/Views/HotelLocations/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HotelLocations/Delete.cshtml", typeof(AspNetCore.Views_HotelLocations_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"136ca9b5722858a2f2aebc968c5171242284e457", @"/Views/HotelLocations/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02279de2eb6a262d20244d4e795db8416ab4198b", @"/Views/_ViewImports.cshtml")]
    public class Views_HotelLocations_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelReservation.Models.HotelLocation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelLocations\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
   Layout = "~/Views/Shared/_BlankLayout.cshtml";

#line default
#line hidden
            BeginContext(141, 179, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n\r\n<div id=\"bg\">\r\n    <div class=\"modal-header\" style=\"border:1px solid black; background-color: #777\">\r\n        <h2>Delete Hotel Location</h2>\r\n    </div>\r\n\r\n");
            EndContext();
#line 16 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelLocations\Delete.cshtml"
     using (Html.BeginForm("Delete", "HotelLocations", FormMethod.Post, new { enctype = "multipart/form-data", @class = "wizard-big wizard clearfix" }))
    {
        

#line default
#line hidden
            BeginContext(490, 23, false);
#line 18 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelLocations\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(526, 38, false);
#line 20 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelLocations\Delete.cshtml"
   Write(Html.HiddenFor(x => x.HotelLocationId));

#line default
#line hidden
            EndContext();
            BeginContext(566, 437, true);
            WriteLiteral(@"        <div class=""modal-body"" style=""border:1px solid black; margin-top:2px"">
            <text>Are you sure you want to delete this?</text>

        </div>
        <div class=""modal-footer"" style=""border:1px solid black; background-color: #777; margin-top:2px"">
            <input type=""submit"" value=""Delete"" class=""btn btn-outline-dark btn-danger"" />



            <button type=""button"" class=""btn btn-outline-dark btn-sm""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\'", 1003, "\'", 1075, 4);
            WriteAttributeValue("", 1013, "window.location.href=\"", 1013, 22, true);
#line 30 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelLocations\Delete.cshtml"
WriteAttributeValue("", 1035, Url.Action("Index", "HotelLocations"), 1035, 38, false);

#line default
#line hidden
            WriteAttributeValue("", 1073, "\"", 1073, 1, true);
            WriteAttributeValue(" ", 1074, "", 1075, 1, true);
            EndWriteAttribute();
            BeginContext(1076, 32, true);
            WriteLiteral(">No</button>\r\n\r\n        </div>\r\n");
            EndContext();
#line 33 "D:\MphasisTech\HotelRegistrationSystem\HotelReservation\Views\HotelLocations\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(1115, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelReservation.Models.HotelLocation> Html { get; private set; }
    }
}
#pragma warning restore 1591