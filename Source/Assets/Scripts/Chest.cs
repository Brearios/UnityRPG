using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int goldAmount = 5;

   protected override void OnCollect()
    {
        if(!collected)

        {
            // Marking as collected
            collected = true;
            // Switching chest sprite
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            // Adding gold
            GameManager.instance.gold += goldAmount;
            // Floating text
            GameManager.instance.ShowText("+" + goldAmount + " gold!", 25, Color.yellow, transform.position, Vector3.up * 25, 1.5f);
        }
    }
}
