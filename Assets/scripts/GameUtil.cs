using UnityEditor;
using UnityEngine;

public static class GameUtil
{
    public static bool hasTag(this GameObject gameObject, Tag t)
    {   
        return gameObject.TryGetComponent<Tags>(out var tags) && tags.HasTag(t);
    }

    public static bool hasTag(this GameObject gameObject, string tagName)
    {
        return gameObject.TryGetComponent<Tags>(out var tags) && tags.HasTag(tagName);
    }
}