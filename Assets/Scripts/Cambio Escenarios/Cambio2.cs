
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cambio2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(4);
        }
    }
}
