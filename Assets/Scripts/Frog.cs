using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Frog : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D  col)
    {
        // Player win the level if the Weight touch the frog
        if(col.collider.tag == "Weight")
        {
            // StartCoroutine to work with IEnumerator
            StartCoroutine(RestartLevel());
        }
    }

    IEnumerator RestartLevel()
    {
        // Wait 1 second
        yield return new WaitForSeconds(1f);

        // Load the next level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
