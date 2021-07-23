namespace Caffe.Models
{
    public class User : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public static User DefaultAdmin = new User
        {
            Id = 1,
            Name = "Admin",
            Password = "12345"
        };
        public static User User1 = new User
        {
            Id = 2,
            Name = "Admin",
            Password = "12345"
        };
        public static User User2 = new User
        {
            Id = 3,
            Name = "Admin",
            Password = "12345"
        };
        public static User User3 = new User
        {
            Id = 4,
            Name = "Admin",
            Password = "12345"
        };
        public static User User4 = new User
        {
            Id = 5,
            Name = "Admin",
            Password = "12345"
        };
    }
}
