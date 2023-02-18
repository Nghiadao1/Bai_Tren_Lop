//using build_shopping_cart.Data;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;


//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSession(options =>
//{
//    options.IdleTimeout = TimeSpan.FromMinutes(30);
//});
//builder.Services.AddMvc();

//// Add services to the container.
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<EFDataContext>(options =>
//    options.UseSqlServer(connectionString));
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<EFDataContext>();
//builder.Services.AddControllersWithViews();
//////






//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseMigrationsEndPoint();
//}
//else
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}




////app.UseHttpsRedirection();
////app.UseStaticFiles();

////app.UseRouting();

////app.UseAuthentication();
////app.UseAuthorization();

////app.MapControllerRoute(
////    name: "default",
////    pattern: "{controller=Home}/{action=Index}/{id?}");




////app.MapControllerRoute(
////      name: "default",
////      pattern: "{controller=Product}/{action=Index}/{id?}");
////app.UseMvc(routes =>
////{
////    routes.MapRoute(
////        name: "default",
////        template: "{controller=Product}/{action=Index}/{id?}");
////});

////app.UseEndpoints(endpoints =>
////{
////    endpoints.MapControllerRoute(
////        name: "default",
////        pattern: "{controller=Product}/{action=Index}/{id?}");
////});

////app.AddNLogWeb();

//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseCookiePolicy();
//app.UseSession();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{controller=Product}/{action=Index}/{id?}");
//});