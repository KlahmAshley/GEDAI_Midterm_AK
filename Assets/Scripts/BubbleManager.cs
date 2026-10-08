using UnityEngine;

public class BubbleManager : MonoBehaviour
{ 
    [SerializeField] private Factory factory;

    public Vector3 spawnPoint = Vector3.zero;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            SpawnBubble();
        }
    }

    private void SpawnBubble()
    {
        IBubble product = factory.GetBubble(spawnPoint);
    }

}
