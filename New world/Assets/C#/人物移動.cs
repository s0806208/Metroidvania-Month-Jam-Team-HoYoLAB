using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f; // 控制移动速度

    private Vector3 movement; // 存储移动方向的变量
    private Rigidbody rb; // 用于角色的刚体物理

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // 获取角色的Rigidbody组件
    }

    // Update is called once per frame
    void Update()
    {
        // 获取WASD键的输入
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // 设置移动方向
        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    }
    void FixedUpdate()
    {
        // 物理运动，每帧更新位置
        MoveCharacter();
    }

    void MoveCharacter()
    {
        // 移动角色（注意使用Time.deltaTime确保每帧移动的距离一致）
        rb.MovePosition(transform.position + movement * speed * Time.deltaTime);
    }
}
