using UnityEngine;


public abstract class BaseSingletonScene<T> : MonoBehaviour where T : MonoBehaviour
{
    public static      T    Instance { get; private set; }
    protected abstract void AwakeFunction();
    protected void Awake()
    {
        if (Instance == null)
        {
            Instance = this as T;
            AwakeFunction();
        }
        else { Destroy(gameObject); }
    }
}