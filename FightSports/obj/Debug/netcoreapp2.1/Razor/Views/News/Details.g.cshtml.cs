#pragma checksum "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2154dc5f982d68977a7303e5d565f7907660548c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Details), @"mvc.1.0.view", @"/Views/News/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/Details.cshtml", typeof(AspNetCore.Views_News_Details))]
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
#line 1 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\_ViewImports.cshtml"
using FightSports;

#line default
#line hidden
#line 2 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\_ViewImports.cshtml"
using FightSports.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2154dc5f982d68977a7303e5d565f7907660548c", @"/Views/News/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32bfb32fa9b181d17022fed956ca4d8938b74142", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FightSports.Models.News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/admin_panel.cshtml";

#line default
#line hidden
            BeginContext(126, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(155, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2679c9e948146f0bc84dba6a998ae54", async() => {
                BeginContext(161, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(257, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(259, 2966, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97dc758e224b4105aa0dc2f4b096facd", async() => {
                BeginContext(265, 124, true);
                WriteLiteral("\r\n\r\n    <div>\r\n        <h4>News</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(390, 44, false);
#line 22 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsName));

#line default
#line hidden
                EndContext();
                BeginContext(434, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(490, 40, false);
#line 25 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.NewsName));

#line default
#line hidden
                EndContext();
                BeginContext(530, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(586, 45, false);
#line 28 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsTitle));

#line default
#line hidden
                EndContext();
                BeginContext(631, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(687, 41, false);
#line 31 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.NewsTitle));

#line default
#line hidden
                EndContext();
                BeginContext(728, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(784, 48, false);
#line 34 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsBigTitle));

#line default
#line hidden
                EndContext();
                BeginContext(832, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(888, 44, false);
#line 37 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.NewsBigTitle));

#line default
#line hidden
                EndContext();
                BeginContext(932, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(988, 43, false);
#line 40 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsTxt));

#line default
#line hidden
                EndContext();
                BeginContext(1031, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1087, 39, false);
#line 43 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.NewsTxt));

#line default
#line hidden
                EndContext();
                BeginContext(1126, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1182, 45, false);
#line 46 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsViews));

#line default
#line hidden
                EndContext();
                BeginContext(1227, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1283, 41, false);
#line 49 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.NewsViews));

#line default
#line hidden
                EndContext();
                BeginContext(1324, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1380, 49, false);
#line 52 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsAddedDate));

#line default
#line hidden
                EndContext();
                BeginContext(1429, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1485, 45, false);
#line 55 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.NewsAddedDate));

#line default
#line hidden
                EndContext();
                BeginContext(1530, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1586, 53, false);
#line 58 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.OptionalLongitude));

#line default
#line hidden
                EndContext();
                BeginContext(1639, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1695, 49, false);
#line 61 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.OptionalLongitude));

#line default
#line hidden
                EndContext();
                BeginContext(1744, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1800, 52, false);
#line 64 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.OptionalLatitude));

#line default
#line hidden
                EndContext();
                BeginContext(1852, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1908, 48, false);
#line 67 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.OptionalLatitude));

#line default
#line hidden
                EndContext();
                BeginContext(1956, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2012, 50, false);
#line 70 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.OptionalAdress));

#line default
#line hidden
                EndContext();
                BeginContext(2062, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2118, 46, false);
#line 73 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.OptionalAdress));

#line default
#line hidden
                EndContext();
                BeginContext(2164, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2220, 54, false);
#line 76 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsFirstPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2274, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2330, 50, false);
#line 79 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.NewsFirstPhotoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2380, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2436, 54, false);
#line 82 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsFirstVideoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2490, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2546, 50, false);
#line 85 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.NewsFirstVideoPath));

#line default
#line hidden
                EndContext();
                BeginContext(2596, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2652, 44, false);
#line 88 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsType));

#line default
#line hidden
                EndContext();
                BeginContext(2696, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2752, 53, false);
#line 91 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.NewsType.NewsTypeName));

#line default
#line hidden
                EndContext();
                BeginContext(2805, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2861, 49, false);
#line 94 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.SportCategory));

#line default
#line hidden
                EndContext();
                BeginContext(2910, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2966, 63, false);
#line 97 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.SportCategory.SportCategoryName));

#line default
#line hidden
                EndContext();
                BeginContext(3029, 67, true);
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(3096, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3479bcb674b14245acda3518ed9c0c04", async() => {
                    BeginContext(3146, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 102 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
                               WriteLiteral(Model.NewsId);

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
                BeginContext(3154, 12, true);
                WriteLiteral(" |\r\n        ");
                EndContext();
                BeginContext(3166, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ab25595ba974a65b1e6612a0dff34eb", async() => {
                    BeginContext(3188, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3204, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(3225, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FightSports.Models.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
