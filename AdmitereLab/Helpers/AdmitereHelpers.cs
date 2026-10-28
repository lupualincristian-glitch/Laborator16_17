using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdmitereLab.Helpers
{
    public static class AdmitereHelpers
    {
        public static IHtmlContent LinkEmail(this IHtmlHelper html, string email)
        {
            TagBuilder link = new TagBuilder("a");

            link.MergeAttribute("href", "mailto:" + email);
            link.MergeAttribute("title", "Scrie un e-mail");
            link.AddCssClass("link-secondary");
            link.InnerHtml.Append(email);

            return link;
        }
    }
}