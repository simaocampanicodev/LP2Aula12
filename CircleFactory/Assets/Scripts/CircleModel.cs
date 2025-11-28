using UnityEngine;
using System.Collections;

public class CircleModel : MonoBehaviour
{
    [SerializeField] private float minValue;
    [SerializeField] private float maxValue;

    private IGameObjectRecycler recycler;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        //Destroy(gameObject, Random.Range(minValue, maxValue));
        StartCoroutine(DestroyInTheFuture());
        recycler = GetComponentInParent<IGameObjectRecycler>();
    }
    private IEnumerator DestroyInTheFuture()
    {
        float seconds = Random.Range(minValue, maxValue);
        yield return new WaitForSeconds(seconds);
        recycler.Remove(gameObject);
    }
}
