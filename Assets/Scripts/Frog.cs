using UnityEngine;

public class Frog : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D  col)
    {
        // Player win the game if the Weight touch the frog
        if(col.collider.tag == "Weight")
        {
            Debug.Log("You Win");
        }
    }
}
