using Microsoft.AspNetCore.Mvc;
using System.Linq;

using CoureAPI.Models;

namespace CoureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {


        [HttpGet("GetCountryByPhoneNumber")]
        public IActionResult GetCountryByPhoneNumber(string phoneNumber)
        {
            
            var phoneNumberStr = new string(phoneNumber.Where(char.IsDigit).ToArray());

            if (phoneNumberStr.Length < 3)
            {
                return BadRequest("The phone number must have at least three digits.");
            }

            
            var firstThreeDigits = int.Parse(phoneNumberStr.Substring(0, 3));

            
            var country = Data.countries
                                .FirstOrDefault(c => c.countryCode == firstThreeDigits);

            if (country != null)
            {
                // Fetch the country details (operators)
                var countryDetails = Data.getCountryDetails
                                        .Where(cd => cd.CountryCodeId == country.Id)
                                        .Select(cd => new
                                        {
                                            cd.Operator,
                                            cd.OperatorCode
                                        }).ToList();

                
                return Ok(new
                {
                    number = phoneNumberStr,
                    country = new
                    {
                        countryCode = country.countryCode.ToString(),
                        name = country.name,
                        countryIso = country.countryIso,
                        countryDetails
                    }
                });
            }
            else
            {
                return NotFound("No country found with this phone code.");
            }
        }

    }
}
