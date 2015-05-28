/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:WPFNinjaV2.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace WPFNinjaV2.ViewModel
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<EquipmentItemListViewModel>();
            SimpleIoc.Default.Register<SongListViewModel>();
            SimpleIoc.Default.Register<WindowsViewModel>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This non-static member is needed for data binding purposes.")]
        public SongListViewModel Song
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SongListViewModel>();
            }
        }
        public EquipmentItemListViewModel EquipmentItem
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EquipmentItemListViewModel>();
            }
        }

        public WindowsViewModel Manager
        {
            get
            {
                return ServiceLocator.Current.GetInstance<WindowsViewModel>();
            }
        }

        public static void Cleanup()
        {
        }
    }
}