using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorClipboard
{
    public class Clipboard
    {
        public static Task<object> WriteText(string text)
        {
            return RegisteredFunction.InvokeAsync<object>("BlazorClipboard.WriteText", text);
        }
    }
}
