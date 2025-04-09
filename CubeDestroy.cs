using UnityEngine;

public class CubeDestroy : MonoBehaviour, IHittable
{
    public void OnHit()
    {
        Destroy(gameObject);
        PlayerScore.currentScore += 30; 
    }
}
