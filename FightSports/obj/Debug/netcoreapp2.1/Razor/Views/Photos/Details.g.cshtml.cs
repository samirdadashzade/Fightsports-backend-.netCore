#pragma checksum "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f99ebc5f7003d975760c69cbab03ace0db5754a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photos_Details), @"mvc.1.0.view", @"/Views/Photos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Photos/Details.cshtml", typeof(AspNetCore.Views_Photos_Details))]
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
#line 1 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\_ViewImports.cshtml"
using FightSports;

#line default
#line hidden
#line 2 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\_ViewImports.cshtml"
using FightSports.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f99ebc5f7003d975760c69cbab03ace0db5754a", @"/Views/Photos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32bfb32fa9b181d17022fed956ca4d8938b74142", @"/Views/_ViewImports.cshtml")]
    public class Views_Photos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FightSports.Models.Photos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/admin_panel.cshtml";

#line default
#line hidden
            BeginContext(130, 104, true);
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <h4>Photos</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(235, 45, false);
#line 15 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoName));

#line default
#line hidden
            EndContext();
            BeginContext(280, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(324, 41, false);
#line 18 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoName));

#line default
#line hidden
            EndContext();
            BeginContext(365, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(409, 45, false);
#line 21 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoPath));

#line default
#line hidden
            EndContext();
            BeginContext(454, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(498, 41, false);
#line 24 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoPath));

#line default
#line hidden
            EndContext();
            BeginContext(539, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(583, 46, false);
#line 27 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoTitle));

#line default
#line hidden
            EndContext();
            BeginContext(629, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(673, 42, false);
#line 30 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoTitle));

#line default
#line hidden
            EndContext();
            BeginContext(715, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(759, 46, false);
#line 33 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoViews));

#line default
#line hidden
            EndContext();
            BeginContext(805, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(849, 42, false);
#line 36 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoViews));

#line default
#line hidden
            EndContext();
            BeginContext(891, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(935, 50, false);
#line 39 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoAddedData));

#line default
#line hidden
            EndContext();
            BeginContext(985, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1029, 46, false);
#line 42 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoAddedData));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1119, 40, false);
#line 45 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.News));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1203, 55, false);
#line 48 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.News.NewsFirstPhotoPath));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1305, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a225d82bd9f64ede8c110c6b807a2731", async() => {
                BeginContext(1377, 4, true);
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
#line 53 "C:\Users\rustam\Desktop\projects\FightSports-backend\FightSports\Views\Photos\Details.cshtml"
                           WriteLiteral(Model.PhotoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1385, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1393, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a094f042874a41f0bcb0a7f84f9ff26a", async() => {
                BeginContext(1436, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1452, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FightSports.Models.Photos> Html { get; private set; }
    }
}
#pragma warning restore 1591
