﻿using System.Reflection;

using UnityEngine;

namespace Assets.Mikazuki.EditorExtensions.Editor.Reflections
{
    public class VerticalGrid : ReflectionAccessor<object>
    {
        public VerticalGrid(object instance) : base(instance, typeof(UnityEditor.Editor).Assembly.GetType("UnityEditor.VerticalGrid")) { }

        public Rect CalcRect(int itemIdx, float yOffset)
        {
            return CallMethodAs<Rect>("CalcRect", BindingFlags.Instance | BindingFlags.Public, itemIdx, yOffset);
        }
    }
}