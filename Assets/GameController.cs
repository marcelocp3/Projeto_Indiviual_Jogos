using UnityEngine;

public static class GameController
{
    private static int collectableCount;

    public static bool GameOver
    {
        get {return collectableCount <= 0; }
    }

    public static void Init()
    {
        collectableCount = 5;
    }

    public static void Collect()
    {
        collectableCount --;
    }
}
