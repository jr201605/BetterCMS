﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
    using BetterCms.Module.Blog.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
    using BetterCms.Module.Blog.ViewModels.Blog;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
    using BetterCms.Module.Blog.ViewModels.Filter;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Blog/Partial/BlogsFilterTemplate.cshtml")]
    public partial class _Views_Blog_Partial_BlogsFilterTemplate_cshtml : System.Web.Mvc.WebViewPage<BlogsGridViewModel<SiteSettingBlogPostViewModel>>
    {
        public _Views_Blog_Partial_BlogsFilterTemplate_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-filter-holder\"");

WriteLiteral(" id=\"bcms-filter-template\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-grid-filtering\"");

WriteLiteral(" data-bind=\"css: { \'bcms-active-filter\': isVisible() }\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-filterbox\"");

WriteLiteral(" data-bind=\"click: toggleFilter\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 12 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
       Write(BlogGlobalization.SiteSettings_Blogs_Filter);

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"bcms-filter-modified\"");

WriteLiteral(" data-bind=\"style: { display: isEdited() ? \'inline-block\' : \'none\' }\"");

WriteLiteral(">");

            
            #line 13 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                                                                              Write(BlogGlobalization.SiteSettings_Blogs_FilterIsModified);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-filter-selection-block\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" data-bind=\"visible: isVisible()\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-filter-controls\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-clearfix\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(" data-bind=\"with: tags\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 21 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                             Write(BlogGlobalization.SiteSettings_Blogs_FilterByTags);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"bcms-field-text\"");

WriteLiteral(" data-bind=\" css: { \'bcms-input-validation-error\': newItem.hasError() }, value: n" +
"ewItem, valueUpdate: \'afterkeydown\', escPress: clearItem, autocompleteList: \'onl" +
"yExisting\'\"");

WriteLiteral(" />\r\n                        <!-- ko if: newItem.hasError()  -->\r\n               " +
"         <span");

WriteLiteral(" class=\"bcms-field-validation-error\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" data-bind=\"text: newItem.validationMessage()\"");

WriteLiteral("></span>\r\n                        </span>\r\n                        <!-- /ko -->\r\n" +
"                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(" data-bind=\"with: categories\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 33 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                             Write(BlogGlobalization.SiteSettings_Blogs_FilterByCategory);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"bcms-js-categories-select\"");

WriteLiteral("/>\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                             Write(BlogGlobalization.SiteSettings_Blogs_FilterByStatus);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 42 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                   Write(Html.DropDownListFor(m => m.Status, new List<SelectListItem>(), new { data_bind = "options: statuses, value: status, optionsText: 'Value', optionsValue: 'Key', select2: { minimumResultsForSearch: -1 }", id = "bcms-js-filter-status" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 46 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                             Write(BlogGlobalization.SiteSettings_Blogs_FilterBySEO);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 48 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                   Write(Html.DropDownListFor(m => m.SeoStatus, new List<SelectListItem>(), new { data_bind = "options: seoStatuses, value: seoStatus, optionsText: 'Value', optionsValue: 'Key', select2: { minimumResultsForSearch: -1 }", id = "bcms-js-filter-seostatus" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

            
            #line 51 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                 if (Model.Languages != null && Model.Languages.Any())
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 54 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                 Write(BlogGlobalization.SiteSettings_Blogs_FilterByLanguage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" name=\"LanguageId\"");

WriteLiteral(" data-bind=\"options: languages, value: languageId, optionsText: \'Value\', optionsV" +
"alue: \'Key\', select2: { minimumResultsForSearch: -1 }\"");

WriteLiteral(" id=\"bcms-js-filter-languages\"");

WriteLiteral("/>\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 59 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-single-tag-holder\"");

WriteLiteral(" data-bind=\"foreach: tags.items()\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-single-tag\"");

WriteLiteral(" data-bind=\"css: { \'bcms-single-tag-active\': isActive() }\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-bind=\"text: name()\"");

WriteLiteral("></span><a");

WriteLiteral(" data-bind=\"    click: remove\"");

WriteLiteral(">");

            
            #line 64 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                                                      Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </div>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: getItemInputName($index()) + \'.Key\', value: id() }\"");

WriteLiteral("/>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: getItemInputName($index()) + \'.Value\', value: name() }\"" +
"");

WriteLiteral("/>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-single-tag-holder\"");

WriteLiteral(" data-bind=\"foreach: categories.items()\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-single-tag\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-bind=\"text: $data.text\"");

WriteLiteral("></span><a");

WriteLiteral(" data-bind=\"    click: $parent.categories.remove\"");

WriteLiteral(">");

            
            #line 72 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                                                                             Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </div>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: \'Categories[\' + $index() + \'].Key\', value: $data.id }\"");

WriteLiteral("/>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: \'Categories[\' + $index() + \'].Value\', value: $data.text" +
" }\"");

WriteLiteral("/>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"bcms-clearfix\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-checkbox-block\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-checkbox-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 81 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
               Write(Html.CheckBoxFor(model => model.IncludeArchived, new { data_bind = "checked: includeArchived" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-checkbox-label bcms-pointer\"");

WriteLiteral(" data-bind=\"click: changeIncludeArchived\"");

WriteLiteral(">");

            
            #line 82 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                                                                      Write(BlogGlobalization.SiteSettings_Blogs_FilterIncludeArchived);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"bcms-btn-field-holder\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-btn-primary\"");

WriteLiteral(" data-bind=\"click: searchWithFilter\"");

WriteLiteral(">");

            
            #line 86 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                                             Write(BlogGlobalization.SiteSettings_Blogs_FilterSearch);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-btn-cancel\"");

WriteLiteral(" data-bind=\"click: clearFilter\"");

WriteLiteral(">");

            
            #line 87 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                                       Write(BlogGlobalization.SiteSettings_Blogs_FilterClear);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-sort-options\"");

WriteLiteral(" id=\"bcms-js-filter-sort\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-sort-options-label\"");

WriteLiteral(" data-bind=\"click: toggleShowSorting\"");

WriteLiteral(">");

            
            #line 93 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                                             Write(PagesGlobalization.SiteSettings_Pages_Sort);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-sort-options-block bcms-tooltip-tr\"");

WriteLiteral(" data-bind=\"visible: showSorting\"");

WriteLiteral(">\r\n            <!-- ko foreach: sortFields -->\r\n            <div");

WriteLiteral(" class=\"bcms-sort-option\"");

WriteLiteral(" data-bind=\"click: $parent.applySort.bind($data, title, column, direction)\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" data-bind=\"text: title, css: { \'bcms-sort-options-sorted\':direction == $parent.s" +
"ortDirection() && column == $parent.sortColumn() }\"");

WriteLiteral("></div>\r\n            </div>\r\n            <!-- /ko -->\r\n        </div>\r\n    </div>" +
"\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
