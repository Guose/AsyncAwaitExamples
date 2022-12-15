

Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.Configure(app =>
        {
            app.Run(async context =>
            {
                // Simulate BAD access of e.g. DB
                //Thread.Sleep(1000);

                // Simulate GOOD access of e.g. DB
                await Task.Delay(10000);

                await context.Response.WriteAsync("Hello World!");
            });
        });
    })
    .Build().Run();