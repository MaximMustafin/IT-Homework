using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace BasicsOfAspDotNetCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        // {
        //     if (env.IsDevelopment())
        //     {
        //         app.UseDeveloperExceptionPage();
        //     }

        //     app.UseRouting();

        //     app.UseEndpoints(endpoints =>
        //     {
        //         endpoints.MapGet("/", async context =>
        //         {
        //             await context.Response.WriteAsync("Hello World!");
        //         });
        //     });
        // }


        // Конвейер обработки запроса и middleware
        // public void Configure(IApplicationBuilder app)
        // {
        //     int x = 2;
        //     app.Run(async (context) =>
        //     {
        //         x = x * 2;  //  2 * 2 = 4
        //         await context.Response.WriteAsync($"Result: {x}");
        //     });
        // }



        //Методы Use, Run и делегат RequestDelegate
        //Метод app.Run
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync("Hello World!");
        //     });
        // }

        // public void Configure(IApplicationBuilder app)
        // {
        //     int x = 5;
        //     int y = 8;
        //     int z = 0;
        //     app.Use(async (context, next) =>
        //     {
        //         z = x * y;
        //         await next.Invoke();
        //     });

        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync($"x * y = {z}");
        //     });
        // }

        //Следующая обработка запроса не рекомендуется:
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.Use(async (context, next) =>
        //     {
        //         await context.Response.WriteAsync("<p>Hello world!</p>");
        //         await next.Invoke();
        //     });

        //     app.Run(async (context) =>
        //     {
        // // await Task.Delay(10000); можно поставить задержку
        // await context.Response.WriteAsync("<p>Good bye, World...</p>");
        //     });
        // }

        //Выполнение app.Use
        // public void Configure(IApplicationBuilder app)
        // {
        //     int x = 2;
        //     app.Use(async (context, next) =>
        //     {
        //         x = x * 2;      // 2 * 2 = 4
        // await next.Invoke();    // вызов app.Run
        // x = x * 2;      // 8 * 2 = 16
        // await context.Response.WriteAsync($"Result: {x}");
        //     });

        //     app.Run(async (context) =>
        //     {
        //         x = x * 2;  //  4 * 2 = 8
        // await Task.FromResult(0);
        //     });
        // }



        //Методы Map и MapWhen
        //Метод Map
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.Map("/index", Index);
        //     app.Map("/about", About);

        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync("Page Not Found");
        //     });
        // }

        // private static void Index(IApplicationBuilder app)
        // {
        //     app.Run(async context =>
        //     {
        //         await context.Response.WriteAsync("Index");
        //     });
        // }
        // private static void About(IApplicationBuilder app)
        // {
        //     app.Run(async context =>
        //     {
        //         await context.Response.WriteAsync("About");
        //     });
        // }

        //Вложенные методы Map
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.Map("/home", home =>
        //     {
        //         home.Map("/index", Index);
        //         home.Map("/about", About);
        //     });

        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync("Page Not Found");
        //     });
        // }

        // private static void Index(IApplicationBuilder app)
        // {
        //     app.Run(async context =>
        //     {
        //         await context.Response.WriteAsync("Index");
        //     });
        // }
        // private static void About(IApplicationBuilder app)
        // {
        //     app.Run(async context =>
        //     {
        //         await context.Response.WriteAsync("About");
        //     });
        // }

        //Метод MapWhen
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.MapWhen(context =>
        //     {

        //         return context.Request.Query.ContainsKey("id") &&
        //                 context.Request.Query["id"] == "5";
        //     }, HandleId);

        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync("Good bye, World...");
        //     });
        // }

        // private static void HandleId(IApplicationBuilder app)
        // {
        //     app.Run(async context =>
        //     {
        //         await context.Response.WriteAsync("id is equal to 5");
        //     });
        // }



        //Создание компонентов middleware
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.UseMiddleware<TokenMiddleware>();

        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync("Hello World");
        //     });
        // }

        /// <summary>
        /// Передача параметров
        /// </summary>
        /// <param name="app"></param>
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.UseToken("123");

        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync("Hello World");
        //     });
        // }



        //Конвейер обработки запроса
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.UseMiddleware<ErrorHandlingMiddleware>();
        //     app.UseMiddleware<AuthenticationMiddleware>();
        //     app.UseMiddleware<RoutingMiddleware>();
        // }  



        //Статические файлы
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.UseStaticFiles();   // добавляем поддержку статических файлов

        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync("Hello World");
        //     });
        // }  



        //Работа со статическими файлами
        //В этом случае при отправке запроса к корню веб-приложения типа http://localhost:xxxx/
        //приложение будет искать в папке wwwroot следующие файлы:
        //default.htm
        //default.html
        //index.htm
        //index.html
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.UseDefaultFiles();
        //     app.UseStaticFiles();

        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync("Hello World");
        //     });
        // }

        //Если же мы хотим использовать файл, название которого отличается от вышеперечисленных,
        //то нам надо в этом случае применить объект DefaultFilesOptions:
        // public void Configure(IApplicationBuilder app)
        // {
        //     DefaultFilesOptions options = new DefaultFilesOptions();
        //     options.DefaultFileNames.Clear(); // удаляем имена файлов по умолчанию
        //     options.DefaultFileNames.Add("hello.html"); // добавляем новое имя файла
        //     app.UseDefaultFiles(options); // установка параметров

        //     app.UseStaticFiles();

        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync("Hello World");
        //     });
        // }

        //Метод UseDirectoryBrowser
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.UseDirectoryBrowser();
        //     app.UseStaticFiles();
        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync("Hello World");
        //     });
        // }

        //Данный метод имеет перегрузку, которая позволяет сопоставить определенный каталог
        //на жестком диске или в проекте с некоторой строкой запроса и тем самым потом отобразить
        //содержимое этого каталога:
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.UseDirectoryBrowser(new DirectoryBrowserOptions()
        //     {
        //         FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\html")),

        //         RequestPath = new PathString("/pages")
        //     });
        //     app.UseStaticFiles();
        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync("Hello World");
        //     });
        // }

        //Сопоставление каталогов с путями
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.UseStaticFiles(); // обрабатывает все запросы к wwwroot
        //     app.UseStaticFiles(new StaticFileOptions() // обрабатывает запросы к каталогу wwwroot/html
        //     {
        //         FileProvider = new PhysicalFileProvider(
        //             Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\html")),
        //         RequestPath = new PathString("/pages")
        //     });

        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync("Hello World");
        //     });
        // }

        //Метод UseFileServer
        // public void Configure(IApplicationBuilder app)
        // {
        //     // app.UseFileServer();

        //     //Если нам надо еще включить просмотр каталогов,
        //     //то мы можем использовать перегрузку данного метода:
        //     //app.UseFileServer(enableDirectoryBrowsing: true);

        //     //Еще одна перегрузка метода позволяет более точно задать параметры:
        //     app.UseFileServer(new FileServerOptions
        //     {
        //         EnableDirectoryBrowsing = true,
        //         FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\html")),
        //         RequestPath = new PathString("/pages"),
        //         EnableDefaultFiles = false
        //     });

        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync("Hello World");
        //     });
        // }



        //Обработка ошибок
        //Если приложение находится в состоянии разработки,
        //то с помощью middleware app.UseDeveloperExceptionPage() приложение перехватывает
        //исключения и выводит информацию о них разработчику.
        // public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        // {
        //     if (env.IsDevelopment())
        //     {
        //         app.UseDeveloperExceptionPage();
        //     }
        //     app.Run(async (context) =>
        //     {
        //         int x = 0;
        //         int y = 8 / x;
        //         await context.Response.WriteAsync($"Result = {y}");
        //     });
        // }

        //Теперь посмотрим, как все это будет выглядеть для простого пользователя.
        //Для этого изменим метод Configure:
        // public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        // {
        //     env.EnvironmentName = "Production";
        //     if (env.IsDevelopment())
        //     {
        //         app.UseDeveloperExceptionPage();
        //     }
        //     app.Run(async (context) =>
        //     {
        //         int x = 0;
        //         int y = 8 / x;
        //         await context.Response.WriteAsync($"Result = {y}");
        //     });
        // }

        //UseExceptionHandler
        //Это не самая лучшая ситуация,
        //и нередко все-таки возникает необходимость дать пользователям некоторую информацию о том,
        //что же все-таки произошло. Либо потребуется как-то обработать данную ситуацию.
        //Для этих целей можно использовать еще один встроенный middleware в виде метода UseExceptionHandler().
        //Он перенаправляет при возникновении исключения на некоторый адрес и позволяет обработать исключение.
        //Например, изменим метод Configure следующим образом:
        // public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        // {
        //     env.EnvironmentName = "Production";

        //     if (env.IsDevelopment())
        //     {
        //         app.UseDeveloperExceptionPage();
        //     }
        //     else
        //     {
        //         app.UseExceptionHandler("/error");
        //     }

        //     app.Map("/error", ap => ap.Run(async context =>
        //     {
        //         await context.Response.WriteAsync("DivideByZeroException occured!");
        //     }));

        //     app.Run(async (context) =>
        //     {
        //         int x = 0;
        //         int y = 8 / x;
        //         await context.Response.WriteAsync($"Result = {y}");
        //     });
        // }
        //Следует учитывать, что оба middleware - app.UseDeveloperExceptionPage() и app.UseExceptionHandler()
        //следует помещать ближе к началу конвейера middleware.

        //Обработка ошибок HTTP
        // public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        // {
        //     if (env.IsDevelopment())
        //     {
        //         app.UseDeveloperExceptionPage();
        //     }

        //     // обработка ошибок HTTP
        //     //app.UseStatusCodePages();

        //     //В качестве первого параметра указывается MIME-тип ответа,
        //     //а в качестве второго - собственно то сообщение, которое увидит пользователь.
        //     //В сообщение мы можем передать код ошибки через плейсхолдер "{0}".
        //     //app.UseStatusCodePages("text/plain", "Error. Status code : {0}");

        //     //С помощью метода app.UseStatusCodePagesWithRedirects() можно выполнить переадресацию на определенный метод,
        //     //который непосредственно обработает статусный код:
        //     //app.UseStatusCodePagesWithRedirects("/error?code={0}");

        //     app.Map("/hello", ap => ap.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync($"Hello ASP.NET Core");
        //     }));
        // }

        //Но теперь при обращении к несуществующему ресурсу клиент получит статусный код 302 / Found.
        //То есть формально несуществующий ресурс будет существовать, просто статусный код 302 будет указывать,
        //что ресурс перемещен на другое место - по пути "/error/404".
        //Подобное поведение может быть неудобно, особенно с точки зрения поисковой индексации,
        //и в этом случае мы можем применить другой метод app.UseStatusCodePagesWithReExecute():
        //Пример использования:
        // public void Configure(IApplicationBuilder app)
        // {
        //     // обработка ошибок HTTP
        //     app.UseStatusCodePagesWithReExecute("/error", "?code={0}");

        //     app.Map("/error", ap => ap.Run(async context =>
        //     {
        //         await context.Response.WriteAsync($"Err: {context.Request.Query["code"]}");
        //     }));

        //     app.Map("/hello", ap => ap.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync($"Hello ASP.NET Core");
        //     }));
        // }

        //Настройка обработки ошибок в web.config
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.Map("/hello", ap => ap.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync($"Hello ASP.NET Core");
        //     }));
        // }



    }
}
