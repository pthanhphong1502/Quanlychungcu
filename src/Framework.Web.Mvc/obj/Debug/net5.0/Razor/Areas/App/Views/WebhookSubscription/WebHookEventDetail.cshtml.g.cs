#pragma checksum "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c064791a7f8591b8aef317d1421daad1d5bfd84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_WebhookSubscription_WebHookEventDetail), @"mvc.1.0.view", @"/Areas/App/Views/WebhookSubscription/WebHookEventDetail.cshtml")]
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
#line 1 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
using Framework.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c064791a7f8591b8aef317d1421daad1d5bfd84", @"/Areas/App/Views/WebhookSubscription/WebHookEventDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_WebhookSubscription_WebHookEventDetail : Framework.Web.Views.FrameworkRazorPage<Abp.Webhooks.WebhookEvent>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-href", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Areas/App/Views/WebhookSubscriptions/Detail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-src", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Areas/App/Views/_Bundles/webhook-event-detail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Framework.Web.TagHelpers.FrameworkLinkHrefTagHelper __Framework_Web_TagHelpers_FrameworkLinkHrefTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Framework.Web.TagHelpers.FrameworkScriptSrcTagHelper __Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper;
        private global::Framework.Web.TagHelpers.FrameworkPageSubheaderTagHelper __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c064791a7f8591b8aef317d1421daad1d5bfd845226", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Framework_Web_TagHelpers_FrameworkLinkHrefTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkLinkHrefTagHelper>();
                __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkLinkHrefTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 6 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var webhookEventId = \"");
#nullable restore
#line 12 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                         Write(Html.Raw(Model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c064791a7f8591b8aef317d1421daad1d5bfd847681", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 14 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
  
    int maxDataLength = 300;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content d-flex flex-column flex-column-fluid\" id=\"kt_content\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-page-subheader", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c064791a7f8591b8aef317d1421daad1d5bfd849965", async() => {
            }
            );
            __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkPageSubheaderTagHelper>();
            __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                   WriteLiteral(L("WebhookEventDetail"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper.Title = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("title", __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper.Title, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 657, "\"", 718, 3);
#nullable restore
#line 22 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
WriteAttributeValue("", 665, await GetContainerClass(), 665, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 693, "d-flex", 694, 7, true);
            WriteAttributeValue(" ", 700, "flex-column-fluid", 701, 18, true);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""container"">
            <div class=""card card-custom gutter-b"" id=""portlet-detail"">
                <div class=""card-body"">
                    <div class=""form-group row"">
                        <label class=""col-2 col-form-label"">");
#nullable restore
#line 27 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                                                       Write(L("WebhookEvent"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <div class=\"col-10\">\r\n                            ");
#nullable restore
#line 29 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                       Write(Model.WebhookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-2 col-form-label\">");
#nullable restore
#line 33 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                                                       Write(L("CreationTime"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <div class=\"col-10\">\r\n                            ");
#nullable restore
#line 35 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                       Write(Model.CreationTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-2 col-form-label\">");
#nullable restore
#line 40 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                                                       Write(L("Data"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <div class=\"col-10 text-break\">\r\n");
#nullable restore
#line 42 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                             if (Model.Data.Length <= maxDataLength)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                           Write(Model.Data);

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                                           
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>\r\n                                    <span id=\"dataDots\">");
#nullable restore
#line 49 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                                                   Write(Model.Data.Substring(0, maxDataLength));

#line default
#line hidden
#nullable disable
            WriteLiteral(". . .</span>\r\n                                    <span id=\"dataMore\" class=\"d-none\">");
#nullable restore
#line 50 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                                                                  Write(Model.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </p>\r\n                                <button class=\"btn btn-outline-primary btn-sm\" id=\"dataShowMoreBtn\">");
#nullable restore
#line 52 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                                                                                               Write(L("ShowData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 53 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>

            <div class=""card card-custom gutter-b"">
                <div class=""card-header align-items-center border-0 mt-4"">
                    <h3 class=""card-title align-items-start flex-column"">
                        <span class=""font-weight-bolder text-dark"">");
#nullable restore
#line 62 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                                                              Write(L("WebhookSendAttempts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </h3>
                    <div class=""card-toolbar"">
                        <button id=""refresh-send-attempts-btn"" class=""btn btn-outline-brand btn-sm btn-icon btn-icon-md"">
                            <i class=""flaticon2-refresh""></i>
                        </button>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""align-items-center"">
                        <table id=""WebhookEventDetailSendAttemptsTable"" class=""display table table-separate table-head-custom no-footer dtr-inline dt-responsive nowrap"">
                            <thead>
                            <tr>
                                <th style=""width: 10px""></th>
                                <th style=""width: 60px;text-align: center"">");
#nullable restore
#line 76 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                                                                      Write(L("Actions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th style=\"width: 60px;text-align: center\">");
#nullable restore
#line 77 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                                                                      Write(L("WebhookSubscriptionId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th style=\"text-align: center\">");
#nullable restore
#line 78 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                                                          Write(L("WebhookEndpoint"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th style=\"width: 60px;\">");
#nullable restore
#line 79 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                                                    Write(L("CreationTime"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th style=\"width: 120px;\">");
#nullable restore
#line 80 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                                                     Write(L("HttpStatusCode"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 81 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\WebHookEventDetail.cshtml"
                               Write(L("Response"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                            </tr>
                            </thead>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""SendAttemptDetailModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"">
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abp.Webhooks.WebhookEvent> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
