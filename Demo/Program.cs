namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseRouting();

            app.UseStaticFiles();

            #region MyRegion

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You are At Home Page!");

            //    });
            //    endpoints.MapGet("/Products/{id?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["id"];

            //        if (idData is not null)
            //        {
            //            int id = Convert.ToInt32(idData);

            //            await context.Response.WriteAsync($"You Requeste Product With ID => {id} ");

            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync("You are At Products Page!");

            //        }

            //    });
            //    endpoints.MapGet("/Books/{id}/{Auther : alpha :minlength(4) :maxlength(6)}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);

            //        string Auther = context.Request.RouteValues["Auther"].ToString();

            //        await context.Response.WriteAsync($"You Requeste Product With ID => {id} and Auther => {Auther}");

            //    });
            //});

            //app.Run( async (HttpContext) =>
            //{
            //    await HttpContext.Response.WriteAsync("Your Requested Page Not Found");
            //});  
            #endregion

            app.MapControllerRoute(
               name: "default",
               pattern: "{Controller = Home}/{Action = Index}"
               //defaults: new { controller = "Home", Action = "Index" }
            );

            app.Run();
        }
    }
}
