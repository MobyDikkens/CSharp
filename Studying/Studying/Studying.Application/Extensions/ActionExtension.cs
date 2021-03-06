using System;

namespace Studying.Application.Extensions
{
    public static class ActionExtension
    {
        public static Action Merge(this Action first, Action toMerge)
        {
            Action merged = () =>
            {
                first();
                toMerge();
            };

            return merged;
        }
    }
}