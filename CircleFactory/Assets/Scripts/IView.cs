using System;
using UnityEngine;

public interface IView
{
    event Action<Vector2> OnClickScreen;
}