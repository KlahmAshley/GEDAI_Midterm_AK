using Unity.VisualScripting;
using UnityEngine;

public class BubbleFactoryA : Factory
{
    [SerializeField] private BubbleA productPrefab;

    public override IBubble GetBubble(Vector3 position)
    {
        // create a Prefab instance and get the product component
        GameObject instance = Instantiate(productPrefab.gameObject, position, Quaternion.identity);
        BubbleA newBubble = instance.GetComponent<BubbleA>();

        // each product contains its own logic
        newBubble.Initialize();

       return newBubble;
    }
}
