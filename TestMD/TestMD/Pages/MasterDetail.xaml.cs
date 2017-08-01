using System;
using TestMD.Model;
using Xamarin.Forms;

namespace TestMD.Pages
{
    public partial class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            InitializeComponent();

            masterPage.ListView.ItemSelected += OnItemSelected;
            masterPage.ListView2.ItemSelected += OnItemSelected;
            masterPage.ListView3.ItemSelected += OnItemSelected;
        }

   

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                masterPage.ListView2.SelectedItem = null;
                masterPage.ListView3.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
