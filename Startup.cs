using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            //app.UseWebSockets();
            //app.Use(async (context, next) =>
            //{
            //    if (context.WebSockets.IsWebSocketRequest)
            //    {
            //        WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync();
            //        await RouteSocketMessages(context, webSocket);
            //    }
            //    else 
            //    {
            //        await next();    
            //    }
            //});

            app.UseMvc(routes =>
            {
				routes.MapRoute(
					name: "CreateTopicException",
					template: "Topic/Create",
					defaults: new { controller = "Topic", action = "Create" });
                
                routes.MapRoute(
                    name: "TopicByName",
                    template: "Topic/{name}",
                    defaults: new { controller = "Topic", action = "Detail" });
                
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

		//private async Task RouteSocketMessages(HttpContext context, WebSocket webSocket)
		//{
		//	var buffer = new byte[1024 * 4];
  //          var segment = new ArraySegment<byte>(buffer);
		//	WebSocketReceiveResult result = await webSocket.ReceiveAsync(segment, CancellationToken.None);
		//	while (!result.CloseStatus.HasValue)
		//	{
  //              // serialize message and route
  //              var msg = Encoding.ASCII.GetString(segment.Array, segment.Offset, result.Count);
  //              SocketMessageHandler.Route(webSocket, buffer, msg, result);
		//	}
		//	await webSocket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);
		//}
    }
}
