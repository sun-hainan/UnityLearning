using UnityEngine;

/// <summary>
/// 相机跟随脚本
/// 功能：让相机平滑跟随玩家
/// </summary>
public class CameraFollow : MonoBehaviour
{
    [Header("目标设置")]
    public Transform target;
    
    [Header("跟随设置")]
    public float smoothSpeed = 0.125f;
    public Vector3 offset = new Vector3(0, 10, -10);
    
    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("⚠️ 相机没有设置跟随目标！");
            return;
        }
        
        // 计算目标位置
        Vector3 desiredPosition = target.position + offset;
        
        // 平滑移动
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
        // 更新相机位置
        transform.position = smoothedPosition;
        
        // 让相机看向目标
        transform.LookAt(target);
    }
}
