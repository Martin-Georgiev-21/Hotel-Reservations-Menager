#pragma checksum "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b4a1b5f70e119b29ea9cedd1b923317af9ac632"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Hotel_Reservation_Menager.Pages.Clients.Views_Clients_Index), @"mvc.1.0.view", @"/Views/Clients/Index.cshtml")]
namespace Hotel_Reservation_Menager.Pages.Clients
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b4a1b5f70e119b29ea9cedd1b923317af9ac632", @"/Views/Clients/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb0fbe9d63b9662606cc91d4d613af03ca6626f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hotel_Reservation_Menager.Models.Clients>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Clients", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateClient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("Copy code\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
  
    ViewData["Title"] = "Clients";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container p-3\">\r\n    <div class=\"row pt-4\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-primary\">Users List</h2>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b4a1b5f70e119b29ea9cedd1b923317af9ac6325982", async() => {
                WriteLiteral("\r\n                Add New User\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <br /><br />\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b4a1b5f70e119b29ea9cedd1b923317af9ac6327603", async() => {
                WriteLiteral("\r\n                <div class=\"form-group row\">\r\n                    <label class=\"col-sm-4 col-form-label\">Search:</label>\r\n                    <div class=\"col-sm-8\">\r\n                        <input type=\"text\" class=\"form-control\" name=\"searchString\"");
                BeginWriteAttribute("value", " value=\"", 887, "\"", 921, 1);
#nullable restore
#line 28 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
WriteAttributeValue("", 895, ViewData["CurrentFilter"], 895, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>

                <div class=""form-group row"">
                    <label class=""col-sm-4 col-form-label"">Sort by:</label>
                    <div class=""col-sm-8"">
                        <table>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 38 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 41 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
                               Write(Html.ActionLink("▲", "Index", new { sortOrder = ViewBag.NameSortParam == "name_desc" ? "name" : "name_desc", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 42 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
                               Write(Html.ActionLink("▼", "Index", new { sortOrder = ViewBag.NameSortParam, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 45 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 48 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
                               Write(Html.ActionLink("▲", "Index", new { sortOrder = ViewBag.PhoneSortParam == "phone_desc" ? "phone" : "phone_desc", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 49 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
                               Write(Html.ActionLink("▼", "Index", new { sortOrder = ViewBag.PhoneSortParam, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 52 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 55 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
                               Write(Html.ActionLink("▲", "Index", new { sortOrder = ViewBag.EmailSortParam == "email_desc" ? "email" : "email_desc", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 56 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
                               Write(Html.ActionLink("▼", "Index", new { sortOrder = ViewBag.EmailSortParam, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 59 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.IsAdult));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </th>
                            </tr>
                        </table>
                    </div>
                </div>

                <div class=""form-group row"">
                    <div class=""col-sm-12"">
                        <button type=""submit"" class=""btn btn-primary"">Filter</button>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b4a1b5f70e119b29ea9cedd1b923317af9ac63214248", async() => {
                    WriteLiteral("Clear");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
#nullable restore
#line 77 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"" style=""width: 100%"">
            <thead>
                <tr>
                    <th>
                        ID
                    </th>
                    <th>
                        First Name
                    </th>
                    <th>
                        Last Name
                    </th>
                    <th>
                        Phone Number
                    </th>
                    <th>
                        Email Address
                    </th>
                    <th>
                        Adult
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 103 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
                 foreach (var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td width=\"50%\">");
#nullable restore
#line 106 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
                                   Write(obj.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width\r\n\r\n=\"50%\">");
#nullable restore
#line 109 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
  Write(obj.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n<td width=\"50%\">");
#nullable restore
#line 110 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
           Write(obj.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n<td width=\"50%\">");
#nullable restore
#line 111 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
           Write(obj.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n<td width=\"50%\">");
#nullable restore
#line 112 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
           Write(obj.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n<td width=\"50%\">");
#nullable restore
#line 113 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
           Write(obj.IsAdult);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 115 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table>\r\n");
#nullable restore
#line 118 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>No clients found.</p>\r\n");
#nullable restore
#line 122 "C:\Users\Jacqueline Georgieva\Documents\GitHub\Hotel-Reservations-Menager\Hotel-Reservation-Menager\Hotel-Reservation-Menager\Views\Clients\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hotel_Reservation_Menager.Models.Clients>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
