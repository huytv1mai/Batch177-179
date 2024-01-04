using DataAccessTestDMA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Tran_Vu_Huy_WebMVC.Models;

namespace Tran_Vu_Huy_WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient = null;
        private string DoctorApiUrl = "";
        private string SpecialtyApiUrl = "";
        public HomeController()
        {
            _httpClient = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            _httpClient.DefaultRequestHeaders.Accept.Add(contentType);
           DoctorApiUrl = "https://localhost:7096/api/Doctor";
        }
        // GET: DoctorController
        public async Task<IActionResult> Index()
        {
            HttpResponseMessage res = await _httpClient.GetAsync(DoctorApiUrl);
            string strData = await res.Content.ReadAsStringAsync();
            var option = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            List<Doctor> list = JsonSerializer.Deserialize<List<Doctor>>(strData, option);
            return View(list);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                // Check if the doctor ID is provided
                if (id == null)
                {
                    return BadRequest("Doctor ID is required.");
                }

                // Set the base address if not already set
                if (_httpClient.BaseAddress == null)
                {
                    _httpClient.BaseAddress = new Uri("https://localhost:7096/");
                }

                // Make a request to the API to get doctor details
                var response = await _httpClient.GetAsync($"api/Doctor/{id}");

                // Handle different HTTP status codes
                if (response.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    var content = await response.Content.ReadAsStringAsync();
                    var doctor = JsonSerializer.Deserialize<Doctor>(content);

                    // Check if the doctor is found
                    if (doctor != null)
                    {
                        return View(doctor);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    return NotFound();
                }
                else
                {
                    // Handle other HTTP status codes and provide error details
                    var errorContent = await response.Content.ReadAsStringAsync();
                    return StatusCode(StatusCodes.Status500InternalServerError, $"Error retrieving doctor details. API error: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP request exceptions
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error making API request: {ex.Message}");
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization exceptions
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error deserializing API response: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                return StatusCode(StatusCodes.Status500InternalServerError, $"Unexpected error: {ex.Message}");
            }
        }




        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Doctor doctor)
        {
            var json = JsonSerializer.Serialize(doctor);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Doctor", httpContent);
            response.EnsureSuccessStatusCode();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7096/");
            }
            var response = await _httpClient.GetAsync($"api/Doctor/{id}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var doctor = JsonSerializer.Deserialize<Doctor>(content);

            return View(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Doctor doctor)
        {
            var json = JsonSerializer.Serialize(doctor);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"api/Doctor/{id}", httpContent);
            response.EnsureSuccessStatusCode();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7096/");
            }
            var response = await _httpClient.GetAsync($"api/Doctor/{id}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var doctor = JsonSerializer.Deserialize<Doctor>(content);

            return View(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDeleteDoctor(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Doctor/{id}");
            response.EnsureSuccessStatusCode();
            return RedirectToAction(nameof(Index));
        }
    }
}
