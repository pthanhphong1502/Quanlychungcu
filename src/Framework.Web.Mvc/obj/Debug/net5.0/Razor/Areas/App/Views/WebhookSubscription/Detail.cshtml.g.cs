#pragma checksum "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5dc64129ad0f4d60756f588b8c714ec70a0f2dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_WebhookSubscription_Detail), @"mvc.1.0.view", @"/Areas/App/Views/WebhookSubscription/Detail.cshtml")]
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
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
using Framework.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
using Framework.Web.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5dc64129ad0f4d60756f588b8c714ec70a0f2dd", @"/Areas/App/Views/WebhookSubscription/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_WebhookSubscription_Detail : Framework.Web.Views.FrameworkRazorPage<Abp.Webhooks.WebhookSubscription>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-href", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Areas/App/Views/WebhookSubscriptions/Detail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-href", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Areas/App/Views/Common/_KeyValueListManager.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-src", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Areas/App/Views/_Bundles/webhook-subscription-detail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-src", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Areas/App/Views/Common/_KeyValueListManager.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a5dc64129ad0f4d60756f588b8c714ec70a0f2dd6151", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Framework_Web_TagHelpers_FrameworkLinkHrefTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkLinkHrefTagHelper>();
                __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkLinkHrefTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 7 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a5dc64129ad0f4d60756f588b8c714ec70a0f2dd8046", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Framework_Web_TagHelpers_FrameworkLinkHrefTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkLinkHrefTagHelper>();
                __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkLinkHrefTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 8 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
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
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var subscriptionData = ");
#nullable restore
#line 15 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                          Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model, Newtonsoft.Json.Formatting.Indented)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5dc64129ad0f4d60756f588b8c714ec70a0f2dd10527", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 17 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5dc64129ad0f4d60756f588b8c714ec70a0f2dd12358", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 18 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
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
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
  
    var breadcrumbs = new List<BreadcrumbItem>()
    {
        new BreadcrumbItem(Url.Action("Index", "WebhookSubscription", new {Area = "App"}), @L("WebhookSubscriptions")),
        new BreadcrumbItem(L("WebhookSubscriptionDetail")),
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content d-flex flex-column flex-column-fluid\" id=\"kt_content\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-page-subheader", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5dc64129ad0f4d60756f588b8c714ec70a0f2dd14812", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
         if (Model.IsActive)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span class=\"label label-success label-inline\">");
#nullable restore
#line 34 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                                      Write(L("Active"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 35 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span class=\"label label-dark label-inline\">");
#nullable restore
#line 38 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                                   Write(L("Disabled"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 39 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
         if (IsGranted(AppPermissions.Pages_Administration_WebhookSubscription_Edit) ||
             IsGranted(AppPermissions.Pages_Administration_WebhookSubscription_ChangeActivity))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""dropdown dropdown-inline ml-2"">
                <a href=""#"" class=""btn btn-icon"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true"">
                    <i class=""flaticon-more-1""></i>
                </a>
                <div class=""dropdown-menu p-0 m-0 dropdown-menu-md dropdown-menu-right"" x-placement=""bottom-end"" style=""position: absolute; transform: translate3d(-211px, 39px, 0px); top: 0px; left: 0px; will-change: transform;"">
                    <!--begin::Naviigation-->
                    <ul class=""navi"">
