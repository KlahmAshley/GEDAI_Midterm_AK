using UnityEngine;

//AK BOILER PLATE FROM CLASS 
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{

    public static T Instance { get; private set; }

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this as T;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
