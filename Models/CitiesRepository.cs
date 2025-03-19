namespace ServerManagment.Models
{
    public static class CitiesRepository
    {
        public static List<string> GetCities()
        {
            return new List<string>
            {
                "Toronto" ,
                "Montreal" ,
                "Ottawa",
                "Calgary",
                "Halifax"
            };
        }
    }
}