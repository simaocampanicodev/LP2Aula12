using UnityEngine;

public class MainController : MonoBehaviour
{
    private IView view;
    private IGameObjectFactory factory;
    private void Awake()
    {
        view = GetComponent<View>();
        factory = GetComponent<IGameObjectFactory>();
    }

    private void OnEnable()
    {
        view.OnClickScreen += SpawnCircle;
    }

    private void OnDisable()
    {
        view.OnClickScreen -= SpawnCircle;
    }

    private void SpawnCircle(Vector2 pos)
    {
        GameObject gameObject = factory.Create();
        gameObject.transform.position = pos;
    }
}
