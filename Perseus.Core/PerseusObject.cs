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
        /// The unique identifier for this instance
        /// </summary>
        public Guid ID { get; } = Guid.NewGuid();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerseusObject"/> class
        /// </summary>
        public PerseusObject()
        {
            ++Instances;
        }


        #region Equality

        /// <summary>
        /// Indicates whether the current <see cref="PerseusObject"/> is equal to the <paramref name="other"/> <see cref="PerseusObject"/>
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the current object is equal to the <paramref name="other"/> object; otherwise, <see langword="false"/>.
        /// </returns>
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

        /// <inheritdoc/>
        public override bool Equals(object? obj) => Equals(obj as PerseusObject);

        /// <inheritdoc/>
        public override int GetHashCode() => ID.GetHashCode();

        /// <summary>
        /// Determines whether two <see cref="PerseusObject"/> instances are equal.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if both objects are equal; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool operator ==(PerseusObject? left, PerseusObject? right)
        {
            if (left is null || right is null)
            {
                return false;
            }

            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two <see cref="PerseusObject"/> instances are not equal.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if both objects are not equal; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool operator !=(PerseusObject? left, PerseusObject? right) => !(left == right);

        #endregion

    }
}
