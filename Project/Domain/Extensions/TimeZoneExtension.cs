namespace Domain.Extensions;
public static class TimeZoneExtension
{
    public static DateTime StandardLocalTime(this DateTime date)
    {
        var est = TimeZoneInfo.FindSystemTimeZoneById("Bangladesh Standard Time");
        return TimeZoneInfo.ConvertTime(date, est);
    }
}
