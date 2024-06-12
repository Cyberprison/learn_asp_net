using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc; //for IHtmlHelper

namespace learn_aspdotnet.Helpers
{
    //модификатор статик чтобы не создавать экземпляр класса
    public static class ListHelper
    {
        public static HtmlString CreateParagraph(this HtmlHelper html, string text)
        {
            var result = $"<h2>{text}</h2>";
            return new HtmlString(result);
        }




    }
}