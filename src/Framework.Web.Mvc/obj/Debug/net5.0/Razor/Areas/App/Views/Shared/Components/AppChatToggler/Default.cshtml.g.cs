#pragma checksum "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppChatToggler\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb26b3fa40ab68912f0a1431c3734ae41fbdf450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_Shared_Components_AppChatToggler_Default), @"mvc.1.0.view", @"/Areas/App/Views/Shared/Components/AppChatToggler/Default.cshtml")]
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
#line 1 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppChatToggler\Default.cshtml"
using Abp.MultiTenancy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppChatToggler\Default.cshtml"
using Framework.Features;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb26b3fa40ab68912f0a1431c3734ae41fbdf450", @"/Areas/App/Views/Shared/Components/AppChatToggler/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_Shared_Components_AppChatToggler_Default : Framework.Web.Views.FrameworkRazorPage<Framework.Web.Areas.App.Models.Layout.ChatTogglerViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppChatToggler\Default.cshtml"
  
    var isChatEnabled = (AbpSession.MultiTenancySide == MultiTenancySides.Host || IsFeatureEnabled(AppFeatures.ChatFeature));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppChatToggler\Default.cshtml"
 if (isChatEnabled)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"chat_is_connecting_icon\" class=\"topbar-item\">\r\n        <button");
            BeginWriteAttribute("class", " class=\"", 352, "\"", 375, 1);
#nullable restore
#line 10 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppChatToggler\Default.cshtml"
WriteAttributeValue("", 360, Model.CssClass, 360, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 395, "\"", 444, 2);
#nullable restore
#line 11 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppChatToggler\Default.cshtml"
WriteAttributeValue("", 401, ApplicationPath, 401, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 419, "Common/Images/loading.gif", 419, 25, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 23px;\"");
            BeginWriteAttribute("tooltip", " tooltip=\"", 466, "\"", 498, 1);
#nullable restore
#line 11 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppChatToggler\Default.cshtml"
WriteAttributeValue("", 476, L("ChatIsConnecting"), 476, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placement=\"left\"/>\r\n        </button>\r\n    </div>\r\n    <div id=\"kt_quick_sidebar_toggle\" class=\"topbar-item d-none\">\r\n        <button");
            BeginWriteAttribute("class", " class=\"", 633, "\"", 656, 1);
#nullable restore
#line 15 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppChatToggler\Default.cshtml"
WriteAttributeValue("", 641, Model.CssClass, 641, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <div id=""chatIconUnRead"" class=""d-none"">
                <i class=""flaticon-chat-2 unread-notification""></i>
                <span class=""label label-warning unread-chat-message-count"">
                    {{unreadChatMessageCount}}
                </span>
            </div>
            <div id=""chatIcon"">
                <i class=""flaticon-chat-2""></i>
            </div>
        </button>
    </div>
");
#nullable restore
#line 27 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppChatToggler\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Framework.Web.Areas.App.Models.Layout.ChatTogglerViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
