﻿using System.Collections.Generic;
using Random = UnityEngine.Random;

public static class Extensions
{
    public static T GetRandom<T>(this T[] array) => array[Random.Range(0, array.Length)];
    public static T GetRandom<T>(this List<T> list) => list[Random.Range(0, list.Count)];

    public static void Shuffle<T>(this List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int randomIndex = Random.Range(0, list.Count);
            (list[i], list[randomIndex]) = (list[randomIndex], list[i]);
        }
    }

    public static List<T> GetRandoms<T>(this List<T> list, int count, bool withoutRepetition)
    {
        var result = new List<T>();
        if (withoutRepetition)
        {
            var copy = new List<T>(list);
            for (int i = 0; i < count; i++)
            {
                int randomIndex = Random.Range(0, copy.Count);
                result.Add(copy[randomIndex]);
                copy.RemoveAt(randomIndex);
            }
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                result.Add(list.GetRandom());
            }
        }
        return result;
    }
}
