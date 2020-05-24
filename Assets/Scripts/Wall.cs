using UnityEngine;

public class Wall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D  col)
    {
        // Game over if the Weight hitted the ground
        if(col.collider.tag == "Weight")
        {
            // Call this function on GameManager class
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
