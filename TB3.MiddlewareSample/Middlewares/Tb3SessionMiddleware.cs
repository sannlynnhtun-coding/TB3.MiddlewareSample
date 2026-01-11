namespace TB3.MiddlewareSample.Middlewares
{
    public class Tb3SessionMiddleware
    {
        private readonly RequestDelegate _next;

        public Tb3SessionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if(!AllowUrls.ToList().Any(x=> x == context.Request.Path.ToString()))
            {
                // logic 
                if (context.Session.GetString("UserName") == null)
                {
                    context.Response.Redirect("/Home");
                }

                // database // 2 sec
                // session expired 

                // encryption
                // decryption // 0.2 sec
            }
          
            await _next(context);
        }

        private string[] AllowUrls = new string[]
        {
            "/",
            "/Home",
            "/Home/Index",
            "/Home/Login",
        };
    }

    // http://localhost:5000/login > middleware (InvokeAsync) > controller
}
