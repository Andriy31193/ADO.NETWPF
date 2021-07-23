namespace Caffe.Models
{
    public class UserAcessLevel : IIdentifiable
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public AcessLevel AcessLevel { get; set; }
        public static UserAcessLevel DefaultAdminAcessLevel = new UserAcessLevel()
        {
            Id = 1,
            UserId = User.DefaultAdmin.Id,
            AcessLevel = AcessLevel.Admin
        };
    }
}
