
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1,10)]
    public float smoothFactor;

    [SerializeField] string sceneName;

    private void FixedUpdate() 
    {
        if (target != null)
        {
            Follow();
        }
        else
        {
            LoadScene();
        }
    }

    void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor*Time.fixedDeltaTime);
        transform.position = targetPosition;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
