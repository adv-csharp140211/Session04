namespace AppCodeFirst.Model;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public string NationalCode { get; set; }
    public DateTime DateOfBirth { get; set; }
}
