using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Data.Common
{
    public class EntityConstants
    {
        public static class Movie
        {
            public const int TitleMaxLength = 100;

            public const int GenreMaxLength = 50;

            public const int DirectorMaxLength = 100;

            public const int DescritpionMaxLength = 1000;

            public const int DurationMin = 1;

            public const int DurationMax = 300;

        }
    }
}