");
#nullable restore
#line 51 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                         if (IsGranted(AppPermissions.Pages_Administration_WebhookSubscription_Edit))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"navi-item\">\r\n                                <a href=\"javascript:;\" id=\"subscription-edit-btn\" class=\"navi-link\">\r\n                                    <span class=\"navi-text\">");
#nullable restore
#line 55 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                                       Write(L("EditWebhookSubscription"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 58 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                         if (IsGranted(AppPermissions.Pages_Administration_WebhookSubscription_ChangeActivity))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"navi-item\">\r\n                                <a href=\"javascript:;\" id=\"activity-toggle-btn\" class=\"navi-link\">\r\n\r\n");
#nullable restore
#line 65 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                     if (Model.IsActive)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <span class=\"navi-text\">");
#nullable restore
#line 67 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                                           Write(L("Disable"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 68 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <span class=\"navi-text\">");
#nullable restore
#line 71 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                                           Write(L("Enable"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 72 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 75 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ul>\r\n                    <!--end::Naviigation-->\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 80 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkPageSubheaderTagHelper>();
            __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                   WriteLiteral(L("WebhookSubscriptionDetail"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper.Title = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("title", __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper.Title, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
__Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper.Breadcrumbs = breadcrumbs;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("breadcrumbs", __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper.Breadcrumbs, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 3743, "\"", 3779, 1);
#nullable restore
#line 83 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
WriteAttributeValue("", 3751, await GetContainerClass(), 3751, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"card card-custom gutter-b\" id=\"portlet-detail\">\r\n                       <div class=\"card-body\">\r\n                           <div class=\"form-group row\">\r\n                               <label class=\"col-2 col-form-label\">");
#nullable restore
#line 87 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                                              Write(L("WebhookEndpoint"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                               <div class=\"col-10 text-break\">\r\n                                   ");
#nullable restore
#line 89 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                              Write(Model.WebhookUri);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                               </div>\r\n                           </div>\r\n                           <div class=\"form-group row\">\r\n                               <label class=\"col-2 col-form-label\">");
#nullable restore
#line 93 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                                              Write(L("WebhookEvents"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                               <div class=\"col-10 text-break\">\r\n");
#nullable restore
#line 95 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                    if (Model.Webhooks != null)
                                   {
                                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                        foreach (var webhookEvent in Model.Webhooks)
                                       {
                                           

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                      Write(webhookEvent);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <br/>\r\n");
#nullable restore
#line 101 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                        
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                               </div>\r\n                           </div>\r\n       \r\n                           <div class=\"form-group row\">\r\n                               <label class=\"col-2 col-form-label\">");
#nullable restore
#line 107 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                                              Write(L("AdditionalWebhookHeaders"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                               <div class=\"col-10 text-break\">\r\n");
#nullable restore
#line 109 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                    if (Model.Headers != null)
                                   {
                                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                        foreach (var webhookHeader in Model.Headers)
                                       {
                                           

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                      Write(webhookHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <br/>\r\n");
#nullable restore
#line 115 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                        
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                               </div>\r\n                           </div>\r\n       \r\n                           <div class=\"form-group row mb-0\">\r\n                               <label class=\"col-2 col-form-label\">");
#nullable restore
#line 121 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                                              Write(L("WebhookSecret"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                               <div class=\"col-10 position-relative\">\r\n                                   <span class=\"blur\" id=\"secretSpan\">");
#nullable restore
#line 123 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                                                 Write(Model.Secret);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                   <div class=\"btn btn-sm btn-dark btn-elevate btn-elevate-air\" id=\"secret-view-btn\">");
#nullable restore
#line 124 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                                                                                                Write(L("ViewWebhookSecret"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                               </div>
                           </div>
                       </div>
                   </div>
                   <div class=""card card-custom gutter-b"">
                       <div class=""card-header align-items-center border-0 mt-4"">
                           <h3 class=""card-title align-items-start flex-column"">
                               <span class=""font-weight-bolder text-dark"">");
#nullable restore
#line 132 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
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
                               <table id=""WebHookSendAttemptTable"" class=""display table table-separate table-head-custom no-footer dtr-inline dt-responsive nowrap"">
                                   <thead>
                                   <tr>
                                       <th></th>
                                       <th style=""text-align: center;width: 60px"">");
#nullable restore
#line 147 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                                                             Write(L("Actions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                       <th>");
#nullable restore
#line 148 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                      Write(L("WebhookEvent"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                       <th>");
#nullable restore
#line 149 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                      Write(L("WebhookEventId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                       <th>");
#nullable restore
#line 150 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                      Write(L("CreationTime"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                       <th>");
#nullable restore
#line 151 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                      Write(L("HttpStatusCode"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                       <th>");
#nullable restore
#line 152 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                      Write(L("Response"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                       <th>");
#nullable restore
#line 153 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\WebhookSubscription\Detail.cshtml"
                                      Write(L("Data"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abp.Webhooks.WebhookSubscription> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
