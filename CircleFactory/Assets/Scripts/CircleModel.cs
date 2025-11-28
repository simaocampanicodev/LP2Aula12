using UnityEngine;
using System.Collections;

public class CircleModel : MonoBehaviour
{
    [SerializeField] private float minValue;
    [SerializeField] private float maxValue;

    private IGameObjectRecycler recycler;
    private IEnumerator deadline;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        //Destroy(gameObject, Random.Range(minValue, maxValue));
        recycler = GetComponentInParent<IGameObjectRecycler>();
    }

    private void OnEnable()
    {
        StartCoroutine(deadline);
        deadline = DestroyInTheFuture();
    }

    private void OnDisable()
    {
        
    }

    private IEnumerator DestroyInTheFuture()
    {
        float seconds = Random.Range(minValue, maxValue);
        yield return new WaitForSeconds(seconds);
        recycler.Remove(gameObject);
    }
}
