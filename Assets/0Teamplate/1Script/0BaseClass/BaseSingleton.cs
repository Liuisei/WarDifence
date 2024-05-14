using UnityEngine;


public abstract class BaseSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static      T    Instance { get; private set; }
    protected abstract void AwakeFunction();
    protected void Awake()
    {
        if (Instance == null)
        {
            Instance = this as T;
            DontDestroyOnLoad(gameObject);
            AwakeFunction();
        }
        else { Destroy(gameObject); }
    }
}