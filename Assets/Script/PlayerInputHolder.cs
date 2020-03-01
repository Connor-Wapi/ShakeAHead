using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerInputHolder
{
    public static bool Holding { get; private set; }

    public static void Hold()
    {
        Holding = true;
    }

    public static void Unhold()
    {
        Holding = false;
    }
}
