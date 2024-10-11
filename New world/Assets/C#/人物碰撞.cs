using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 人物碰撞 : MonoBehaviour
{
    // 当玩家进入触发区域时调用
    private void OnTriggerEnter(Collider other)
    {
        // 检测是否进入的对象是触发器，并且其标签为 "TriggerZone"
        if (other.CompareTag("TriggerZone"))
        {
            // 旋转Player对象Y轴方向加90度
            RotatePlayer();
        }
    }

    // 旋转Player的方法
    void RotatePlayer()
    {
        // 旋转Y轴增加90度
        transform.Rotate(0, 90, 0);
        Debug.Log("Player has rotated 90 degrees on the Y-axis");
    }
}
