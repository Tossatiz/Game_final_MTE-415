using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
   

    public int NBofItem { get; private set; }

    public UnityEvent<PlayerInventory> OnItemCollected;
    

    public void ItemCollected()
    {
        NBofItem++;
        OnItemCollected.Invoke(this);
    }


}
