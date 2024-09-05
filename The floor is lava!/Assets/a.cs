using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{   
    public Vector3 positionChange;
    public Vector3 scaleChange;
    public Vector3 rotateChange;
    public float duration = 5f;  // 持续时间5秒
    private float timer = 0f;    // 计时器
    private bool isMoving = true; // 控制球的移动和旋转

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            // 累积时间
            timer += Time.deltaTime;

            // 进行位置、缩放和旋转的变换
            transform.localScale += scaleChange;
            transform.position += positionChange;
            transform.Rotate(rotateChange * Time.deltaTime);

            // 当时间达到持续时间时停止变换
            if (timer >= duration)
            {
                isMoving = false;
            }
        }
    }
}
