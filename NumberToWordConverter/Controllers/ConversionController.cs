using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NumberToWordConverter.Services;
using NumberToWordConverter.Models;

namespace NumberToWordConverter.Controllers
{
    public class ConversionController : ApiController
    {
        /***** Single API method to return any given currency value converted into *****/
        /***** Words, as well as the name passed the as parameter to this method. *****/
        /***** The returned object is received in JSON format to the caller *****/

        public NameAndMoney Get(string name, double number)
        {
            return new NameAndMoney { Name = name, Words = MoneyToWords.Convert((number)) };
        }
    }
}