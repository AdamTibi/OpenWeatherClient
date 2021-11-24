using System.ComponentModel.DataAnnotations;

namespace AdamTibi.OpenWeather;

public enum Units
{
    [Display(Name = "standard")]
    Standard,
    [Display(Name = "metric")]
    Metric,
    [Display(Name = "imperial")]
    Imperial
}

