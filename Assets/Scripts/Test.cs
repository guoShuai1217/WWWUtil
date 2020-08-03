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
            WWWUtil.Instance.GetRequest("www.baidu.com", begin, progress, finish, error);
        }

        for (int i = 0; i < 10; i++)
        {
            byte[] tmp1 = new byte[10];
            WWWUtil.Instance.PostRequest("www.baidu.com", tmp1, begin, progress, ff, error);
        }

        WWWUtil.Instance.GetRequest("www.baidu.com", begin, progress, ff, error);


        byte[] tmp = new byte[10];
        WWWUtil.Instance.PostRequest("www.baidu.com", tmp, begin, progress, finish, error);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(111);
            WWWUtil.Instance.GetRequest("wwwunity3d.com", begin, progress, finish, error);
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