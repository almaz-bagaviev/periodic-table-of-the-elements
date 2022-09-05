namespace PeriodicTable.Account;

public class UserLogin : IUser
{
    [Required, MaxLength(20)] //using System.ComponentModel.DataAnnotations;
    public string Login { get; set; }

    [Required, DataType(DataType.Password)]
    public string Password { get; set; }
    public string ReturnUrl { get; set; } //хранит информацию о том, куда нужно вернуться после авторизации
}
