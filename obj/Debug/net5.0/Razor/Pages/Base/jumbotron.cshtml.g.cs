#pragma checksum "/root/c#dev/WebDev/Pages/Base/jumbotron.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a62571350b4eeafdadb210f9949c4cf12ea24ac0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreUI_Free_Bootstrap_Admin.Pages.Base.Pages_Base_jumbotron), @"mvc.1.0.razor-page", @"/Pages/Base/jumbotron.cshtml")]
namespace CoreUI_Free_Bootstrap_Admin.Pages.Base
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
#line 1 "/root/c#dev/WebDev/Pages/_ViewImports.cshtml"
using CoreUI_Free_Bootstrap_Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62571350b4eeafdadb210f9949c4cf12ea24ac0", @"/Pages/Base/jumbotron.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf74dd7436e58cac268c4de81d3755281f77ab1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Base_jumbotron : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/root/c#dev/WebDev/Pages/Base/jumbotron.cshtml"
  
    ViewData["Title"] = "Jumbotron";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""animated fadeIn"">
        <div class=""row"">
            <div class=""col-sm-12 col-xl-6"">
                <div class=""card"">
                    <div class=""card-header"">
                        <i class=""fa fa-align-justify""></i> Jumbotron
                        <div class=""card-header-actions"">
                            <a class=""card-header-action"" href=""http://coreui.io/docs/components/bootstrap-jumbotron/"" target=""_blank"">
                                <small class=""text-muted"">docs</small>
                            </a>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""jumbotron"">
                            <h1 class=""display-3"">Hello, world!</h1>
                            <p class=""lead"">This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
                            <hr class=""my-4"">");
            WriteLiteral(@"
                            <p>It uses utility classes for typography and spacing to space content out within the larger container.</p>
                            <p class=""lead"">
                                <a class=""btn btn-primary btn-lg"" href=""#"" role=""button"">Learn more</a>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-12 col-xl-6"">
                <div class=""card"">
                    <div class=""card-header"">
                        <i class=""fa fa-align-justify""></i> Jumbotron
                        <small>fluid</small>
                    </div>
                    <div class=""card-body"">
                        <div class=""jumbotron jumbotron-fluid"">
                            <div class=""container"">
                                <h1 class=""display-3"">Fluid jumbotron</h1>
                                <p class=""lead"">This is a modified jumbotron that occupies the entire ");
            WriteLiteral("horizontal space of its parent.</p>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Base_jumbotron> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Base_jumbotron> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Base_jumbotron>)PageContext?.ViewData;
        public Pages_Base_jumbotron Model => ViewData.Model;
    }
}
#pragma warning restore 1591
