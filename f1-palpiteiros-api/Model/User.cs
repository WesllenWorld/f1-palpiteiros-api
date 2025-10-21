using UserType = F1Palpiteiros.Model.Enums.ENUM_UserType;
namespace F1Palpiteiros.Model
{
    
    public class User
    {
        //inicializar com .Empty é uma boa ideia?
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        private string Login { get; set; } = string.Empty;
        private string Password { get; set; } = string.Empty;
        public UserType Role { get; set; } = UserType.User;

        public User(string Name, string Login, string Password)
        {
            this.Name = Name;
            this.Login = Login;
            this.Password = Password;
        }
    }
}
