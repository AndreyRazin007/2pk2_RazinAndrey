namespace TourBooking
{
    public class Tour
    {
        public string FullName { get; set; }
        public string PassportData { get; set; }
        public string RouteStart { get; set; }
        public string RouteEnd { get; set; }
        public string AdditionalTourParticipants { get; set; }
        public decimal CostOfTour { get; set; }

        public Tour()
        {

        }

        public Tour(string name, string passport, string start, string end,
            string addParticipants, decimal cost)
        {
            FullName = name;
            PassportData = passport;
            RouteStart = start;
            RouteEnd = end;
            AdditionalTourParticipants = addParticipants;
            CostOfTour = cost;
        }

        public override string ToString()
        {
            return $"ФИО участника: {FullName}\n" +
                $"Паспортные данные: {PassportData}\n" +
                $"Начало маршрута: {RouteStart}\n" +
                $"Конец маршрута: {RouteEnd}\n" +
                $"Количество дополнительных участников: " +
                $"{AdditionalTourParticipants}\n" +
                $"Стоимость тура: {CostOfTour}\n";
        }
    }
}
