using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

public static class MyEditor
{
    public static MvcHtmlString MyEditorFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, object additionalViewData)
    {
        var input = html.TextBoxFor(expression);

        var inputHtml = input.ToHtmlString().Replace("<","").Replace("/>","");

        inputHtml = "<" + inputHtml + " class=\"form-control text-box single-line\" ";

        inputHtml = inputHtml + " maxlength=\""+inputHtml.Substring(inputHtml.IndexOf("data-val-length-max=")+21,2) + "\" />";
        

        return new MvcHtmlString(inputHtml);
    }
}