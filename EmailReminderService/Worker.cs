namespace EmailReminderService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ReminderService _reminderService;

        public Worker(ILogger<Worker> logger, ReminderService reminderService)
        {
            _logger = logger;
            _reminderService = reminderService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                try
                {
                    // Kiểm tra và gửi email nhắc nhở
                    await _reminderService.CheckAndSendRemindersAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error in reminder service");
                }

                // Chờ 1 phút trước khi chạy lại
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}
