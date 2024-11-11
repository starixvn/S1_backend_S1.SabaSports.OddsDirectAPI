using Microsoft.Extensions.Options;
using S1.SabaSports.OddsDirectAPI.Options;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace S1.SabaSports.OddsDirectAPI.Services;


public interface IApiClient
{
    Task<T> GetDataAsync<T>(string url, string token);

    Task<T> PostDataAsync<T>(string url, object data);
}
public class ApiClient : IApiClient
{
    private readonly HttpClient httpClient;
    private HttpMessageHandler handler;

    public ApiClient(IOptions<SabaSettings> options)
    {
        if (string.IsNullOrEmpty(options.Value.Proxy))
        {
            handler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate | DecompressionMethods.Brotli,
            };
        }
        else
        {
            var proxy = new WebProxy(options.Value.Proxy, true);
            handler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate | DecompressionMethods.Brotli,
                Proxy = proxy,
                UseProxy = true,
            };
        }
        httpClient = new HttpClient(handler);
    }
    public async Task<T> GetDataAsync<T>(string url, string token)
    {
        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        requestMessage.Headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("br"));
        requestMessage.Headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
        requestMessage.Headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("deflate"));

        var response = await httpClient.SendAsync(requestMessage).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();

        var value = JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
        return value!;
    }

    public async Task<T> PostDataAsync<T>(string url, object data)
    {
        var json = JsonSerializer.Serialize(data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await httpClient.PostAsync(url, content);
        response.EnsureSuccessStatusCode();

        var responseJson = await response.Content.ReadAsStringAsync();

        var value = JsonSerializer.Deserialize<T>(responseJson, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
        return value!;
    }
}