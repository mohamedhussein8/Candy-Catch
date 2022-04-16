using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // al collider da al 7aga al ana 3mltah 3la kol sora we hna al function de 
    // kman mohamt function trigger ht4t8l lma collider et3aml m3 object aw collider tany
     void OnTriggerEnter2D (Collider2D  collider)
    {
        // hna polo law lat collider asmh player dmrh al hwa eakl al 7alwa 
        // tap eh hwa al player da tag fe unity  tap eh mohamt al tag be5alny ande 3la al 7aga bshola
        if (collider.gameObject.tag == "Player")
        {
            // hna pa law lay al player da hezawd al score we edmrh 
            GameManager.instance.IncremenScore();
            Destroy(gameObject);
        }
        // hna da tag b3ad 7dod al camera 3la law 7aga mdart4 aklha tdamr bardo ta7t 
        else if (collider.gameObject.tag == "Boundary")
        {
            GameManager.instance.DecreaseLife();
            Destroy(gameObject);
        }
    }
}
