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
                new NaviSvgItem() { HoverOrSelectColor = Colors.LightBlue, TipText = "Chats" },
                new SeparatorItem(),
                new NaviImageItem(){DefaultColor=Colors.Red},
                new NaviImageItem(){DefaultColor=Colors.Green},
                new NaviImageItem(){DefaultColor=Colors.Blue},
                new ButtonItem(){HoverOrSelectColor=Colors.ForestGreen,TipText="Add Servers"},
                new NaviSvgItem() { HoverOrSelectColor = Colors.ForestGreen, TipText = "Chats" },
                new NaviSvgItem() { HoverOrSelectColor = Colors.ForestGreen, TipText = "Chats" },

            };
        }
    }
}
