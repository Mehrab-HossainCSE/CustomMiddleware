namespace MyCustomMiddleware.NewFolder
{
    public class ThirdMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Third Middleware is Called");
            await context.Response.WriteAsync("The Third Middleware is Called \n");
            await next(context);
        }
    }
}