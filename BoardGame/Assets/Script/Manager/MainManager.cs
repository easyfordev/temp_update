using UnityEngine;

public class MainManager : MonoBehaviour
{
    private static MainManager instance;
    public static MainManager Instance
    {
        get
        {
            if (!instance)
                return instance = new GameObject("MainManager").AddComponent<MainManager>();

            else
                return instance;
        }
    }
}