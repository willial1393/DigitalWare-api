namespace DigitalWare.Core.DTOs.Paginate
{
    public class PaginateQueryDto
    {
        public int Skip { get; set; }
        public int Take { get; set; }
        public bool RequireTotalCount { get; set; }
    }
}