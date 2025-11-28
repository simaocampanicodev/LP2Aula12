using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour, IGameObjectFactory, IGameObjectRecycler
{
    [SerializeField] private GameObject circle;
    [SerializeField] private uint initPoolSize;
    private Stack<GameObject> pool;

    private void Start()
    {
        pool = new Stack<GameObject>();

        for (uint i = 0; i < initPoolSize; i++)
        {
            GameObject gameObject = TrueCreate();
            gameObject.SetActive(false);
            pool.Push(gameObject);
        }
    }
    private GameObject TrueCreate()
    {
        return Instantiate(circle, transform);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Create()
    {
        GameObject gameObject;
        if (pool.Count == 0)
        {
            gameObject = TrueCreate();
        }
        else
        {
            gameObject = pool.Pop();
            gameObject.SetActive(true);
        }
        return gameObject;
    }
    public void Remove(GameObject gameObject)
    {
        gameObject.SetActive(false);
        pool.Push(gameObject);
    }
}
