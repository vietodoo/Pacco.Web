namespace Pacco.Web.DTO
{
    public class JwtDto
    {
        public string AccessToken { get; set; }
        public string Role { get; set; }
        public long Expires { get; set; }
    }
}