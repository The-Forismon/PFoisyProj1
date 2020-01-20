using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class guffClick : MonoBehaviour
{
    public Sprite sprite1; // First Sprite
    public Sprite sprite2; // Second Sprite
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
        {
            spriteRenderer.sprite = sprite1; // set the sprite to sprite1
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // If the item is clicked
        {
             spriteChange(); // call method to change sprite
        
        }
    }
    void spriteChange()
    {
        if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteRenderer.sprite = sprite2;
        }
        else
        {
            spriteRenderer.sprite = sprite1; // otherwise change it back to sprite1
        }
    }
}