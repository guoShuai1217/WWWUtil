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

public class Test : MonoBehaviour
{

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Game.Web.GetStringRequest("www.baidu.com", finish);
        }

        for (int i = 0; i < 10; i++)
        {
            byte[] tmp1 = new byte[10];
            Game.Web.PostByteRequest("www.baidu.com", tmp1, begin, progress, ff, error);
        }

        Game.Web.GetStringRequest("www.baidu.com", begin, progress, finish, error);


        byte[] tmp = new byte[10];
        Game.Web.PostStringRequest("www.baidu.com", tmp, begin, progress, finish, error);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(111);
            Game.Web.GetStringRequest("wwwunity3d.com", begin, progress, finish, error);
        }
    }

    void begin()
    {
        Debug.Log("Begin");
    }

    void progress(float progress)
    {
        Debug.Log(progress);
    }

    void finish(string www)
    {
        Debug.Log(www);
    }

    void ff(byte[] data)
    {
        Debug.Log(data);
    }

    void error(string reason)
    {
        Debug.LogError(reason);
    }
}