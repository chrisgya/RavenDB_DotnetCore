#pragma checksum "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16eaab7b8ad3ebf569e65368a40a5091a742aee7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Talk), @"mvc.1.0.razor-page", @"/Pages/Talk.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Talk.cshtml", typeof(AspNetCore.Pages_Talk), @"{id}")]
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
#line 1 "C:\Projects\RavenDB-DotNetCore-App\Pages\_ViewImports.cshtml"
using RavenDB_DotNetCore_App;

#line default
#line hidden
#line 2 "C:\Projects\RavenDB-DotNetCore-App\Pages\_ViewImports.cshtml"
using RavenDB_DotNetCore_App.Components;

#line default
#line hidden
#line 3 "C:\Projects\RavenDB-DotNetCore-App\Pages\_ViewImports.cshtml"
using RavenDB_DotNetCore_App.Models;

#line default
#line hidden
#line 4 "C:\Projects\RavenDB-DotNetCore-App\Pages\_ViewImports.cshtml"
using RavenDB_DotNetCore_App.Pages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16eaab7b8ad3ebf569e65368a40a5091a742aee7", @"/Pages/Talk.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"711a5e58bc3b83ac39644803f263730b51a3a249", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Talk : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Talk", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("badge badge-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
   ViewBag.Title = Model.Talk.Headline + " : Talks"; 

#line default
#line hidden
            BeginContext(87, 108, true);
            WriteLiteral("\r\n<div class=\"d-flex justify-content-between mb-5\">\r\n    <div class=\"w-75 pr-5\">\r\n        <h1>\r\n            ");
            EndContext();
            BeginContext(196, 19, false);
#line 8 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
       Write(Model.Talk.Headline);

#line default
#line hidden
            EndContext();
            BeginContext(215, 59, true);
            WriteLiteral(" \r\n            <small class=\"text-muted\">\r\n                ");
            EndContext();
            BeginContext(274, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16eaab7b8ad3ebf569e65368a40a5091a742aee77821", async() => {
                BeginContext(336, 22, false);
#line 10 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                                                                        Write(Model.Talk.SpeakerName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-speaker", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                                            WriteLiteral(Model.Talk.Speaker);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["speaker"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-speaker", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["speaker"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(362, 65, true);
            WriteLiteral("\r\n            </small>\r\n        </h1>\r\n\r\n        <p class=\"lead\">");
            EndContext();
            BeginContext(428, 22, false);
#line 14 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                   Write(Model.Talk.Description);

#line default
#line hidden
            EndContext();
            BeginContext(450, 16, true);
            WriteLiteral("</p>\r\n        \r\n");
            EndContext();
#line 16 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
         if (Model.Talk.SpeakerTalks.Length > 0) {

#line default
#line hidden
            BeginContext(518, 86, true);
            WriteLiteral("            <div class=\"w-50\">\r\n                <h6 class=\"text-muted\">Other talks by ");
            EndContext();
            BeginContext(605, 22, false);
#line 18 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                                                 Write(Model.Talk.SpeakerName);

#line default
#line hidden
            EndContext();
            BeginContext(627, 56, true);
            WriteLiteral("</h6>\r\n\r\n                <div class=\"list-group mb-3\">\r\n");
            EndContext();
#line 21 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                 foreach (var talk in Model.Talk.SpeakerTalks) {


#line default
#line hidden
            BeginContext(751, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(771, 516, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16eaab7b8ad3ebf569e65368a40a5091a742aee711759", async() => {
                BeginContext(845, 157, true);
                WriteLiteral("\r\n                        <div class=\"d-flex w-100 justify-content-between\">\r\n                            <h5 class=\"mb-1\">\r\n                                ");
                EndContext();
                BeginContext(1003, 13, false);
#line 26 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                           Write(talk.Headline);

#line default
#line hidden
                EndContext();
                BeginContext(1016, 102, true);
                WriteLiteral("\r\n                            </h5>\r\n                            <small class=\"text-muted text-right\">");
                EndContext();
                BeginContext(1119, 36, false);
#line 28 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                                                            Write(talk.Published.ToString("MMMM yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(1155, 73, true);
                WriteLiteral("</small>\r\n                        </div>\r\n                        <small>");
                EndContext();
                BeginContext(1229, 16, false);
#line 30 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                          Write(talk.SpeakerName);

#line default
#line hidden
                EndContext();
                BeginContext(1245, 38, true);
                WriteLiteral("</small>        \r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                                                                  WriteLiteral(talk.ClientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1287, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                }

#line default
#line hidden
            BeginContext(1308, 44, true);
            WriteLiteral("                </div>\r\n            </div>\r\n");
            EndContext();
#line 35 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
        }        

#line default
#line hidden
            BeginContext(1371, 75, true);
            WriteLiteral("    </div>\r\n    <div class=\"w-25\">\r\n        <p class=\"text-muted\">Recorded ");
            EndContext();
            BeginContext(1447, 42, false);
#line 38 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                                  Write(Model.Talk.Published.ToString("MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1489, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(1494, 16, false);
#line 38 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                                                                                 Write(Model.Talk.Event);

#line default
#line hidden
            EndContext();
            BeginContext(1510, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 40 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
         if (Model.Talk.Tags.Length > 0) {

#line default
#line hidden
            BeginContext(1562, 17, true);
            WriteLiteral("            <p>\r\n");
            EndContext();
#line 42 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
             foreach (var tag in Model.Talk.Tags) {

#line default
#line hidden
            BeginContext(1632, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1648, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16eaab7b8ad3ebf569e65368a40a5091a742aee717468", async() => {
                BeginContext(1715, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1738, 3, false);
#line 44 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
               Write(tag);

#line default
#line hidden
                EndContext();
                BeginContext(1741, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tag", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                                        WriteLiteral(tag);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1763, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
            }

#line default
#line hidden
            BeginContext(1780, 18, true);
            WriteLiteral("            </p>\r\n");
            EndContext();
#line 48 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
        }

#line default
#line hidden
            BeginContext(1809, 27, true);
            WriteLiteral("\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1836, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16eaab7b8ad3ebf569e65368a40a5091a742aee720677", async() => {
                BeginContext(1918, 9, true);
                WriteLiteral("Edit Talk");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                                                            WriteLiteral(Model.Talk.ClientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1931, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(1947, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16eaab7b8ad3ebf569e65368a40a5091a742aee723114", async() => {
                BeginContext(1967, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1985, 122, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16eaab7b8ad3ebf569e65368a40a5091a742aee723516", async() => {
                    BeginContext(2092, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 54 "C:\Projects\RavenDB-DotNetCore-App\Pages\Talk.cshtml"
                                                                                         WriteLiteral(Model.Talk.ClientId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2107, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2128, 34, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TalkPage> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TalkPage> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TalkPage>)PageContext?.ViewData;
        public TalkPage Model => ViewData.Model;
    }
}
#pragma warning restore 1591
