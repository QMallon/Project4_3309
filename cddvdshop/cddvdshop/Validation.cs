using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*
 Quinn Mallon
 Abu Syed
 seperate validation class changed from the first version where I wrote it all in the form code
     */
namespace cddvdshop
{
    
        static class Validation
        {


            public static bool validateUPC(string upc)
            {
                Regex regex = new Regex("^(\\d){5}$");
                return regex.IsMatch(upc);
            }

            //use for title, label
            public static bool validateTitle(string title)
            {
                Regex regex = new Regex("^([\\w](\\s)?)+([\\w])$");
                return regex.IsMatch(title);
            }

            public static bool validatePrice(string price)
            {
                bool tempBool = false;
                try
                {
                    tempBool = Convert.ToDecimal(price) > 0.0m;

                }
                catch
                {
                    return false;
                }
                return tempBool;
            }
            //use for quantity, pages
            
            public static bool validateIntNumber(string num)
            {
                bool tempBool = false;
                try
                {
                    tempBool = Convert.ToInt32(num) > 0;
                }
                catch
                {
                    return false;
                }
                return tempBool;
            }

            //this will get called on left and right separately before concatenating them
            public static bool validateISBN(string isbn)
            {
                Regex regex = new Regex("^(\\d){3}$");
                return regex.IsMatch(isbn);
            }

            //use for author, lead actor, conductor
            //allows for as many names as needed and lets the last one be hyphenated
            public static bool validateName(string name)
            {
                //regex = new Regex("^([a-zA-Z]+)$|^(([a-zA-Z]+)(\\s))+([a-zA-Z]+-?[a-zA-Z]+)?[^\\W0-9]$");
                Regex regex = new Regex("^([a-zA-Z]+)$|^(([a-zA-Z]*)(\\s))+([a-zA-Z]*-?[a-zA-Z]*)?[^\\W0-9]$");
                return regex.IsMatch(name);
            }

            //between 1/1/95 and 12/31/19           
            public static bool validateReleaseDate(DateTime releaseDate)
            {
                DateTime start = new DateTime(11 / 01 / 1996);
                DateTime stop = DateTime.Now;

                return releaseDate.CompareTo(start.Date) >= 0 && releaseDate.CompareTo(stop.Date) <= 0;
                //instance is later than start date and earlier than end date
            }

            //first check that it's a valid positive int, then check logic
            public static bool validateRunTime(string runtime)
            {
                return validateIntNumber(runtime) && Convert.ToInt32(runtime) <= 240;
            }

            //just use validateName multiple times for each of the comma-separated values
            public static bool validateArtists(string artists)
            {
                bool tempBool = true;
                string[] artistArr = artists.Split(',');
                foreach (string artist in artistArr)
                {
                    tempBool = validateName(artist.Trim(' '));

                    if (tempBool == false)
                    {
                        break;
                    }
                }

                return tempBool;
            }

            //just make sure they are comma-separated values
            public static bool validateInstruments(string instruments)
            {
                Regex regex = new Regex("^[^\\W0-9][\\w+\\s,-]+[^\\W0-9]$");
                return regex.IsMatch(instruments);
            }


        }
    }


