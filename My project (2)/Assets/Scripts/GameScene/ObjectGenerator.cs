using TMPro;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject ArrowPrefab; //오브젝트 프리팹 등록
   
   
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            GameObject arrow = Instantiate(ArrowPrefab) as GameObject;
            arrow.GetComponent<ObjectShooter>().Shoot(new Vector3(0, 200, 2000));
                        
        }
    }



}