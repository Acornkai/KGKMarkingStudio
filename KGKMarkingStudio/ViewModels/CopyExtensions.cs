using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace KGKMarkingStudio.ViewModels;

public static class CopyExtensions
{
    public static ImmutableArray<T>.Builder CopyShared<T>(this ref ImmutableArray<T> array, IDictionary<object, object>? shared) where T : ViewModelBase
    {
        var copy = ImmutableArray.CreateBuilder<T>();

        foreach(var item in array)
        {
            var itemCopy = item.CopyShared(shared);
            if(itemCopy is not null)
            {
                copy.Add(itemCopy); 
            }
        }

        return copy;
    }

    public static T? CopyShared<T>(this T? item, IDictionary<object, object>? shared) where T : ViewModelBase
    {
        if(item is nuint)
        {
            return null;
        }

        if(shared is null)
        {
            return (T)item.Copy(shared);
        }

        if(shared.TryGetValue(item, out var copy))
        {
            return (T)copy;
        }

        copy = item.Copy(shared);
        shared[item] = copy;
        shared[copy] = item;

        return (T)copy; 
    }
}
