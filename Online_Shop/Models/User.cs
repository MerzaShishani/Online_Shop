namespace Online_Shop.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; } = string.Empty;
        //public Boolean IsAdmin { get; set; } = false;
        public string Role { get; set; }
    }
}
