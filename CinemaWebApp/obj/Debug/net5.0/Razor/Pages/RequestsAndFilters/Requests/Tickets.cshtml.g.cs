#pragma checksum "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20b491b655e6098e748b4ce1aacd41c8d79cb46b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CinemaWebApp.Pages.RequestsAndFilters.Requests.Pages_RequestsAndFilters_Requests_Tickets), @"mvc.1.0.razor-page", @"/Pages/RequestsAndFilters/Requests/Tickets.cshtml")]
namespace CinemaWebApp.Pages.RequestsAndFilters.Requests
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
#line 1 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\_ViewImports.cshtml"
using CinemaWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20b491b655e6098e748b4ce1aacd41c8d79cb46b", @"/Pages/RequestsAndFilters/Requests/Tickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9abd440a4297142c7ecb69680c6bc3b93d2d0813", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RequestsAndFilters_Requests_Tickets : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>Билеты</h1>\r\n");
            WriteLiteral("                <table class=\"table\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 10 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
                           Write(Html.DisplayNameFor(model => model.Место[0].НомерМеста));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 13 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
                           Write(Html.DisplayNameFor(model => model.Репертуар[0].КодСеанса));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 16 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
                           Write(Html.DisplayNameFor(model => model.Сотрудник[0].КодСотрудника));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
                         foreach (var item in Model.Место)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
               Write(Html.DisplayFor(modelItem => item.НомерМеста));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 29 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
                       try
                                        {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
                   Write(Model.Репертуар.First(r => r.КодСеанса == item.КодСеанса).КодСеанса);

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
                                                                                             }
                                        catch
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> Данных нет </p> ");
#nullable restore
#line 34 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
                                            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 38 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
                       try
                                        {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
                   Write(Model.Сотрудник.First(r => r.КодСотрудника == item.КодСотрудника).Фио);

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
                                                                                               }
                                        catch
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> Данных нет </p> ");
#nullable restore
#line 43 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
                                            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n            </tr>            ");
#nullable restore
#line 47 "C:\Users\komp\Desktop\Karina tereshchenko - project\CinemaWebApp\CinemaWebApp\Pages\RequestsAndFilters\Requests\Tickets.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaWebApp.Pages.RequestsAndFilters.Requests.TicketsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CinemaWebApp.Pages.RequestsAndFilters.Requests.TicketsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CinemaWebApp.Pages.RequestsAndFilters.Requests.TicketsModel>)PageContext?.ViewData;
        public CinemaWebApp.Pages.RequestsAndFilters.Requests.TicketsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
