using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("patients")]
public class PatientController(IPatientService patientService) : ControllerBase
{
    private readonly IPatientService _patientService = patientService;

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _patientService.GetPatientsAsync();
        return Ok(products);
    }
}