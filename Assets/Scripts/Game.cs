/*
 *		Description: 
 *
 *		CreatedBy: guoShuai
 *
 *		DataTime: #DATE#
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    public static WebManager Web
    {
        private set;
        get;
    }

    private void Awake()
    {
        Web = transform.Find("Web").GetComponent<WebManager>();
    }
 

}