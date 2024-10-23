using System;

namespace BlazorApp.Services;

public class MessageService
{
    public string? SuccessMessage { get; private set; }
    public string? ErrorMessage { get; private set; }

    public void SetSuccessMessage(string message)
    {
        SuccessMessage = message;
    }
    public void SetErrorMessage(string message)
    {
        ErrorMessage = message;
    }

    public void ClearMessage()
    {
        SuccessMessage = null;
    }

}
