using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuaternionDemo : MonoBehaviour
{
    [Header("物体引用")]
    public GameObject cubeEuler;    //欧拉角方块
    public GameObject cubeQuat;     //四元数方块

    [Header("UI控件")]
    public Slider sliderX;
    public Slider sliderY;
    public TextMeshProUGUI textEuler;
    public TextMeshProUGUI textQuat;

    private float rotX;
    private float rotY;

    void Update()
    {
        //读取滑块角度
        rotX = sliderX.value;
        rotY = sliderY.value;

        // ========== 左侧：欧拉角旋转 ==========
        Vector3 eulerAng = new Vector3(rotX, rotY, 0);
        cubeEuler.transform.eulerAngles = eulerAng;

        // ========== 右侧：四元数旋转 ==========
        //把欧拉角转换成四元数进行赋值
        Quaternion q = Quaternion.Euler(rotX, rotY, 0);
        cubeQuat.transform.rotation = q;

        // ========== 更新UI文字 ==========
        textEuler.text = $"Text_EulerInfo\nEuler：{eulerAng:F2}";
        textQuat.text = $"Text_QuatInfo\nQuaternion\nx:{q.x:F3} y:{q.y:F3} z:{q.z:F3} w:{q.w:F3}";
    }
}
