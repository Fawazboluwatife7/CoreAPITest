namespace CoureAPI.Models
{
    public class CountryDetails
    {
        public int Id { get; set; } 
        public string Operator { get; set; }
        public string OperatorCode { get; set; }

        public int CountryCodeId { get; set; }

        public Countries countries  { get; set; }



    }
}
