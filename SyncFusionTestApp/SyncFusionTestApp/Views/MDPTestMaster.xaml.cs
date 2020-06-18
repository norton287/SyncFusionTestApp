﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SyncFusionTestApp.Views
{
     [XamlCompilation(XamlCompilationOptions.Compile)]
     public partial class MDPTestMaster : ContentPage
     {
          public ListView ListView;

          public MDPTestMaster()
          {
               InitializeComponent();

               BindingContext = new MDPTestMasterViewModel();
               ListView = MenuItemsListView;
          }

          class MDPTestMasterViewModel : INotifyPropertyChanged
          {
               public ObservableCollection<MDPTestMasterMenuItem> MenuItems { get; set; }

               public MDPTestMasterViewModel()
               {
                    MenuItems = new ObservableCollection<MDPTestMasterMenuItem>(new[]
                    {
                    new MDPTestMasterMenuItem { Id = 0, Title = "Main Page" },
                    new MDPTestMasterMenuItem { Id = 1, Title = "Page 2" },
                    new MDPTestMasterMenuItem { Id = 2, Title = "Page 3" },
                    new MDPTestMasterMenuItem { Id = 3, Title = "Page 4" },
                    new MDPTestMasterMenuItem { Id = 4, Title = "Page 5" },
                });
               }

               #region INotifyPropertyChanged Implementation
               public event PropertyChangedEventHandler PropertyChanged;
               void OnPropertyChanged([CallerMemberName] string propertyName = "")
               {
                    if (PropertyChanged == null)
                         return;

                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
               }
               #endregion
          }
     }
}