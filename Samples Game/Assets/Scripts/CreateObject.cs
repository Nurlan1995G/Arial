using System.Collections;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject[] obj;

    private void Update()
    {
        //Invoke("Create", 2f);     //время через сколько будет запускаться наш метод Create
        if (Input.GetKeyUp(KeyCode.U))
           StartCoroutine(Create3D(2f));
    }

    private void Create()
    {
        for (int i = 0; i < 5; i++)
        {
            //GameObject onObj = Instantiate(obj, new Vector3(0, 5, 0), Quaternion.Euler(12f, -15f, 40f)) as GameObject;
            //onObj.GetComponent<Transform>().position = new Vector3(4, 4, 0);
            Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(RandomNum(), RandomNum(), RandomNum()), Quaternion.Euler(12f, -15f, 40f)) ;

        }

    }

    private int RandomNum()
    {
        return Random.Range(0, 10);
    }

    IEnumerator Create3D(float wait)
    {
        while (true)
        {
            Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(RandomNum(), RandomNum(), RandomNum()), Quaternion.Euler(12f, -15f, 40f));
            yield return new WaitForSeconds(wait);
        }
    }


}
