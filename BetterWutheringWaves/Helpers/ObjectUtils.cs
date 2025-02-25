using System.IO;
using System.Text.Json;

namespace YYSLS.Helpers;

public class ObjectUtils
{
    public static byte[] Serialize(object obj)
    {
        return JsonSerializer.SerializeToUtf8Bytes(obj);
    }

    public static T Deserialize<T>(byte[] bytes)
    {
        return JsonSerializer.Deserialize<T>(bytes);
    }
}