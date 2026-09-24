using DotNetGuideBlogBLL.Articles;
using DotNetGuideBlogDAL.Articles;
using DotNetGuideBlogRepository.Articles;

namespace DotNetGuideBlogWebAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // 注册控制器与 Swagger。
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // 注册分层依赖，内存 DAL 使用单例共享数据。
        builder.Services.AddSingleton<IArticleDal, ArticleDal>();
        builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
        builder.Services.AddScoped<IArticleService, ArticleService>();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
