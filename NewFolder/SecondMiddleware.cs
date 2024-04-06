namespace MyCustomMiddleware.NewFolder
{
    public class SecondMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Second Middleware is Called");
            await context.Response.WriteAsync("Second Middleware is Called \n");
            await next(context);
        }
    }
}