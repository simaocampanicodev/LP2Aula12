using UnityEngine;

public class InstanceController : MonoBehaviour, IGameObjectFactory, IGameObjectRecycler
{
    [SerializeField] private GameObject circle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Create()
    {
        return Instantiate(circle, transform.position, Quaternion.identity, transform);
    }
    public void Remove(GameObject gameObject)
    {
        Destroy(gameObject);
    }
}
