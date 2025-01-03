﻿namespace _360AdsNG.Domain.Interfaces;

public interface IEmailService
{
    Task<bool> SendEmailAsync(string recipientEmail, string subject, string body);
}
