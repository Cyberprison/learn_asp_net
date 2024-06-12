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

        public static HtmlString CreatePadding(this HtmlHelper html)
        {
            var result = "<div style=\"padding: 5px;\"></div>";
            return new HtmlString(result);
        }

        //public static HtmlString CreateFormForQuiz(this HtmlHelper html)
        //{
        //    //без лишних пробелов, должно быть все слитно и в строчку
        //    //как в Core не работает
        //    
        ////    < div >
        ////        {CreatePadding(html)}
        ////            <form asp-controller='Quiz' asp-action='SendAnswer' method='post'>
        ////                <p>You are hungry?</p><br/>
        ////                <input type='radio' name='answer' value='1'>52<br/>
        ////                <input type = 'radio' name = 'answer' value = '2'>давай, брат, привет<br/>
        ////                <input type = 'radio' name = 'answer' value = '3'>да<br/>
        ////                <button type='submit'>Enter</button>
        ////            </form>
        ////        {CreatePadding(html)}
        ////    </div> 
        //     

        //    var result = $"<div>{ CreatePadding(html)}<form asp-controller='Quiz' asp-action='SendAnswer' method='post'><p>You are hungry?</p><br/><input type='radio' name='answer' value='1'>52<br/><input type='radio' name='answer' value='2'>давай, брат, привет<br/><input type='radio' name='answer' value='3'>да<br/><button type='submit'>Enter</button></form>{CreatePadding(html)}</div>";

        //    return new HtmlString(result);
        //}

    }
}