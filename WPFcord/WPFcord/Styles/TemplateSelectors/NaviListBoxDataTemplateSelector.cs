using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPFcord.Models;

namespace WPFcord.Styles.TemplateSelectors
{
    public class NaviListBoxDataTemplateSelector:DataTemplateSelector
    {
        public DataTemplate NaviSvgTemplate { get;  set; }
        public DataTemplate NaviImageTemplate { get;  set; }
        public DataTemplate ButtonTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            switch (item)
            {
                case NaviSvgItem:
                    return NaviSvgTemplate;
                case NaviImageItem:
                    return NaviImageTemplate;
                case ButtonItem:
                    return ButtonTemplate;
                default:
                    return null;
            }
        }
    }
}
