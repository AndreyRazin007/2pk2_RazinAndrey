using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Input;
using Newtonsoft.Json;

namespace TourBooking
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Tour> tours = new();

        public JsonSerializerOptions serializerOptions = new()
        {
            WriteIndented = true
        };

        public MainWindow()
        {
            InitializeComponent();
            string json = File.ReadAllText(@"../../../tours.json");
            Tour[] collections = JsonConvert.DeserializeObject<Tour[]>(json);
            if (collections != null)
            {
                tours = new ObservableCollection<Tour>(collections);
            }
            MainList.ItemsSource = tours;
        }

        private void AddTour_Click(object sender, RoutedEventArgs e)
        {
            AddNewTour newTour = new();
            newTour.Show();
            newTour.AddTour += tours.Add;
        }

        private void DeleteTour_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tours.RemoveAt(MainList.SelectedIndex);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void MainList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Delete)
                {
                    tours.RemoveAt(MainList.SelectedIndex);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    try
                    {
                        string path = @"../../../tours.json";
                        File.WriteAllText(path, JsonConvert.SerializeObject(tours, Formatting.Indented));
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                    break;
                case MessageBoxResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void MainList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Tour tour = (Tour)MainList.SelectedItem;
                SaveTour save = new(tour);

                save.FullName.Text = tour.FullName;
                save.PassportData.Text = tour.PassportData;
                save.RouteStart.Text = tour.RouteStart;
                save.RouteEnd.Text = tour.RouteEnd;
                save.AdditionalParticipants.Text = tour.AdditionalTourParticipants;
                save.Cost.Text = tour.CostOfTour.ToString();

                save.Show();
            }
            catch (Exception excetion)
            {
                MessageBox.Show(excetion.Message);
            }
        }
    }
}
