#pragma checksum "/root/c#dev/WebDev/Pages/Shared/_NavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0c37f384715ee5b0ca698be56ab23f26350f909"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreUI_Free_Bootstrap_Admin.Pages.Shared.Pages_Shared__NavBar), @"mvc.1.0.view", @"/Pages/Shared/_NavBar.cshtml")]
namespace CoreUI_Free_Bootstrap_Admin.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c37f384715ee5b0ca698be56ab23f26350f909", @"/Pages/Shared/_NavBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf74dd7436e58cac268c4de81d3755281f77ab1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__NavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header class=""app-header navbar"">
    <button class=""navbar-toggler sidebar-toggler d-lg-none mr-auto"" type=""button"" data-toggle=""sidebar-show"">
        <span class=""navbar-toggler-icon""></span>
    </button>
    <a class=""navbar-brand"" href=""/#"">
        <img class=""navbar-brand-full"" src=""/img/brand/logo.svg"" width=""89"" height=""25"" alt=""CoreUI Logo"">
        <img class=""navbar-brand-minimized"" src=""/img/brand/sygnet.svg"" width=""30"" height=""30"" alt=""CoreUI Logo"">
    </a>
    <button class=""navbar-toggler sidebar-toggler d-md-down-none"" type=""button"" data-toggle=""sidebar-lg-show"">
        <span class=""navbar-toggler-icon""></span>
    </button>
    <ul class=""nav navbar-nav d-md-down-none"">
        <li class=""nav-item px-3"">
            <a class=""nav-link"" href=""/#"">Dashboard</a>
        </li>
        <li class=""nav-item px-3"">
            <a class=""nav-link"" href=""/#"">Users</a>
        </li>
        <li class=""nav-item px-3"">
            <a class=""nav-link"" href=""/#"">Settings</a>
        </li>
    </ul>
   ");
            WriteLiteral(@" <ul class=""nav navbar-nav ml-auto"">
        <li class=""nav-item dropdown d-md-down-none"">
            <a class=""nav-link"" data-toggle=""dropdown"" href=""/#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""icon-bell""></i>
                <span class=""badge badge-pill badge-danger"">5</span>
            </a>
            <div class=""dropdown-menu dropdown-menu-right dropdown-menu-lg"">
                <div class=""dropdown-header text-center"">
                    <strong>You have 5 notifications</strong>
                </div>
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""icon-user-follow text-success""></i> New user registered
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""icon-user-unfollow text-danger""></i> User deleted
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""icon-chart text-info""></i> Sales report is ready
                </a");
            WriteLiteral(@">
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""icon-basket-loaded text-primary""></i> New client
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""icon-speedometer text-warning""></i> Server overloaded
                </a>
                <div class=""dropdown-header text-center"">
                    <strong>Server</strong>
                </div>
                <a class=""dropdown-item"" href=""/#"">
                    <div class=""text-uppercase mb-1"">
                        <small>
                            <b>CPU Usage</b>
                        </small>
                    </div>
                    <span class=""progress progress-xs"">
                        <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </span>
                    <small class=""text-muted"">348 Processes. 1/4 Cores.</small>
                </a>
");
            WriteLiteral(@"                <a class=""dropdown-item"" href=""/#"">
                    <div class=""text-uppercase mb-1"">
                        <small>
                            <b>Memory Usage</b>
                        </small>
                    </div>
                    <span class=""progress progress-xs"">
                        <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 70%"" aria-valuenow=""70"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </span>
                    <small class=""text-muted"">11444GB/16384MB</small>
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <div class=""text-uppercase mb-1"">
                        <small>
                            <b>SSD 1 Usage</b>
                        </small>
                    </div>
                    <span class=""progress progress-xs"">
                        <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 95%"" aria-valuenow=""95"" aria-valuemin=""0"" aria");
            WriteLiteral(@"-valuemax=""100""></div>
                    </span>
                    <small class=""text-muted"">243GB/256GB</small>
                </a>
            </div>
        </li>
        <li class=""nav-item dropdown d-md-down-none"">
            <a class=""nav-link"" data-toggle=""dropdown"" href=""/#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""icon-list""></i>
                <span class=""badge badge-pill badge-warning"">15</span>
            </a>
            <div class=""dropdown-menu dropdown-menu-right dropdown-menu-lg"">
                <div class=""dropdown-header text-center"">
                    <strong>You have 5 pending tasks</strong>
                </div>
                <a class=""dropdown-item"" href=""/#"">
                    <div class=""small mb-1"">
                        Upgrade NPM &amp; Bower
                        <span class=""float-right"">
                            <strong>0%</strong>
                        </span>
                    </div>
                    <sp");
            WriteLiteral(@"an class=""progress progress-xs"">
                        <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 0%"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </span>
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <div class=""small mb-1"">
                        ReactJS Version
                        <span class=""float-right"">
                            <strong>25%</strong>
                        </span>
                    </div>
                    <span class=""progress progress-xs"">
                        <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </span>
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <div class=""small mb-1"">
                        VueJS Version
                        <span class=""float-right"">
                            <strong");
            WriteLiteral(@">50%</strong>
                        </span>
                    </div>
                    <span class=""progress progress-xs"">
                        <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </span>
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <div class=""small mb-1"">
                        Add new layouts
                        <span class=""float-right"">
                            <strong>75%</strong>
                        </span>
                    </div>
                    <span class=""progress progress-xs"">
                        <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </span>
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <div class=""small mb-1"">
                        A");
            WriteLiteral(@"ngular 2 Cli Version
                        <span class=""float-right"">
                            <strong>100%</strong>
                        </span>
                    </div>
                    <span class=""progress progress-xs"">
                        <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </span>
                </a>
                <a class=""dropdown-item text-center"" href=""/#"">
                    <strong>View all tasks</strong>
                </a>
            </div>
        </li>
        <li class=""nav-item dropdown d-md-down-none"">
            <a class=""nav-link"" data-toggle=""dropdown"" href=""/#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""icon-envelope-letter""></i>
                <span class=""badge badge-pill badge-info"">7</span>
            </a>
            <div class=""dropdown-menu dropdown-menu-right dropdown-menu-lg"">
            ");
            WriteLiteral(@"    <div class=""dropdown-header text-center"">
                    <strong>You have 4 messages</strong>
                </div>
                <a class=""dropdown-item"" href=""/#"">
                    <div class=""message"">
                        <div class=""py-3 mr-3 float-left"">
                            <div class=""avatar"">
                                <img class=""img-avatar"" src=""/img/avatars/7.jpg"" alt=""admin@bootstrapmaster.com"">
                                <span class=""avatar-status badge-success""></span>
                            </div>
                        </div>
                        <div>
                            <small class=""text-muted"">John Doe</small>
                            <small class=""text-muted float-right mt-1"">Just now</small>
                        </div>
                        <div class=""text-truncate font-weight-bold"">
                            <span class=""fa fa-exclamation text-danger""></span> Important message
                        </div>
                ");
            WriteLiteral(@"        <div class=""small text-muted text-truncate"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt...</div>
                    </div>
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <div class=""message"">
                        <div class=""py-3 mr-3 float-left"">
                            <div class=""avatar"">
                                <img class=""img-avatar"" src=""/img/avatars/6.jpg"" alt=""admin@bootstrapmaster.com"">
                                <span class=""avatar-status badge-warning""></span>
                            </div>
                        </div>
                        <div>
                            <small class=""text-muted"">John Doe</small>
                            <small class=""text-muted float-right mt-1"">5 minutes ago</small>
                        </div>
                        <div class=""text-truncate font-weight-bold"">Lorem ipsum dolor sit amet</div>
                        <div class");
            WriteLiteral(@"=""small text-muted text-truncate"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt...</div>
                    </div>
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <div class=""message"">
                        <div class=""py-3 mr-3 float-left"">
                            <div class=""avatar"">
                                <img class=""img-avatar"" src=""/img/avatars/5.jpg"" alt=""admin@bootstrapmaster.com"">
                                <span class=""avatar-status badge-danger""></span>
                            </div>
                        </div>
                        <div>
                            <small class=""text-muted"">John Doe</small>
                            <small class=""text-muted float-right mt-1"">1:52 PM</small>
                        </div>
                        <div class=""text-truncate font-weight-bold"">Lorem ipsum dolor sit amet</div>
                        <div class=""small text-muted text-t");
            WriteLiteral(@"runcate"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt...</div>
                    </div>
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <div class=""message"">
                        <div class=""py-3 mr-3 float-left"">
                            <div class=""avatar"">
                                <img class=""img-avatar"" src=""/img/avatars/4.jpg"" alt=""admin@bootstrapmaster.com"">
                                <span class=""avatar-status badge-info""></span>
                            </div>
                        </div>
                        <div>
                            <small class=""text-muted"">John Doe</small>
                            <small class=""text-muted float-right mt-1"">4:03 PM</small>
                        </div>
                        <div class=""text-truncate font-weight-bold"">Lorem ipsum dolor sit amet</div>
                        <div class=""small text-muted text-truncate"">Lorem ipsum dolor ");
            WriteLiteral(@"sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt...</div>
                    </div>
                </a>
                <a class=""dropdown-item text-center"" href=""/#"">
                    <strong>View all messages</strong>
                </a>
            </div>
        </li>
        <li class=""nav-item dropdown"">
            <a class=""nav-link nav-link"" data-toggle=""dropdown"" href=""/#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                <img class=""img-avatar"" src=""/img/avatars/6.jpg"" alt=""admin@bootstrapmaster.com"">
            </a>
            <div class=""dropdown-menu dropdown-menu-right"">
                <div class=""dropdown-header text-center"">
                    <strong>Account</strong>
                </div>
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""fa fa-bell-o""></i> Updates
                    <span class=""badge badge-info"">42</span>
                </a>
                <a class=""dropdown-item"" href=""/#"">
      ");
            WriteLiteral(@"              <i class=""fa fa-envelope-o""></i> Messages
                    <span class=""badge badge-success"">42</span>
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""fa fa-tasks""></i> Tasks
                    <span class=""badge badge-danger"">42</span>
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""fa fa-comments""></i> Comments
                    <span class=""badge badge-warning"">42</span>
                </a>
                <div class=""dropdown-header text-center"">
                    <strong>Settings</strong>
                </div>
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""fa fa-user""></i> Profile
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""fa fa-wrench""></i> Settings
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""fa fa-usd""></i> Payments
   ");
            WriteLiteral(@"                 <span class=""badge badge-dark"">42</span>
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""fa fa-file""></i> Projects
                    <span class=""badge badge-primary"">42</span>
                </a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""fa fa-shield""></i> Lock Account
                </a>
                <a class=""dropdown-item"" href=""/#"">
                    <i class=""fa fa-lock""></i> Logout
                </a>
            </div>
        </li>
    </ul>
    <button class=""navbar-toggler aside-menu-toggler d-md-down-none"" type=""button"" data-toggle=""aside-menu-lg-show"">
        <span class=""navbar-toggler-icon""></span>
    </button>
    <button class=""navbar-toggler aside-menu-toggler d-lg-none"" type=""button"" data-toggle=""aside-menu-show"">
        <span class=""navbar-toggler-icon""></span>
    </button>
</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
