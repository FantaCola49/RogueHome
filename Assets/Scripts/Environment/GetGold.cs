using UnityEngine;

public class GetGold : MonoBehaviour
{
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Rogue>(out Rogue rogue))
        {
            Debug.Log("The rogue grabbed a chest full of gold!!");
            Destroy(gameObject);
        }
    }
}
