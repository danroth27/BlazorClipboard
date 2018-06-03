using System;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorClipboard
{
    public class ExampleJsInterop
    {
        public static string Prompt(string message)
        {
            return RegisteredFunction.Invoke<string>(
                "BlazorClipboard.ExampleJsInterop.Prompt",
                message);
        }
    }
}
