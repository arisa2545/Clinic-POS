namespace backend.Models;

public class Patient
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string PhoneNumber { get; set; }
    public required string TenantId { get; set; }
}