using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo
{
    /// <summary>
    /// 所有移动物体的接口
    /// </summary>
    public interface IMovement
    {
        #region 属性
        /// <summary>
        /// 速度
        /// </summary>
        float Speed { get; set; }
        /// <summary>
        /// 加速度
        /// </summary>
        float Accleration { get; set; }
        /// <summary>
        /// 摩擦力
        /// </summary>
        float Friction { get; set; }

        #endregion
        /// <summary>
        /// 得到当前的速度
        /// </summary>
        /// <returns></returns>
        Vector2 GetVelocity();

        /// <summary>
        /// 得到当前的方向 归一化过的
        /// </summary>
        /// <returns></returns>
        Vector2 GetDirection();
    }

    /// <summary>
    /// 角色的基类 仅限于可操控角色
    /// </summary>
    public class RoleObject : IMovement
    {
        public float Speed { get; set; }
        public float Accleration { get; set; }
        public float Friction { get; set; }

        public Vector2 GetDirection()
        {
            return GetVelocity().normalized;
        }

        public Vector2 GetVelocity()
        {
            return Vector2.zero; //todo
        }
    }
}
