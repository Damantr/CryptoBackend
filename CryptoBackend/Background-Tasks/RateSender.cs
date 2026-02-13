namespace BackCryptochanger.Background_Tasks;

public class RateSender : BackgroundService
{
    private readonly ILogger<RateSender> _logger;
    private protected HttpClient _httpClient;
    public RateSender(ILogger<RateSender> logger, HttpClient httpClient)
    {
        _logger = logger;
        _httpClient = httpClient;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var timer = new PeriodicTimer(TimeSpan.FromSeconds(30));
        while (await timer.WaitForNextTickAsync(stoppingToken))
        {
            await _httpClient.PostAsJsonAsync("https://localhost/api/rates", stoppingToken);
        }
    }
}