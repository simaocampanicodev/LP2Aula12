using System;
using UnityEngine;

public class View : MonoBehaviour, IView
{
    public event Action<Vector2> OnClickScreen;
    private void Start()
    {
        Camera.main.backgroundColor = Color.black;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Input.mousePosition;
            pos = Camera.main.ScreenToWorldPoint(pos);
            OnClickScreen?.Invoke(pos);
        }
    }
}
