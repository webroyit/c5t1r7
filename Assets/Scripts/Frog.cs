using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D  col)
    {
        // Player win the level if the Weight touch the frog
        if(col.collider.tag == "Weight")
        {
            // Load the next level
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
