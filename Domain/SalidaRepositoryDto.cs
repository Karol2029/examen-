using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaNetCore.Domain
{
    public partial class SalidaRepositoryDto
    {
        public Info? Info { get; set; }

        public Result[]? Results { get; set; }
    }

    public partial class Info
    {
        public long? Count { get; set; }

        public long? Pages { get; set; }

        public string? Next { get; set; }

        public long? Prev { get; set; }
    }

    public partial class Result
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public string? Status { get; set; }

        public string? Species { get; set; }

        public string? Type { get; set; }

        public string? Gender { get; set; }

        public LocationClass? Origin { get; set; }

        public LocationClass? Location { get; set; }

        public string? Image { get; set; }

        public string[]? Episode { get; set; }

        public string? Url { get; set; }

        public string? Created { get; set; }
    }

    public partial class LocationClass
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

}