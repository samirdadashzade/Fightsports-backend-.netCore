#pragma checksum "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bda1af021ca7b013b43bcbbf08e58f4b5dd26e15"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bda1af021ca7b013b43bcbbf08e58f4b5dd26e15", @"/Views/News/Details.cshtml")]
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/admin_panel.cshtml";

#line default
#line hidden
            BeginContext(128, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>News</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(247, 44, false);
#line 15 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NewsName));

#line default
#line hidden
            EndContext();
            BeginContext(291, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(335, 40, false);
#line 18 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayFor(model => model.NewsName));

#line default
#line hidden
            EndContext();
            BeginContext(375, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(419, 45, false);
#line 21 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NewsTitle));

#line default
#line hidden
            EndContext();
            BeginContext(464, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(508, 41, false);
#line 24 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayFor(model => model.NewsTitle));

#line default
#line hidden
            EndContext();
            BeginContext(549, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(593, 48, false);
#line 27 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NewsBigTitle));

#line default
#line hidden
            EndContext();
            BeginContext(641, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(685, 44, false);
#line 30 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayFor(model => model.NewsBigTitle));

#line default
#line hidden
            EndContext();
            BeginContext(729, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(773, 43, false);
#line 33 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NewsTxt));

#line default
#line hidden
            EndContext();
            BeginContext(816, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(860, 39, false);
#line 36 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayFor(model => model.NewsTxt));

#line default
#line hidden
            EndContext();
            BeginContext(899, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(943, 45, false);
#line 39 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NewsViews));

#line default
#line hidden
            EndContext();
            BeginContext(988, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1032, 41, false);
#line 42 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayFor(model => model.NewsViews));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1117, 49, false);
#line 45 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NewsAddedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1210, 45, false);
#line 48 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayFor(model => model.NewsAddedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1299, 53, false);
#line 51 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OptionalLongitude));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1396, 49, false);
#line 54 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayFor(model => model.OptionalLongitude));

#line default
#line hidden
            EndContext();
            BeginContext(1445, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1489, 52, false);
#line 57 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OptionalLatitude));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1585, 48, false);
#line 60 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayFor(model => model.OptionalLatitude));

#line default
#line hidden
            EndContext();
            BeginContext(1633, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1677, 50, false);
#line 63 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OptionalAdress));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1771, 46, false);
#line 66 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayFor(model => model.OptionalAdress));

#line default
#line hidden
            EndContext();
            BeginContext(1817, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1861, 54, false);
#line 69 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NewsFirstPhotoPath));

#line default
#line hidden
            EndContext();
            BeginContext(1915, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1959, 50, false);
#line 72 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayFor(model => model.NewsFirstPhotoPath));

#line default
#line hidden
            EndContext();
            BeginContext(2009, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2053, 44, false);
#line 75 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NewsType));

#line default
#line hidden
            EndContext();
            BeginContext(2097, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2141, 53, false);
#line 78 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayFor(model => model.NewsType.NewsTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(2194, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2238, 49, false);
#line 81 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SportCategory));

#line default
#line hidden
            EndContext();
            BeginContext(2287, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2331, 63, false);
#line 84 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
       Write(Html.DisplayFor(model => model.SportCategory.SportCategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(2394, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2441, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d91bdfd9ed2649c281006479ae44bffc", async() => {
                BeginContext(2491, 4, true);
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
#line 89 "C:\Users\rustam\Desktop\FightSports-backend\FightSports\Views\News\Details.cshtml"
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
            BeginContext(2499, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2507, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f01c1d71ab94fa8b04b340250b28ade", async() => {
                BeginContext(2529, 12, true);
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
            BeginContext(2545, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
