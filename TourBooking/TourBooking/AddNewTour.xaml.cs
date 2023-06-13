using System;
using System.Windows;

namespace TourBooking
{
    public partial class AddNewTour : Window
    {
        public delegate void TourInterception(Tour tour);
        public event TourInterception AddTour;

        public AddNewTour()
        {
            InitializeComponent();
        }

        private void AddTour_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Tour tour = new(FullName.Text, PassportData.Text,
                    RouteStart.Text, RouteEnd.Text,
                    AdditionalParticipants.Text,
                    decimal.Parse(Cost.Text));

                if (FullName.Text.Length > 0 && PassportData.Text.Length > 0
                    && RouteStart.Text.Length > 0 && RouteEnd.Text.Length > 0
                    && AdditionalParticipants.Text.Length > 0
                    && Cost.Text.Length > 0)
                {

                    AddTour.Invoke(tour);
                    Close();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
