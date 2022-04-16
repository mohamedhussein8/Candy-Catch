using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 3mlt da 3l4an ashof hedar et7ark wla la 
   public bool canMove = true;
    [SerializeField]
    float maxPos;


    [SerializeField]
    float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { // gwa al update al 7aga btfdel ttkarr ea3ne et7ark bsr3a tol ma hwa be true 
        if (canMove)
        {
            Move();
        }

    }
    private void Move()
    {
        //de htrg3 a7na hnt7rk emen wla 4mal 
        float inputX = Input.GetAxis("Horizontal");
        //time .delattime da wat be al sec al fram bea5dh 3l4an ekml we victor .right m3ana kda (1, 0 ,0 )
        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;
        // matthf clamp de 3l4an olo eh aksa 7aga we eh all 7aga 
        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
        //hna pa pep3y al x we sapt al y we al z 
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);

    }
}
