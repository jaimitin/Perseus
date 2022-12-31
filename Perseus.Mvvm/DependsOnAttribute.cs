namespace Perseus.Mvvm
{
    /// <summary>
    /// Instructs a <see cref="NotificationObject"/> to update this property whenever the specified <paramref name="dependency"/> changes
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class DependsOnAttribute : Attribute
    {
        public string Dependency { get; }

        public DependsOnAttribute(string dependency)
        {
            Dependency = dependency;
        }
    }
}
