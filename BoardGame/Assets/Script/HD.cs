using UnityEngine;

namespace HD
{
    public static class HD
    {
        #region Color
        public static Color ChangeAlpha(this Color color, float alpha)
        {
            Color newColor = new Color(color.r, color.g, color.b, alpha);

            return newColor;
        }
        #endregion

        public static Quaternion ChangeY(this Quaternion rotation, float eulerY)
        {
            Quaternion newQuaternion = Quaternion.Euler(rotation.eulerAngles.x,
                                                        eulerY,
                                                        rotation.eulerAngles.z);

            return newQuaternion;
        }

        public static Quaternion ChangeZ(this Quaternion rotation, float eulerZ)
        {
            Quaternion newQuaternion = Quaternion.Euler(rotation.eulerAngles.x,
                                                        rotation.eulerAngles.y,
                                                        eulerZ);

            return newQuaternion;
        }

        public static Vector3 ChangeY(this Vector3 position, float posY)
        {
            Vector3 newVector = new Vector3(position.x,
                                            posY,
                                            position.z);

            return newVector;
        }

        public static Vector3 SumY(this Vector3 position, float value)
        {
            Vector3 newVector = new Vector3(position.x,
                                            position.y + value,
                                            position.z);

            return newVector;
        }
    }
}