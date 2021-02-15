using System.Collections.Generic;

namespace DigitalWare.Core.DTOs.Paginate
{
    public class PaginateDto<T>
    {
        public IEnumerable<T> Data { get; set; }
        public int TotalCount { get; set; }
    }
}