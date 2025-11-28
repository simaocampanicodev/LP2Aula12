using UnityEngine;
using System.Collections;

public class CircleModel : MonoBehaviour
{
    [SerializeField] private float minValue;
    [SerializeField] private float maxValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Destroy(gameObject, Random.Range(minValue, maxValue));
    }
}
