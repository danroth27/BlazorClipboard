// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

Blazor.registerFunction('BlazorClipboard.WriteText', function (text) {
    return navigator.clipboard.writeText(text);
});
    