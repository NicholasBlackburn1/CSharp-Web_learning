#pragma checksum "/root/c#dev/WebDev/Pages/Base/collapse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "772ae9b484f96d3569ff5e4f5dfc5887e49b24ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreUI_Free_Bootstrap_Admin.Pages.Base.Pages_Base_collapse), @"mvc.1.0.razor-page", @"/Pages/Base/collapse.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"772ae9b484f96d3569ff5e4f5dfc5887e49b24ce", @"/Pages/Base/collapse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf74dd7436e58cac268c4de81d3755281f77ab1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Base_collapse : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/root/c#dev/WebDev/Pages/Base/collapse.cshtml"
  
    ViewData["Title"] = "Collapse";

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
                        <i class=""fa fa-align-justify""></i> Collapse
                        <div class=""card-header-actions"">
                            <a class=""card-header-action"" href=""http://coreui.io/docs/components/bootstrap-collapse/"" target=""_blank"">
                                <small class=""text-muted"">docs</small>
                            </a>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <p>
                            <a class=""btn btn-primary"" data-toggle=""collapse"" href=""#collapseExample"" aria-expanded=""false"" aria-controls=""collapseExample"">Link with href</a>
                            <button class=""btn btn-primary"" type=""button"" data-toggle=""collapse"" data-target=""#collapseExample"" aria-exp");
            WriteLiteral(@"anded=""false"" aria-controls=""collapseExample"">Button with data-target</button>
                        </p>
                        <div class=""collapse"" id=""collapseExample"">
                            <div class=""card card-body"">Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident.</div>
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"">
                        <i class=""fa fa-align-justify""></i> Collapse
                        <small>multiple targets</small>
                    </div>
                    <div class=""card-body"">
                        <p>
                            <a class=""btn btn-primary"" data-toggle=""collapse"" href=""#multiCollapseExample1"" aria-expanded=""false"" aria-controls=""multiCollapseExample1"">Toggle first element</a>
             ");
            WriteLiteral(@"               <button class=""btn btn-primary"" type=""button"" data-toggle=""collapse"" data-target=""#multiCollapseExample2"" aria-expanded=""false"" aria-controls=""multiCollapseExample1"">Toggle second element</button>
                            <button class=""btn btn-primary"" type=""button"" data-toggle=""collapse"" data-target="".multi-collapse"" aria-expanded=""false"" aria-controls=""multiCollapseExample1 multiCollapseExample2"">Toggle both elements</button>
                        </p>
                        <div class=""row"">
                            <div class=""col-sm-12 col-md-6"">
                                <div class=""collapse multi-collapse"" id=""multiCollapseExample1"">
                                    <div class=""card card-body"">Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident.</div>
                                </div>
                            </div>
      ");
            WriteLiteral(@"                      <div class=""col-sm-12 col-md-6"">
                                <div class=""collapse multi-collapse"" id=""multiCollapseExample2"">
                                    <div class=""card card-body"">Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident.</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-12 col-xl-6"">
                <div class=""card"">
                    <div class=""card-header"">
                        <i class=""fa fa-align-justify""></i> Collapse
                        <small>accordion</small>
                    </div>
                    <div class=""card-body"">
                        <div id=""accordion"" role=""tablist"">
                            <div class=""card"">
            ");
            WriteLiteral(@"                    <div class=""card-header"" id=""headingOne"" role=""tab"">
                                    <h5 class=""mb-0"">
                                        <a data-toggle=""collapse"" href=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">Collapsible Group Item #1</a>
                                    </h5>
                                </div>
                                <div class=""collapse show"" id=""collapseOne"" role=""tabpanel"" aria-labelledby=""headingOne"" data-parent=""#accordion"">
                                    <div class=""card-body"">
                                        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor,
                                        sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer lab");
            WriteLiteral(@"ore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo.
                                        Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-header"" id=""headingTwo"" role=""tab"">
                                    <h5 class=""mb-0"">
                                        <a class=""collapsed"" data-toggle=""collapse"" href=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">Collapsible Group Item #2</a>
                                    </h5>
                                </div>
                                <div class=""collapse"" id=""collapseTwo"" role=""tabpanel"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
                                   ");
            WriteLiteral(@" <div class=""card-body"">
                                        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor,
                                        sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo.
                                        Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-header"" id=""headingThree"" role=""tab"">
                         ");
            WriteLiteral(@"           <h5 class=""mb-0"">
                                        <a class=""collapsed"" data-toggle=""collapse"" href=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">Collapsible Group Item #3</a>
                                    </h5>
                                </div>
                                <div class=""collapse"" id=""collapseThree"" role=""tabpanel"" aria-labelledby=""headingThree"" data-parent=""#accordion"">
                                    <div class=""card-body"">
                                        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor,
                                        sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butc");
            WriteLiteral(@"her vice lomo.
                                        Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"">
                        <i class=""fa fa-align-justify""></i> Collapse
                        <small>custom accordion</small>
                    </div>
                    <div class=""card-body"">
                        <div id=""exampleAccordion"" data-children="".item"">
                            <div class=""item"">
                                <a data-toggle=""collapse"" data-parent=""#exampleAccordion"" href=""#exampleAccordion1"" aria-expanded=""true"" aria-controls=""exampleAccordion1"">Toggle item</a>
                                <div c");
            WriteLiteral(@"lass=""collapse show"" id=""exampleAccordion1"" role=""tabpanel"">
                                    <p class=""mb-3"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed pretium lorem non vestibulum scelerisque. Proin a vestibulum sem, eget tristique massa. Aliquam lacinia rhoncus nibh quis ornare.</p>
                                </div>
                            </div>
                            <div class=""item"">
                                <a data-toggle=""collapse"" data-parent=""#exampleAccordion"" href=""#exampleAccordion2"" aria-expanded=""false"" aria-controls=""exampleAccordion2"">Toggle item 2</a>
                                <div class=""collapse"" id=""exampleAccordion2"" role=""tabpanel"">
                                    <p class=""mb-3"">
                                        Donec at ipsum dignissim, rutrum turpis scelerisque, tristique lectus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vivamus nec dui turpis. Orci varius natoque penatibus");
            WriteLiteral(@" et magnis
                                        dis parturient montes, nascetur ridiculus mus.
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Base_collapse> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Base_collapse> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Base_collapse>)PageContext?.ViewData;
        public Pages_Base_collapse Model => ViewData.Model;
    }
}
#pragma warning restore 1591
