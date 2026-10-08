using UnityEngine;

public abstract class Factory : MonoBehaviour
{
    public abstract IBubble GetBubble(Vector3 position);
}
