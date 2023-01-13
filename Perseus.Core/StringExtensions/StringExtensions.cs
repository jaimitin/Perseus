﻿namespace Perseus.Core.Extensions
{
    /// <summary>
    /// String extensions
    /// </summary>
    public static class StringExtensions
    {
        /// <inheritdoc cref="string.IsNullOrWhiteSpace(string?)"/>
        public static bool IsNullOrWhiteSpace(this string? value) => string.IsNullOrWhiteSpace(value);

        /// <inheritdoc cref="string.IsNullOrEmpty(string?)"/>
        public static bool IsNullOrEmpty(this string? value) => string.IsNullOrEmpty(value);
    }
}
