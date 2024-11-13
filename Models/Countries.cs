namespace CoureAPI.Models
{
    public class Countries
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string countryIso { get; set; }
        public int countryCode { get; set; }
        public IEnumerable<CountryDetails> countryDetails { get; set; }


    }
}
