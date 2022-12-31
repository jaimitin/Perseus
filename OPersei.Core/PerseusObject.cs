namespace Perseus.Core
{
    /// <summary>
    /// The base class for all Perseus objects
    /// </summary>
    public class PerseusObject : IEquatable<PerseusObject>
    {
        /// <summary>
        /// The number of <see cref="PerseusObject"/> instances since initialization
        /// </summary>
        public static int Instances { get; private set; }

        /// <summary>
        /// The identifier for this instance
        /// </summary>
        public Guid ID { get; } = new();

        public PerseusObject()
        {
            ++Instances;
        }


        #region Equality

        public bool Equals(PerseusObject? other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (GetType() != other.GetType())
            {
                return false;
            }

            return ID.Equals(other.ID);
        }

        public override bool Equals(object? obj) => Equals(obj as PerseusObject);

        public override int GetHashCode() => ID.GetHashCode();

        public static bool operator ==(PerseusObject? left, PerseusObject? right)
        {
            if (left is null || right is null)
            {
                return false;
            }

            return left.Equals(right);
        }

        public static bool operator !=(PerseusObject? left, PerseusObject? right) => !(left == right);

        #endregion

    }
}
