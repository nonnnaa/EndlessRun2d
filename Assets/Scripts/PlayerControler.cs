using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float speedRun = 1f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speedJump;
    [SerializeField] private Animator animator;
    [SerializeField] private bool canJump;
    [SerializeField] private int spaceCount;
    public GameObject GameOverPanel;
    public bool isGameOver;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

   
    void Update()
    {
        if(!isGameOver)
        {
            transform.position += Time.deltaTime * speedRun * Vector3.right;
        }
        
        if(spaceCount > 2)
        {
            canJump = false;
        }
        if(Input.GetKeyDown("space") && canJump && !isGameOver)
        {
            rb.velocity = Vector3.up * speedJump;
            spaceCount += 1;
        }
    }
   
    public void GameOver()
    {
        isGameOver = true;
        animator.SetTrigger("die");
        StartCoroutine("ShowGameOverPanel");
        //Debug.Log("1111111");
    } 
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Land"))
        {
            spaceCount = 0;
            canJump = true;
        }
        if (collision.gameObject.CompareTag("obstacles") || collision.gameObject.CompareTag("DesTroyBottom"))
        {
            GameOver();
        }
    }
    IEnumerator ShowGameOverPanel()
    {
        yield return new WaitForSeconds(1);
        GameOverPanel.SetActive(true);
    }
}
