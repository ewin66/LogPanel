using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using LogDashboard.Route;
using Microsoft.AspNetCore.Http;

namespace LogDashboard.EmbeddedFiles
{
    public class LogDashboardEmbeddedFiles
    {
        static Dictionary<string, string> ResponseType = new Dictionary<string, string>
        {
            { ".css","text/css"},
            { ".js","application/javascript"}
        };

        public static string IncludeEmbeddedFile(HttpContext context, string path)
        {
            context.Response.OnStarting(() =>
            {
                if (context.Response.StatusCode == (int)HttpStatusCode.OK)
                {
                    context.Response.ContentType = ResponseType[Path.GetExtension(path)];
                }

                return Task.CompletedTask;
            });

            // 获取当前类库的程序集
            Assembly assembly = Assembly.GetExecutingAssembly();

            // 从程序集中读取插件的菜单和工具栏配置信息(xml文件内容)
            Stream stream0 = assembly.GetManifestResourceStream($"{LogDashboardConsts.Root}.{path.Substring(1)}");
            var reader0 = new StreamReader(stream0);
            var result0 = reader0.ReadToEnd();
            return result0;

            //var stream = Assembly.GetAssembly(typeof(LogDashboardRoute)).GetManifestResourceStream($"{LogDashboardConsts.Root}.{path.Substring(1)}");
            //var reader = new StreamReader(stream);
            //var result= reader.ReadToEnd();
            //return result;
        }

    }
}
