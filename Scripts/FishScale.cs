using UnityEngine;

public class FishScale : MonoBehaviour
{
    public GameObject EnemyFishType1, EnemyFishType2;
    float x, y;
    void FixedUpdate()
    {
        SizeOfFish(EnemyFishType1, EnemyFishType2);
    }
    private void SizeOfFish(GameObject EnemyFishType1, GameObject EnemyFishType2)
    {
        x = Random.Range(-0.8f,-1.15f);
        y = x;
        
        EnemyFishType1.transform.localScale = new Vector3(x, -y, 0.0f);
        x = Random.Range(0.3f, 0.5f);
        y = x;
        EnemyFishType2.transform.localScale = new Vector3(x, y, 0.0f);

    }
   
}
