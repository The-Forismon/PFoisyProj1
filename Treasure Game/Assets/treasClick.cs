using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasClick : MonoBehaviour
{
    public Sprite sprite1; // First Sprite
    public Sprite sprite2; // Second Sprite
    private SpriteRenderer spriteRenderer;

    float timeLeft = 12.0f;
    public GameObject lossWords;
    public GameObject winWords;
    public bool winCheck;

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
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0 && winCheck == false)
        {
            GameOver();
        }
        else
        {
            if (Input.GetMouseButtonDown(0)) // If the item is clicked
            {
                spriteChange(); // call method to change sprite
                winWords.SetActive(true);
                winCheck = true;
            }
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
    void GameOver()
    {
        lossWords.SetActive(true);
    }
}

