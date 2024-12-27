using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFcord.Models
{
    public class NaviListItemBaseModel
    {
        public string TipText { get; set; }

        public Color HoverOrSelectColor { get; set; }

        public Color DefaultColor { get; set; }
    }
}
