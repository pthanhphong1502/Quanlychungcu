#pragma checksum "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppSubscriptionBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28e6d44c737bf3b0f35f3fe7ee591f04f3fa0dd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_Shared_Components_AppSubscriptionBar_Default), @"mvc.1.0.view", @"/Areas/App/Views/Shared/Components/AppSubscriptionBar/Default.cshtml")]
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
#line 1 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppSubscriptionBar\Default.cshtml"
using Abp.MultiTenancy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppSubscriptionBar\Default.cshtml"
using Framework.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppSubscriptionBar\Default.cshtml"
using Framework.Editions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppSubscriptionBar\Default.cshtml"
using Framework.MultiTenancy.Payments;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28e6d44c737bf3b0f35f3fe7ee591f04f3fa0dd6", @"/Areas/App/Views/Shared/Components/AppSubscriptionBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_Shared_Components_AppSubscriptionBar_Default : Framework.Web.Views.FrameworkRazorPage<Framework.Web.Areas.App.Models.Layout.HeaderViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppSubscriptionBar\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppSubscriptionBar\Default.cshtml"
 if (AbpSession.MultiTenancySide != MultiTenancySides.Host)
{
    if (IsGranted(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement) &&
        Model.LoginInformations.Tenant.SubscriptionPaymentType != SubscriptionPaymentType.RecurringAutomatic &&
        (Model.LoginInformations.Tenant.IsInTrialPeriod || Model.LoginInformations.Tenant.SubscriptionIsExpiringSoon(Model.SubscriptionExpireNotifyDayCount)))
    {
        if (Model.LoginInformations.Tenant.IsInTrialPeriod && !Model.LoginInformations.Tenant.SubscriptionIsExpiringSoon(Model.SubscriptionExpireNotifyDayCount))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 834, "\"", 992, 1);
#nullable restore
#line 17 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppSubscriptionBar\Default.cshtml"
WriteAttributeValue("", 841, Url.Action("Buy", "Payment", new { area = "", editionId = Model.LoginInformations.Tenant.Edition.Id, editionPaymentType = EditionPaymentType.BuyNow }), 841, 151, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <span class=\"glowing\">\r\n                    <i class=\"fa fa-exclamation-triangle\"></i> ");
#nullable restore
#line 19 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppSubscriptionBar\Default.cshtml"
                                                          Write(Html.Raw(L("TrialSubscriptionNotification", "<strong>" + Model.LoginInformations.Tenant.Edition.DisplayName + "</strong>", L("ClickHere"))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </a>\r\n");
#nullable restore
#line 22 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppSubscriptionBar\Default.cshtml"
        }
        if (Model.LoginInformations.Tenant.SubscriptionIsExpiringSoon(Model.SubscriptionExpireNotifyDayCount))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 1432, "\"", 1505, 1);
#nullable restore
#line 25 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppSubscriptionBar\Default.cshtml"
WriteAttributeValue("", 1439, Url.Action("Index", "SubscriptionManagement", new {area = "App"}), 1439, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <span class=\"glowing\">\r\n                    <i class=\"fa fa-exclamation-triangle\"></i> ");
#nullable restore
#line 27 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppSubscriptionBar\Default.cshtml"
                                                          Write(L(Model.LoginInformations.Tenant.IsInTrialPeriod ?
                        "TrialExpireNotification" :
                        "SubscriptionExpireNotification",
                        Model.LoginInformations.Tenant.GetSubscriptionExpiringDayCount()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </a>\r\n");
#nullable restore
#line 33 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppSubscriptionBar\Default.cshtml"
        }
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Framework.Web.Areas.App.Models.Layout.HeaderViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
