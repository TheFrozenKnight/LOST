using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Animator animator;
    Vector2 input;
    public float picks = 0;
    private PauseMenu pauseMenu;
    public GameObject winButnoText;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        pauseMenu = FindObjectOfType<PauseMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseMenu.IsGamePaused)
            {
                pauseMenu.Resume();
            }
            else
            {
                pauseMenu.Pause();
            }
        }
        animator.SetFloat("InputX", input.x);
        animator.SetFloat("InputY", input.y);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            if (picks >= 5)
            {
                collision.gameObject.SetActive(false);
                pauseMenu.WIN();
            }
            else
            {
                StartCoroutine(exitButNo());
            }
        }
    }
    IEnumerator exitButNo()
    {
        winButnoText.SetActive(true);
        yield return new WaitForSeconds(3);
        winButnoText.SetActive(false);
    }
}
