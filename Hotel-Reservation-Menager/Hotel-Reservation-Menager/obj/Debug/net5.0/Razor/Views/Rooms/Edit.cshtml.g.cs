#pragma checksum "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a807d64ca1854dd28100383135d4adf02a0ead6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Hotel_Reservation_Menager.Pages.Rooms.Views_Rooms_Edit), @"mvc.1.0.view", @"/Views/Rooms/Edit.cshtml")]
namespace Hotel_Reservation_Menager.Pages.Rooms
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
#line 1 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Menager;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a807d64ca1854dd28100383135d4adf02a0ead6", @"/Views/Rooms/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb0fbe9d63b9662606cc91d4d613af03ca6626f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Rooms_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hotel_Reservation_Menager.Models.Rooms>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Rooms</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 16 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
       Write(Html.LabelFor(model => model.Capacity, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 22 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
           Write(Html.EditorFor(model => model.Capacity, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 23 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Capacity, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
       Write(Html.LabelFor(model => model.Type, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 30 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
           Write(Html.EditorFor(model => model.Type, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 31 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Type, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
       Write(Html.LabelFor(model => model.IsAvailable, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                <div class=\"checkbox\">\r\n                    ");
#nullable restore
#line 39 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
               Write(Html.EditorFor(model => model.IsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 40 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.IsAvailable, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
       Write(Html.LabelFor(model => model.PricePerAdult, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 48 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
           Write(Html.EditorFor(model => model.PricePerAdult, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 49 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.PricePerAdult, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
       Write(Html.LabelFor(model => model.PricePerChild, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 56 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
           Write(Html.EditorFor(model => model.PricePerChild, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 57 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.PricePerChild, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
       Write(Html.LabelFor(model => model.Number, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 64 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
           Write(Html.EditorFor(model => model.Number, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 65 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Number, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a807d64ca1854dd28100383135d4adf02a0ead613426", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 72 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
   
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Rooms\Edit.cshtml"
  await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hotel_Reservation_Menager.Models.Rooms> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
