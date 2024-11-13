using CoureAPI.Models;
using Microsoft.EntityFrameworkCore;

public class Data
{

    public static List<Countries> countries = new List<Countries>
    {
           new Countries { Id = 1, name = "Nigeria", countryCode = 234, countryIso = "NG" },
            new Countries { Id = 2, name = "Ghana", countryCode = 233, countryIso = "GH" },
            new Countries { Id = 3, name = "Benin Republic", countryCode = 229, countryIso = "BN" },
            new Countries { Id = 4, name = "Cote d'Ivoire", countryCode = 225, countryIso = "CIV" }

    };

    public static List<CountryDetails> getCountryDetails = new List<CountryDetails>
    {


            new CountryDetails { Id = 1, Operator = "MTN Nigeria", OperatorCode = "MTN NG", CountryCodeId = 1 },
            new CountryDetails { Id = 2, Operator = "Airtel Nigeria", OperatorCode = "ANG", CountryCodeId = 1 },
            new CountryDetails { Id = 3, Operator = "9Mobile Nigeria", OperatorCode = "ETN", CountryCodeId = 1 },
            new CountryDetails { Id = 4, Operator = "Globacom Nigeria", OperatorCode = "GLO NG", CountryCodeId = 1 },
            new CountryDetails { Id = 5, Operator = "Vodafone Ghana", OperatorCode = "Vodafone GH", CountryCodeId = 2 },
            new CountryDetails { Id = 6, Operator = "MTN Ghana", OperatorCode = "MTN Ghana", CountryCodeId = 2 },
            new CountryDetails { Id = 7, Operator = "Tigo Ghana", OperatorCode = "Tigo Ghana", CountryCodeId = 2 },
            new CountryDetails { Id = 8, Operator = "MTN Benin", OperatorCode = "MTN Benin", CountryCodeId = 3 },
            new CountryDetails { Id = 9, Operator = "Moov Benin", OperatorCode = "Moov Benin", CountryCodeId = 3 },
            new CountryDetails { Id = 10, Operator = "MTN Côte d'Ivoire", OperatorCode = "MTN CIV", CountryCodeId = 4 }

    };
}
