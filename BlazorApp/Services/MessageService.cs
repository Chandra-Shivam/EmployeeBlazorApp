using System;

namespace BlazorApp.Services;

public class MessageService
{
    public string? SuccessMessage { get; private set; }

    public void SetSuccessMessage(string message)
    {
        SuccessMessage = message;
    }

    public void ClearMessage()
    {
        SuccessMessage = null;
    }

}
