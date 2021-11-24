
namespace AdamTibi.OpenWeather
{
    public interface IClient
    {
        Task<OneCallResponse> OneCallAsync(decimal latitude, decimal longitude, Excludes[] excludes, Units unit);
    }
}