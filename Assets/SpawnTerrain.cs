using UnityEngine;
using System.Collections;

public class SpawnTerrain : MonoBehaviour {
    public GameObject movingPerson;
    private static int count = 0;
    public static int distant = 1;
    private static int increment = distant;
    public static int numberOfBlocks = 10;
    private static int blockcount = 0;
    private static int current= 0;
    GameObject[] blocks = new GameObject[numberOfBlocks];
    public GameObject terrain;
    private Renderer rend;
    // Use this for initialization
    void Start () {
       
	}

    // Update is called once per frame
    void Update()
    {
        
        if (count % 20 == 0 && numberOfBlocks > blockcount)
        {

            GameObject temp = Instantiate(terrain);
            temp.transform.position += new Vector3(distant++, 0, 0);
            blocks[blockcount] = temp;
            blockcount++;
        }
        
        {
            if (System.Math.Abs(blocks[current].transform.position.x - Camera.main.transform.position.x) > numberOfBlocks* increment/2 && numberOfBlocks <= blockcount)
            {

                if (current != 0)
                {
                    blocks[current].transform.position = blocks[current - 1].transform.position + new Vector3(2.5f, Random.Range(-1.0F, 1.0F), 0);
                }
                else
                {
                    blocks[current].tag = "Platform";
                    blocks[current].transform.position = blocks[numberOfBlocks-1].transform.position + new Vector3(2.5f, Random.Range(-1.0F, 1.0F), 0);
                    //if (Random.Range(-1.0F, 1.0F)>0)
                    {
                   
                       // rend = blocks[current].GetComponent<Renderer>();
                       if( blocks[current].tag.Equals("DeathBlock"))
                        {
                            //rend.material.color = new Color(0.5f, 1, 1);
                            blocks[current].transform.rotation.Set(70, 70, 0, 4);
                        } }
                }
                if (current >= numberOfBlocks - 1)
                {
                    current = -1;
                }
                current++;
            }
        }
        count++;

    }
}
