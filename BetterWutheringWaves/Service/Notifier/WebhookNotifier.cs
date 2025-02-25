using System.Net.Http;
using System.Threading.Tasks;
using YYSLS.Service.Notifier.Interface;
using YYSLS.Service.Notifier.Exception;

namespace YYSLS.Service.Notifier;

public class WebhookNotifier : INotifier
{
    public string Name { get; set; } = "Webhook";

    public string Endpoint { get; set; }

    private readonly HttpClient _httpClient;

    public WebhookNotifier(HttpClient httpClient, string endpoint = "")
    {
        _httpClient = httpClient;
        Endpoint = endpoint;
    }

    public async Task SendNotificationAsync(HttpContent content)
    {
        try
        {
            var response = await _httpClient.PostAsync(Endpoint, content);

            if (!response.IsSuccessStatusCode)
            {
                throw new NotifierException($"Webhook call failed with code: {response.StatusCode}");
            }
        }
        catch (NotifierException)
        {
            throw;
        }
        catch (System.Exception ex)
        {
            throw new NotifierException($"Error sending webhook: {ex.Message}");
        }
    }
}
