//Next time Validator lives out of the project and on his own - he's big enough to take care of himself.

namespace Students.Common
{
    using System;

    public static class Validator
    {
        public static void ValidateStringNullOrWhiteSpace(string input, string paramName = "The string")
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentOutOfRangeException(paramName, "Cannot be Null, Empty or Whitespace");
            }
        }

        public static void ValidateObjectNotNull(object obj, string paramName = "The object")
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName, "Cannot be null");
            }
        }

        public static void ValidateStringLength(string str, int length, string paramName = "The string")
        {
            if (str.Length != length)
            {
                throw new ArgumentOutOfRangeException(paramName, string.Format("Must be {0} symbols", length));
            }
        }

        public static void ValidateRange(int forCheck, int rangeStart, int rangeEnd, string paramName = "Int for check")
        {
            if (rangeStart > forCheck || rangeEnd < forCheck)
            {
                throw new ArgumentOutOfRangeException(paramName, string.Format("Must be between {0} and {1}", rangeStart, rangeEnd));
            }
        }
    }
}
