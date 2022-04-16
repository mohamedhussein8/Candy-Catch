using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    // al kalma de 3l4a epan fe al unity we adar a5er feha 
    [SerializeField]
    // var max da 3l4an olo eh aksa msafa blnspa ly al a4kal al htnzel 
    float maxX;
    [SerializeField]
    // al var da 3l4an a7dd al 7aga htnzel pa3d kam sec wara ba3d 
    float spawnInterval;
    // de array mt5azn feha al 4 a4kalm al benzlo 
    public GameObject[] Candies;
    // 3mlna mn no3 al script 3l4an adar a3ml 3aleh access fe ay wat 
    public static CandySpawner instance;
    private void Awake()
    {
        // hna polo law besawy null a5zno gwa al object 
        if (instance== null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //SpawnCandy();
        StartSpawningCandies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnCandy()
    {
        // da 3l4an egep ay 4akl 34way
        int rand = Random.Range(0, Candies.Length);
        // da hna 3l4an egep mkan 34waya pardo 
        float randomX= Random.Range(-maxX, maxX);
        // hna vector de 5altha ta5d mkan al x pas 
        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);
        // hna pa 5ad mkan we  al 4akl we he3ml rotation 
        Instantiate(Candies[rand], randomPos, transform.rotation);
    }
    // ast5dmna ienumerator de 3la4n al tkrar ea3ne de al bt5aly al 7aga tfdel tanzel mn fo 
    IEnumerator SpawnCandies()
    {
        // hna polo astana 2 sec 3l4an epda e4ta8l
        yield return new WaitForSeconds(2f);
        while (true)
        {
            // hna pa hwa true ea3ne a4ta8l bnady 3la al fun al fol al hya btgep al 4akl we al mkana 3l4an anzel 
            SpawnCandy(); 
            // law anata faker olo al var da fol ana 3mlto 3l4an olo hstna kam sec 3l4an 7aga tanzel wara al taneha we ba3mel kda mn al unity pa 
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    // 3l4an pa a48al al fun al asmha  IEnumerator  lazm a3ml wa7da start tandy 3aleha we wa7da stop lma emot e5als al 3 fors ea3ne 
    public void StartSpawningCandies()
    {
        // StartCoroutine de 3l4an ader at3aml m3 IEnumerator
        StartCoroutine("SpawnCandies");
    }
    public void StopSpawningCandies()
    {
        StopCoroutine("SpawnCandies");
    }
    
}
