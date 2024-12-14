using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailReminderService
{
    public class ReminderService
    {
        private readonly EmailService _emailService;
        private readonly ILogger<ReminderService> _logger;

        public ReminderService(EmailService emailService, ILogger<ReminderService> logger)
        {
            _emailService = emailService;
            _logger = logger;
        }

        public async Task CheckAndSendRemindersAsync()
        {
            try
            {
                string query = @"
                    SELECT t.TaskID, t.Title, t.ReminderTime, u.Email
                    FROM Task t
                    INNER JOIN [User] u ON t.CreatedBy = u.UserID
                    WHERE t.IsReminderSent = 0 AND t.ReminderTime BETWEEN GETDATE() AND DATEADD(HOUR, 24, GETDATE());"; // Kiểm tra ReminderTime đã đến thời gian hiện tại

                var reminders = DatabaseAccess.GetDataTable(query);

                if (reminders.Rows.Count == 0)
                {
                    _logger.LogInformation("No reminders to send.");
                }

                foreach (DataRow row in reminders.Rows)
                {
                    int taskId = Convert.ToInt32(row["TaskID"]);
                    string title = row["Title"].ToString();
                    DateTime reminderTime = Convert.ToDateTime(row["ReminderTime"]);
                    string email = row["Email"].ToString();

                    // Gửi email
                    string emailBody = $"You have a reminder: {title} scheduled for {reminderTime}.";
                    await _emailService.SendEmailAsync(email, "Reminder Notification", emailBody);

                    // Đánh dấu đã gửi reminder
                    await MarkReminderAsSentAsync(taskId);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while checking reminders");
                throw; // Bạn có thể thêm tùy chọn xử lý thêm lỗi ở đây nếu cần.
            }
        }

        private async Task MarkReminderAsSentAsync(int taskId)
        {
            string query = "UPDATE Task SET IsReminderSent = 1 WHERE TaskID = @TaskID";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@TaskID", taskId)
            };

            await Task.Run(() => DatabaseAccess.ExecuteNonQuery(query, parameters));
        }
    }
}
