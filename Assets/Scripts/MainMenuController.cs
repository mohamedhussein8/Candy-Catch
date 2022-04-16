using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// de bst5dmha 3l4an adar andy 3la 3la ay  code fe mkan tane pas akt al asm zy t7at kda
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // hna bynady al scene al asmha game 3l4an esta5dm kol al gwaha lma edos play 
    public void Play()
    {
        SceneManager.LoadScene("game");
        
    }
    // hna 3l4an lma edos exit al game tof 
    public void Exit()
    {
        Application.Quit();
    }
}
