#pragma checksum "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5de85e24e856fd3363d985f471f65e176eaee6d6"
// <auto-generated/>
#pragma warning disable 1591
namespace BWAProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/_Imports.razor"
using BWAProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/_Imports.razor"
using BWAProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/_Imports.razor"
using BWAProject.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/nobuhara")]
    public partial class Nobuhara : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-between");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
                              Prev

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "??????");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "text-center col-6");
#nullable restore
#line 10 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
__builder.AddContent(12, calendar.Year);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, " ??? ");
#nullable restore
#line 10 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
__builder.AddContent(14, calendar.Month);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, " ???\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
                              Next

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "??????");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.AddMarkupContent(23, @"<div class=""row"" style=""height: 70px;""><div class=""h-100 text-center col border"">???</div>
        <div class=""h-100 text-center col border"">???</div>
        <div class=""h-100 text-center col border"">???</div>
        <div class=""h-100 text-center col border"">???</div>
        <div class=""h-100 text-center col border"">???</div>
        <div class=""h-100 text-center col border"">???</div>
        <div class=""h-100 text-center col border"">???</div></div>");
#nullable restore
#line 25 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
     for (int i = 0; i < 6; i++)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.AddAttribute(26, "style", "height: 70px;");
#nullable restore
#line 28 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
             for (int j = 0; j < 7; j++)
            {
                var index = i == 0 ? j : i * 7 + j;
                var date = dates[index];

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "id", 
#nullable restore
#line 32 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
                          date.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "class", "h-100" + " text-center" + " col" + " justify-content-center" + " border" + " " + (
#nullable restore
#line 33 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
                                                                                 date.Class

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
                                 () => ClickDate(date)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 35 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
__builder.AddContent(31, date.DateTime.Day);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 37 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 39 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "container");
#nullable restore
#line 44 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
     foreach (var clickDate in clickDates)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col");
#nullable restore
#line 48 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
__builder.AddContent(39, $"{clickDate.Year}??? {clickDate.Month}??? {clickDate.Day}??? ?????????????????????????????????");

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "/Volumes/Data/src/visualStudio/BWAProject/BWAProject/Pages/Nobuhara.razor"
       
    /// <summary>
    /// ??????????????????????????????
    /// </summary>
    List<Date> dates = new List<Date>();

    /// <summary>
    /// ??????
    /// </summary>
    DateTime today = DateTime.Today;

    /// <summary>
    /// ????????????????????????????????????
    /// </summary>
    DateTime calendar = DateTime.Today;

    /// <summary>
    /// ????????????????????????????????????
    /// </summary>
    List<DateTime> clickDates = new List<DateTime>();

    protected override void OnInitialized()
    {
        Init();
    }

    private void Init()
    {
        // ?????????1????????????
        var first = new DateTime(calendar.Year, calendar.Month, 1);

        // ????????????????????????????????????
        var firstDateOfCalendar = new DateTime();
        switch (first.DayOfWeek)
        {
            case DayOfWeek.Sunday:
                firstDateOfCalendar = first;
                break;
            case DayOfWeek.Monday:
                firstDateOfCalendar = first.AddDays(-1);
                break;
            case DayOfWeek.Tuesday:
                firstDateOfCalendar = first.AddDays(-2);
                break;
            case DayOfWeek.Wednesday:
                firstDateOfCalendar = first.AddDays(-3);
                break;
            case DayOfWeek.Thursday:
                firstDateOfCalendar = first.AddDays(-4);
                break;
            case DayOfWeek.Friday:
                firstDateOfCalendar = first.AddDays(-5);
                break;
            case DayOfWeek.Saturday:
                firstDateOfCalendar = first.AddDays(-6);
                break;
        }

        dates.Clear();
        for (int i = 0; i < 42; i++)
        {
            var date = new Date
            {
                DateTime = firstDateOfCalendar.AddDays(i)
            };
            if (date.DateTime.Date == today.Date) { date.Class += "bg-primary"; }
            dates.Add(date);
        }
    }

    private void Prev()
    {
        calendar = calendar.AddMonths(-1);
        Init();
        StateHasChanged();
    }

    private void Next()
    {
        calendar = calendar.AddMonths(1);
        Init();
        StateHasChanged();
    }

    private void ClickDate(Date date)
    {
        clickDates.Add(date.DateTime);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
