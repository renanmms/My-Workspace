using System;

namespace FluentValidationSample.Models
{
    public class Party
    {
        public List<Person> Guests { get; set; } = new();
    }
}