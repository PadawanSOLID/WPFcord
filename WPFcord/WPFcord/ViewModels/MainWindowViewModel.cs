using CommunityToolkit.Mvvm.ComponentModel;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows.Media;
using WPFcord.Models;

namespace WPFcord.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<NaviListItemBaseModel> naviItems;

        public MainWindowViewModel()
        {
            MockNaviItems();
        }

        void MockNaviItems()
        {
            NaviItems = new ObservableCollection<NaviListItemBaseModel>
            {
                new NaviSvgItem() {Path="Discord", HoverOrSelectColor =Color.FromArgb(0xFF,0x58,0x65,0xF2), TipText = "Direct Messages" },
                new SeparatorItem(),
                new NaviSvgItem(){Path="Robot", DefaultColor=Colors.Red},
                new NaviSvgItem(){Path="Discord",DefaultColor=Colors.Green},
                new NaviSvgItem(){DefaultColor=Colors.Blue},
                new ButtonItem(){Path="Plus",TipText="Add a Server"},
                new NaviSvgItem() {Path="ArrowDownToLine",  TipText = "Download Apps" ,},
                new NaviSvgItem() {Path="SolidCompass",  TipText = "Discover" },

            };
        }
    }
}
