using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Coursework.Data
{
    public static class FileUtil
    {
        // Javascript action to download the file
        public static ValueTask<object> SaveAs(this IJSRuntime js, string filename, byte[] data)
    => js.InvokeAsync<object>(
        "saveAsFile",
        filename,
        Convert.ToBase64String(data));
    }
}