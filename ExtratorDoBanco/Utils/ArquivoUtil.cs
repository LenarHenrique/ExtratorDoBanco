using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtratorDoBanco.Utils;

public static class ArquivoUtil
{
    public static void ExportToTextFile<T>(this IEnumerable<T> data, string FileName, char ColumnSeperator)
    {
        ValidPath(FileName);
        using (var sw = File.CreateText(FileName))
        {
            var plist = typeof(T).GetProperties().Where(p => p.CanRead && (p.PropertyType.IsValueType || p.PropertyType == typeof(string)) && p.GetIndexParameters().Length == 0).ToList();
            if (plist.Count > 0)
            {
                var seperator = ColumnSeperator.ToString();
                sw.WriteLine(string.Join(seperator, plist.Select(p => p.Name)));
                foreach (var item in data)
                {
                    var values = new List<object>();
                    foreach (var p in plist) values.Add(p.GetValue(item, null));
                    sw.WriteLine(string.Join(seperator, values));
                }
            }
        }
    }
    public static void ExportToTextFile(this IEnumerable<string> data, string FileName)
    {
        ValidPath(FileName);
        using (var sw = File.CreateText(FileName))
        {
            foreach (var item in data)
                sw.WriteLine(item);
        }
    }

    static string ValidPath(string path)
    {
        var relativePath = "";
        var pastas = path.Split('\\');
        relativePath = pastas[0];
        for (int i = 0; i < pastas.Length; i++)
        {
            if (i == pastas.Length - 1)
                relativePath = $"{relativePath}\\{DateTime.Now.ToString("yyyy-MM-dd HH")}h {pastas[i]}";
            else if (i != 0)
                relativePath = $"{relativePath}\\{pastas[i]}";
            if (i == pastas.Length - 1)
            {
                if (File.Exists(relativePath))
                    File.Delete(relativePath);
            }
            else
            {
                if (!Directory.Exists(relativePath))
                    Directory.CreateDirectory(relativePath);
            }
        }
        return relativePath;
    }

}
