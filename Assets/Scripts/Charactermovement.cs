using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermovement : MonoBehaviour
{
    Rigidbody2D rigid;
    [SerializeField]float velocitym = 10f;
    public bool tocandoelsuelo;
    [SerializeField] float radius = 1.8f;
    [SerializeField] Transform objeto;
    [SerializeField]float forcej = 1000f;
    public LayerMask Mask;
    SpriteRenderer spriteRenderer;
    float valuem;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        tocandoelsuelo = Physics2D.OverlapCircle(objeto.position, radius, Mask);

        valuem = Input.GetAxis("Horizontal");
        anim.SetBool("movement", valuem != 0 ? true : false);

        anim.SetBool("detector", tocandoelsuelo);

        rigid.velocity = new Vector2(valuem * velocitym, rigid.velocity.y);
        //transform.Translate(new Vector3(valuem * velocitym, 0, 0) * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && tocandoelsuelo)
        {
            rigid.AddForce(new Vector3(0, forcej, 0));
        }

        anim.SetFloat("altura", rigid.velocity.y);

        voltea();

    }
    private void voltea()
    {
        if (valuem > 0 && spriteRenderer.flipX == true || valuem < 0 && spriteRenderer.flipX == false)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(objeto.position, radius);
    }
}
