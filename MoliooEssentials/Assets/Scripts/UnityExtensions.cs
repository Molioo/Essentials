using System.Collections.Generic;
using UnityEngine;

public static class UnityExtensions
{

    /// <summary>
    /// Extension method to check if a layer is in a layermask
    /// </summary>
    public static bool Contains(this LayerMask mask, int layer)
    {
        return mask == (mask | (1 << layer));
    }

    public static bool IsChildOfExtended(this Transform transform, string parentName)
    {
        if (transform.parent == null)
            return false;

        return transform.parent.name != parentName ? IsChildOfExtended(transform.parent, parentName) : true;
    }

    public static void ChangeAlpha(this UnityEngine.UI.Image image, float alpha)
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);
    }

    public static Color ChangeAlpha(this Color color, float alpha)
    {
        color.a = alpha;
        return color;
    }

    public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion angle)
    {
        return angle * (point - pivot) + pivot;
    }

    public static void SetSkinnedMeshRenderer(this ParticleSystem particleSystem, SkinnedMeshRenderer skinnedMeshRenderer)
    {
        ParticleSystem.ShapeModule shape = particleSystem.shape;
        shape.skinnedMeshRenderer = skinnedMeshRenderer;
    }

    public static T GetRandom<T>(this List<T> list)
    {
        if (list == null || list.Count == 0)
        {
            return default(T);
        }
        else
        {
            return list[Random.Range(0, list.Count)];
        }
    }

    public static T Last<T>(this List<T> list)
    {
        if (list.Count == 0)
        {
            return default(T);
        }
        else
        {
            return list[list.Count - 1];
        }
    }

    public static bool IsLast<T>(this List<T> list, T element)
    {
        if (list.Count == 0)
        {
            return false;
        }
        else
        {
            int indexOfElement = list.IndexOf(element);
            return indexOfElement == list.Count - 1;
        }
    }

    public static T GetNext<T>(this List<T> list, T element)
    {
        if (list.Count == 0)
        {
            return default(T);
        }
        else
        {
            int indexOfElement = list.IndexOf(element);
            if (indexOfElement == list.Count - 1)
                return default(T);
            else
                return list[indexOfElement + 1];
        }
    }

    public static T GetPrevious<T>(this List<T> list, T element)
    {
        if (list.Count == 0)
        {
            return default(T);
        }
        else
        {
            int indexOfElement = list.IndexOf(element);
            if (indexOfElement == 0)
                return default(T);
            else
                return list[indexOfElement + 1];
        }
    }

    public static float GetRandomValueInRange(this Vector2 vector)
    {
        return Random.Range(vector.x, vector.y);
    }

    public static int GetRandomValueInRange(this Vector2Int vector)
    {
        return Random.Range(vector.x, vector.y);
    }

    public static void SwitchAllValues(this CanvasGroup canvasGroup, bool value)
    {
        canvasGroup.alpha = value ? 1 : 0;
        canvasGroup.blocksRaycasts = value;
        canvasGroup.interactable = value;
    }
    public static float Vector3InverseLerp(Vector3 a, Vector3 b, Vector3 value)
    {
        Vector3 AB = b - a;
        Vector3 AV = value - a;
        return Vector3.Dot(AV, AB) / Vector3.Dot(AB, AB);
    }
}
