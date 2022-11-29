﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpersPrj.CustomHelpers
{
    public static class Extensionhelper
    {
        public static IHtmlString LabelWithItalics(this HtmlHelper helper, string content)
        {
            string str = String.Format("<label><i><font color=red>{0}</font></i></label>", content);
            return new HtmlString(str);
        }

        public static IHtmlString LabelinGreen(this HtmlHelper helper, string content)
        {
            string str = String.Format("<label><i><font color=green>{0}</font></i></label>", content);
            return new HtmlString(str);
        }
    }
}