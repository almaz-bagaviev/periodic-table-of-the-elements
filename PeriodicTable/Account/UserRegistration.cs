namespace PeriodicTable.Account;

public class UserRegistration : IUser
{
    [Required, MaxLength(20)]
    public string Login { get; set; }

    [Required, DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password), Compare(nameof(Password))]
    public string ConfirmPassword { get; set; } //Подтверждение пароля
}
