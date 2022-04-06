using System.ComponentModel.DataAnnotations;

namespace EasyNotificationsApp.Models;

public class User
{
    public int Id { get; set; }

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    public string Password { get; set; }

}
