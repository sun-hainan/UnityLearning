using UnityEngine;

public class PhysicsSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public float spawnForce = 500f;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnBall();
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetScene();
        }
    }
    
    void SpawnBall()
    {
        // 在鼠标位置生成小球
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit))
        {
            GameObject ball = Instantiate(ballPrefab, hit.point + Vector3.up * 2, Quaternion.identity);
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * spawnForce);
            }
        }
    }
    
    void ResetScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}