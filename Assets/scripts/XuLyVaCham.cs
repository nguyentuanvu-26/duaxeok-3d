
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XuLyVaCham : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CheckPoint")
        {
            GameManager.instance.quaCheckPoin();
        }

        if (other.gameObject.tag == ("WINpoint"))
        {
            GameManager.instance.quawinpoint();
        }
    }
}
