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

        public Color HoverOrSelectColor { get; set; } = Color.FromArgb(0xFF,0x23,0xA5,0x5A);

        public Color DefaultColor { get; set; }
    }
}
