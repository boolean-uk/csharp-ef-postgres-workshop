using efworkshop.api.Repository;
using System.Runtime.CompilerServices;

namespace efworkshop.api.EndPoint
{
    public static class CarApi
    {
        public static void ConfigureCarApi(this WebApplication app)
        {
            app.MapGet("/cars", GetCars);
        }

        private static async Task<IResult> GetCars(ICarRepository repository)
        {
            try
            {
                return Results.Ok(repository.GetCars());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
