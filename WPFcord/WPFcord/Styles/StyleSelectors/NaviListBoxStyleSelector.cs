using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPFcord.Models;

namespace WPFcord.Styles.StyleSelectors
{
    public class NaviListBoxStyleSelector :StyleSelector
    {
        public Style NaviItemStyle { get; set; }
        public Style SeparatorStyle { get; set; }
        public Style ButtonStyle { get; set; }
        public override Style SelectStyle(object item, DependencyObject container)
        {
            switch (item)
            {
              
                case SeparatorItem:
                    return SeparatorStyle;
                    case ButtonItem:
                    return ButtonStyle;
                default:
                    return NaviItemStyle;
            }
        }
    }
}
