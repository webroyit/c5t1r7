using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D  col)
    {
        // Game over if the Weight hitted the ground
        if(col.collider.tag == "Weight")
        {
            // Restart the game
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
