using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Runtime.InteropServices;

namespace Update.Mapper;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {

    }
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {

    }

    public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyConverter() : base(dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue), dateTime => DateOnly.FromDateTime(dateTime))
        {
        }
    }
}