using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo
{
    /// <summary>
    /// �����ƶ�����Ľӿ�
    /// </summary>
    public interface IMovement
    {
        #region ����
        /// <summary>
        /// �ٶ�
        /// </summary>
        float Speed { get; set; }
        /// <summary>
        /// ���ٶ�
        /// </summary>
        float Accleration { get; set; }
        /// <summary>
        /// Ħ����
        /// </summary>
        float Friction { get; set; }

        #endregion
        /// <summary>
        /// �õ���ǰ���ٶ�
        /// </summary>
        /// <returns></returns>
        Vector2 GetVelocity();

        /// <summary>
        /// �õ���ǰ�ķ��� ��һ������
        /// </summary>
        /// <returns></returns>
        Vector2 GetDirection();
    }

    /// <summary>
    /// ��ɫ�Ļ��� �����ڿɲٿؽ�ɫ
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
