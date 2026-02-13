using backend.Models;

namespace backend.Services;

public interface IPatientService
{
    Task<IEnumerable<Patient>> GetPatientsAsync();
}

public class PatientService: IPatientService
{
    public async Task<IEnumerable<Patient>> GetPatientsAsync()
    {
        var patients = new List<Patient>
        {
            new() { FirstName = "Arisa", LastName = "Audonkhachonkitti", PhoneNumber = "0985734408", TenantId= "Tenant_xxx" }
        };
        return await Task.FromResult(patients);
    }
}