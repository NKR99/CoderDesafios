using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSingeltone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            SceneManager.LoadScene(1);
        }
        
    }
}
