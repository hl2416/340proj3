#pragma checksum "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe49cc5783a572a19f89f8cc382947b4fc457c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Faculty), @"mvc.1.0.view", @"/Views/Home/Faculty.cshtml")]
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
#line 1 "C:\Users\ghydr\Desktop\project3\project3\Views\_ViewImports.cshtml"
using project3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ghydr\Desktop\project3\project3\Views\_ViewImports.cshtml"
using project3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe49cc5783a572a19f89f8cc382947b4fc457c2", @"/Views/Home/Faculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afaf369518f583157046eeb27a6069d5ed7bd74d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Faculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<project3.Models.FacultyRootModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
  
    ViewData["Title"] = "iSchool Faculty";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Faculty page that checks for empty strings and null with modal -->\r\n<div class=\"page\">\r\n    <h1><b>iSchool Faculty</b></h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
     foreach (var faculty in Model.faculty)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"min-height:260px;width:200px;display:inline-table\">\r\n            <div class=\"thumbnail\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 410, "\"", 434, 1);
#nullable restore
#line 15 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 416, faculty.imagePath, 416, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" atl=\"pic\" style=\"width:200px;height:200px\" />\r\n                <div id=\"buttons\" style=\"margin-top:30px\"><a");
            BeginWriteAttribute("href", " href=\"", 543, "\"", 568, 2);
            WriteAttributeValue("", 550, "#", 550, 1, true);
#nullable restore
#line 16 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 551, faculty.username, 551, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" rel=\"modal:open\">");
#nullable restore
#line 16 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                                                                                                   Write(faculty.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n            </div>\r\n            <div");
            BeginWriteAttribute("id", " id=\"", 648, "\"", 670, 1);
#nullable restore
#line 18 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 653, faculty.username, 653, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal\" style=\"font-size:12px\">\r\n                <div style=\"text-align:center\"><img");
            BeginWriteAttribute("src", " src=\"", 762, "\"", 786, 1);
#nullable restore
#line 19 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 768, faculty.imagePath, 768, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" atl=\"pic\" style=\"width:150px;height:150px\" /></div><hr />\r\n                <div>");
#nullable restore
#line 20 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                Write(faculty.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 20 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                               Write(faculty.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><hr />\r\n");
#nullable restore
#line 21 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                 if (faculty.tagline != "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>");
#nullable restore
#line 23 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                    Write(faculty.tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><hr />\r\n");
#nullable restore
#line 24 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>Interest Area: ");
#nullable restore
#line 25 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                               Write(faculty.interestArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><hr />\r\n                <div>Office: ");
#nullable restore
#line 26 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                        Write(faculty.office);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><hr />\r\n");
#nullable restore
#line 27 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                 if (faculty.website != "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1264, "\"", 1287, 1);
#nullable restore
#line 29 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 1271, faculty.website, 1271, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Website</a><hr />\r\n");
#nullable restore
#line 30 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                 if (faculty.phone != "" & faculty.phone != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1451, "\"", 1476, 2);
            WriteAttributeValue("", 1458, "tel:", 1458, 4, true);
#nullable restore
#line 33 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 1462, faculty.phone, 1462, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                                            Write(faculty.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><hr />\r\n");
#nullable restore
#line 34 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 1541, "\"", 1569, 2);
            WriteAttributeValue("", 1548, "mailto:", 1548, 7, true);
#nullable restore
#line 35 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 1555, faculty.email, 1555, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                                           Write(faculty.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><hr />\r\n");
#nullable restore
#line 36 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                 if (faculty.twitter != "" & faculty.twitter != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1709, "\"", 1752, 2);
            WriteAttributeValue("", 1716, "https://twitter.com/", 1716, 20, true);
#nullable restore
#line 38 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 1736, faculty.twitter, 1736, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Twitter</a><hr />\r\n");
#nullable restore
#line 39 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                 if (faculty.facebook != "" & faculty.facebook != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1922, "\"", 1967, 2);
            WriteAttributeValue("", 1929, "https://facebook.com/", 1929, 21, true);
#nullable restore
#line 42 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 1950, faculty.facebook, 1950, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Facebook</a><hr />\r\n");
#nullable restore
#line 43 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"buttons\" style=\"text-align:center\"><a href=\"#\" rel=\"modal:close\">Close</a></div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 47 "C:\Users\ghydr\Desktop\project3\project3\Views\Home\Faculty.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/jquery-modal/0.9.1/jquery.modal.min.css\" />\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <!-- JQuery Modal File from https://github.com/kylefox/jquery-modal -->\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery-modal/0.9.1/jquery.modal.min.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<project3.Models.FacultyRootModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
