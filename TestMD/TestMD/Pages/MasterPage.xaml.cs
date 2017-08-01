using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMD.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestMD.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return addnewlistView; } }
        public ListView ListView2 { get { return currenttaskslistView; } }

        public ListView ListView3 { get { return historictaskslistView; } }

        public MasterPage()
        {
            InitializeComponent();


            var addnewList = new List<MasterPageItem>();


            addnewList.Add(new MasterPageItem
            {
                Title = "Create New To Do",
                TargetType = (typeof(NewToDo))

            });
                 

            addnewlistView.ItemsSource = addnewList;


            var currenttasksList = new List<MasterPageItem>();

            currenttasksList.Add(new MasterPageItem
            {
                Title = "Today",
                TargetType = (typeof(CurrentToday))
            });
            currenttasksList.Add(new MasterPageItem
            {
                Title = "This Week",
                TargetType = (typeof(CurrentWeek))
            });
            currenttasksList.Add(new MasterPageItem
            {
                Title = "All Open",
                TargetType = (typeof(CurrentAll))
            });

            currenttaskslistView.ItemsSource = currenttasksList;


            var historictasksList = new List<MasterPageItem>();


            historictasksList.Add(new MasterPageItem
            {
                Title = "All",
                TargetType = (typeof(HistoricAll))

            });
            historictaskslistView.ItemsSource = historictasksList;
        }
    }
    }
