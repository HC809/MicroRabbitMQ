using MicroRabbit.MVC.Models.DTOs;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;

        public TransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task Transfer(TransferDTO transferDTO)
        {
            var uri = "https://localhost:7024/api/banking";
            var response = await _apiClient.PostAsJsonAsync(uri, transferDTO);
            response.EnsureSuccessStatusCode();
        }
    }
}
