namespace MyCustomMiddleware.NewFolder
{
    public class FirstMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("First Middleware is Called");
            await context.Response.WriteAsync("First Middleware is Called \n");
            await next(context);
        }
    }
}