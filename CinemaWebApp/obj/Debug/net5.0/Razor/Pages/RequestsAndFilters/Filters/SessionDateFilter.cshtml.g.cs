#pragma checksum "D:\Karina_repositories\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Filters\SessionDateFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de8453c392e45b537110a0510e03172fc31110ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CinemaWebApp.Pages.RequestsAndFilters.Filters.Pages_RequestsAndFilters_Filters_SessionDateFilter), @"mvc.1.0.razor-page", @"/Pages/RequestsAndFilters/Filters/SessionDateFilter.cshtml")]
namespace CinemaWebApp.Pages.RequestsAndFilters.Filters
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
#line 1 "D:\Karina_repositories\CinemaWebApp\CinemaWebApp\Pages\_ViewImports.cshtml"
using CinemaWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de8453c392e45b537110a0510e03172fc31110ca", @"/Pages/RequestsAndFilters/Filters/SessionDateFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9abd440a4297142c7ecb69680c6bc3b93d2d0813", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RequestsAndFilters_Filters_SessionDateFilter : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>Билеты</h1>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 9 "D:\Karina_repositories\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Filters\SessionDateFilter.cshtml"
               Write(Html.DisplayNameFor(model => model.Место[0].НомерМеста));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 12 "D:\Karina_repositories\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Filters\SessionDateFilter.cshtml"
               Write(Html.DisplayNameFor(model => model.Место[0].КодСеансаNavigation.Дата));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 18 "D:\Karina_repositories\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Filters\SessionDateFilter.cshtml"
             foreach (var item in Model.Место)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 22 "D:\Karina_repositories\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Filters\SessionDateFilter.cshtml"
                   Write(Html.DisplayFor(modelItem => item.НомерМеста));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 25 "D:\Karina_repositories\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Filters\SessionDateFilter.cshtml"
                   Write(Html.DisplayFor(modelItem => item.КодСеансаNavigation.Дата));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 28 "D:\Karina_repositories\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Filters\SessionDateFilter.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaWebApp.Pages.RequestsAndFilters.Filters.SessionDateFilterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CinemaWebApp.Pages.RequestsAndFilters.Filters.SessionDateFilterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CinemaWebApp.Pages.RequestsAndFilters.Filters.SessionDateFilterModel>)PageContext?.ViewData;
        public CinemaWebApp.Pages.RequestsAndFilters.Filters.SessionDateFilterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
