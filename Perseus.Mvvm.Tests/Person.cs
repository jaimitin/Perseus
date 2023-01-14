namespace Perseus.Mvvm.Tests
{
    public partial class NotificationObjectTests
    {
        public class Car : NotificationObject
        {
            public Action? OnChanged { get; set; }
            public Action? OnChanging { get; set; }
            public Func<string, string, bool>? OnValidate { get; set; }

            private string make = "";
            public string Make
            {
                get => make;
                set => Set(ref make, value, onChanging: OnChanging, onChanged: OnChanged, validateValue: OnValidate);
            }

            private string model = "";
            public string Model
            {
                get => model;
                set => Set(ref model, value, onChanging: OnChanging, onChanged: OnChanged, validateValue: OnValidate);
            }

            [DependsOn(nameof(Make))]
            [DependsOn(nameof(Model))]
            public string MakeAndModel => $"{Make} {Model}";

            public string MakeAndModelNoAttribute => $"{Make} {Model}";
        }
    }
}