#pragma checksum "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64951171a3149f4dcc34733876ca32b752f0c4dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent_Index), @"mvc.1.0.view", @"/Views/Consent/Index.cshtml")]
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
#line 1 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64951171a3149f4dcc34733876ca32b752f0c4dd", @"/Views/Consent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dedbedd85990a2f932371398f94ce597933b2c1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Consent_Index : Framework.Web.Views.FrameworkRazorPage<Framework.Web.Models.Consent.ConsentViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/view-resources/Views/Ui/Login.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-scopecheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
  
    ViewBag.DisableTenantChange = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64951171a3149f4dcc34733876ca32b752f0c4dd5570", async() => {
                WriteLiteral("\r\n    <title>Framework</title>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64951171a3149f4dcc34733876ca32b752f0c4dd5868", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 9 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
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
                WriteLiteral("\r\n    <style>\r\n        .consent-buttons {\r\n            margin-top: 20px;\r\n        }\r\n\r\n            .consent-buttons button {\r\n                display: inline-block;\r\n                width: 49%;\r\n            }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n<div class=\"login-form\">\r\n");
#nullable restore
#line 22 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
     if (Model.ClientLogoUrl != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"client-logo\"><img");
            BeginWriteAttribute("src", " src=\"", 583, "\"", 609, 1);
#nullable restore
#line 24 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
WriteAttributeValue("", 589, Model.ClientLogoUrl, 589, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 25 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>\r\n        <small>");
#nullable restore
#line 27 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
          Write(L("ClientIsRequestingYourPermission", Model.ClientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n    </h3>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64951171a3149f4dcc34733876ca32b752f0c4dd10158", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64951171a3149f4dcc34733876ca32b752f0c4dd10425", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 31 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 33 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
         if (Model.IdentityScopes.Any())
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"panel panel-default\">\r\n                <div class=\"panel-heading\">\r\n                    <span class=\"glyphicon glyphicon-user\"></span>\r\n                    ");
#nullable restore
#line 38 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
               Write(L("PersonalInformations"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <ul class=\"list-group\">\r\n");
#nullable restore
#line 41 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
                     foreach (var scope in Model.IdentityScopes)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
                   Write(await Html.PartialAsync("_ScopeListItem", scope));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
                                                                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 47 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
         if (Model.ApiScopes.Any())
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"panel panel-default\">\r\n                <div class=\"panel-heading\">\r\n                    <span class=\"glyphicon glyphicon-tasks\"></span>\r\n                    ");
#nullable restore
#line 54 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
               Write(L("ApplicationAccess"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <ul class=\"list-group\">\r\n");
#nullable restore
#line 57 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
                     foreach (var scope in Model.ApiScopes)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
                   Write(await Html.PartialAsync("_ScopeListItem", scope));

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
                                                                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 63 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
         if (Model.AllowRememberConsent)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"consent-remember\">\r\n                <label>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64951171a3149f4dcc34733876ca32b752f0c4dd16430", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 69 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <strong>");
#nullable restore
#line 70 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
                       Write(L("RememberMyDecision"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                </label>\r\n            </div>\r\n");
#nullable restore
#line 73 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"consent-buttons\">\r\n            <button name=\"button\" value=\"yes\" autofocus>");
#nullable restore
#line 76 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
                                                   Write(L("Allow"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n            <button name=\"button\" value=\"no\">");
#nullable restore
#line 77 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Host\Views\Consent\Index.cshtml"
                                        Write(L("DoNotAllow"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Framework.Web.Models.Consent.ConsentViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
