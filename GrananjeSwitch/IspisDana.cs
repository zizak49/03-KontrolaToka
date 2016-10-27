﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    public static class IspisDana
    {
        public static string ImeDana(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                //  Napisati grane case za svaki dan u tjednu tako da vraćaju "ponedjeljak" za DayOfWeek.Monday, "utorak" za DayOfWeek.Tuesday itd.
                case DayOfWeek.Monday:
                    return "ponedjeljak";
                case DayOfWeek.Tuesday:
                    return "utorak";
                case DayOfWeek.Wednesday:
                    return "srijeda";
                case DayOfWeek.Thursday:
                    return "četvrtak";
                case DayOfWeek.Friday:
                    return "petak";
                case DayOfWeek.Saturday:
                    return "subota";
                case DayOfWeek.Sunday:
                    return "nedjelja"; 
                //  Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    throw new ArgumentOutOfRangeException(nameof(danUTjednu));
            }
        }

        public static string RadniNeradni(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                //  Napisati grane case tako da za svaki radni dan u tjednu vraća "radni dan", a za subotu i nedjelju vraća "vikend"
                case DayOfWeek.Monday:
                    
                case DayOfWeek.Tuesday:
                    
                case DayOfWeek.Wednesday:
                    
                case DayOfWeek.Thursday:
                   
                case DayOfWeek.Friday:
                    return "radni dan";
                case DayOfWeek.Saturday:
                    return "vikend";
                case DayOfWeek.Sunday:
                    return "vikend";
                //  Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
