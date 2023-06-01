using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static int slot1, slot2, slot_Discarded;
    public int test, test2;

    public static bool slot_Active;

    private void Awake()
    {
        slot_Active = true;
    }

    private void Update()
    {
        test = slot1;
        test2 = slot2;
    }
}
