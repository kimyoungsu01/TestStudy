using UnityEngine;

public class ChacterManager : MonoBehaviour
{
    public static ChacterManager Instance { get; private set; }
    public Player _player { get; set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}


