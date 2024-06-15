namespace Downardo.DevKit.Core.Helpers;
public static class Base64
{
    public static async Task<String> Encode(string value)
    {
        return await Task.Run<String>(() =>
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(value);
            return System.Convert.ToBase64String(plainTextBytes);
        });
    }

    public static async Task<String> Decode(string value)
    {
        return await Task.Run<String>(() =>
        {
            var base64EncodedBytes = System.Convert.FromBase64String(value);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        });
    }
}
