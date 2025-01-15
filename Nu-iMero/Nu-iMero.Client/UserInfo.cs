namespace Nu_iMero.Client
{
    public class UserInfo
    {
        public required string UserId { get; set; }
        public required string Email { get; set; }
        public string Name { get; set; }  // Optional: Add a Name property for more user details
    }
}
