using System;
using System.Collections.Generic;

namespace Project.Service
{
    public static class Extension
    {
        public static T Pop<T>(this List<T> lst)
        {
            if (lst == null || lst.Count == 0)
            {
                throw new Exception("List is Empty");
            }

            int index = lst.Count - 1;
            T result = lst[index];
            lst.RemoveAt(index);
            return result;
        }

        public static T FirstOrDefault<T>(this List<T> lst)
        {
            return (lst == null || lst.Count == 0) ? default : lst[0];
        }
    }
}
