using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserProjectile : MonoBehaviour
{
    [SerializeField] private GameObject _laser;
    //[SerializeField] private float timeForShot = 3f;
    private float timer = 0;


    private void Update()
    {
        timer += Time.deltaTime;
        _laser.transform.localScale = new Vector3();
    }

}
