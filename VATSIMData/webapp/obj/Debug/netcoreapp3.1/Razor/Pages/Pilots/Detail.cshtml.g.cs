#pragma checksum "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8389c537021f06292941065b2be6aa58143e488"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VATSIMData.WebApp.Pages.Pilots.Pages_Pilots_Detail), @"mvc.1.0.razor-page", @"/Pages/Pilots/Detail.cshtml")]
namespace VATSIMData.WebApp.Pages.Pilots
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
#line 2 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\_ViewImports.cshtml"
using VatsimLibrary.VatsimClientV1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\_ViewImports.cshtml"
using VatsimLibrary.VatsimDb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8389c537021f06292941065b2be6aa58143e488", @"/Pages/Pilots/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a53c460e80849346271656d2892ba2ac41ee2142", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pilots_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Pilots/Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
   
    Layout = null;
    /* Borrowing from this: https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/sort-filter-page?view=aspnetcore-3.1 */

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8389c537021f06292941065b2be6aa58143e4884066", async() => {
                WriteLiteral("\n    <link href=\"/lib/twitter-bootstrap/css/bootstrap.min.css\" rel=\"stylesheet\" />\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8389c537021f06292941065b2be6aa58143e4885115", async() => {
                WriteLiteral("\n    <div class=\"container\">\n        <h1>Pilot Details</h1>\n        <ul>\n            <li>\n                ");
#nullable restore
#line 18 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
           Write(Model.Pilot.Cid);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </li>            \n            <li>\n                ");
#nullable restore
#line 21 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
           Write(Model.Pilot.Realname);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </li>\n            <li>\n                ");
#nullable restore
#line 24 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
           Write(Model.Pilot.Callsign);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </li>\n            <li>\n                ");
#nullable restore
#line 27 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
           Write(Model.Pilot.TimeLogon);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </li>
        </ul>
        <table class=""table table-sm table-striped table-bordered"">
            <thead>
                <tr>
                    <th>
                        Latitude
                    </th>
                    <th>
                        Longitude
                    </th>
                    <th>
                        Time Last ATIS Received
                    </th>
                    <th>
                        Altitude
                    </th>
                    <th>
                        Ground Speed
                    </th>
                    <th>
                        Transponder
                    </th>
                    <th>
                        Heading
                    </th>
                    <th>
                        QNH_iHg
                    </th>
                    <th>
                        QNH_Mb
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 63 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                 foreach (var position in Model.Positions)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <td>\n                            ");
#nullable restore
#line 67 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                       Write(position.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 70 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                       Write(position.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 73 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                       Write(position.TimeLastAtisReceived);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 76 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                       Write(position.Altitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 79 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                       Write(position.Groundspeed);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 82 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                       Write(position.Transponder);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 85 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                       Write(position.Heading);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 88 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                       Write(position.QNH_iHg);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 91 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                       Write(position.QNH_Mb);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        \n                    </tr>\n");
#nullable restore
#line 95 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </tbody>
        </table>

        <table class=""table table-sm table-striped table-bordered"">
            <thead>
                <tr>
                    <th>
                        Detials about the flight
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        Top Speed:
                    </td>
                    <td>
                        ");
#nullable restore
#line 113 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                   Write(Model.topSpeed);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                </tr>\n                <tr>\n                    <td>\n                        Highest Altitude:\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 121 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                   Write(Model.highestAltitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                </tr>\n                <tr>\n                    <td>\n                        Farthest East:\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 129 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                   Write(Model.farthestEast);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                </tr>\n                <tr>\n                    <td>\n                        Farthest West:\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 137 "C:\Users\Kevin\Documents\Final Project\VATSIMData\webapp\Pages\Pilots\Detail.cshtml"
                   Write(Model.farthestSouth);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                </tr>\n            </tbody>\n        </table>\n        <p>\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8389c537021f06292941065b2be6aa58143e48813493", async() => {
                    WriteLiteral("\n                Back to Pilot Search\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </p>\n    </div>\n");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PilotDetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PilotDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PilotDetailModel>)PageContext?.ViewData;
        public PilotDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
