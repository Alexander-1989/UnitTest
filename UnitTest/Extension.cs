using System;
using System.Collections.Generic;

namespace Project.Service
{
    public static class Extension
    {
        public static T PopBack<T>(this List<T> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new Exception("List is Empty");
            }

            int index = list.Count - 1;
            T result = list[index];
            list.RemoveAt(index);
            return result;
        }

        public static void PushBack<T>(this List<T> list, T value)
        {
            if (list == null)
            {
                throw new Exception("List is Empty");
            }

            list.Add(value);
        }

        public static T FirstOrDefault<T>(this List<T> lst, T defaultValue = default)
        {
            return (lst == null || lst.Count == 0) ? defaultValue : lst[0];
        }
    }
}
