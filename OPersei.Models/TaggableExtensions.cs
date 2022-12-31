using OPersei.Core.StringExtensions;
using System.Collections;

namespace OPersei.Models
{
    public static class TaggableExtensions
    {
        private static bool Valid(this ITaggable taggable) => taggable is not null && taggable.Tags is not null && taggable.Tags.Any();

        /// <summary>
        /// Check whether the specified <paramref name="tag"/> is present in the tag list
        /// </summary>
        /// <param name="taggable"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public static bool HasTag(this ITaggable taggable, string tag)
        {
            return taggable.Valid() && !tag.IsNullOrEmpty() && taggable.Tags.Contains(tag);
        }

        /// <summary>
        /// Add a tag to the tag list
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the tag was added successfully, otherwise <see langword="false"/>
        /// </returns>
        public static bool AddTag(this ITaggable taggable, string tag)
        {
            if (taggable.Valid() && !tag.IsNullOrEmpty())
            {
                if (taggable.Tags is IList list && !list.IsReadOnly)
                {
                    list.Add(tag);
                }
            }

            return false;
        }

        /// <summary>
        /// Add a tag to the tag list
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the tag was added successfully, otherwise <see langword="false"/>
        /// </returns>
        public static bool RemoveTag(this ITaggable taggable, string tag)
        {
            if (taggable.Valid() && !tag.IsNullOrEmpty())
            {
                if (taggable.Tags is IList list && !list.IsReadOnly)
                {
                    list.Remove(tag);
                }
            }

            return false;
        }
    }
}
