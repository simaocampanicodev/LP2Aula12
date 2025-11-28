using UnityEngine;

public class MainController : MonoBehaviour
{
    [SerializeField] private GameObject circle;
    private IView view;
    private void Awake()
    {
        view = GetComponent<View>();
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
        Instantiate(circle, pos, Quaternion.identity);
    }
}
