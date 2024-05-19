using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using _1._19_Tilemaps_.screens;

namespace _1._19_Tilemaps_.utility
{
    class VectorMath
    {
        /// <summary>
        /// Diese Funktion konvertiert einen Winkel in Grad zu einem Winkel in Bogenmaß
        /// </summary>
        /// <param name="degree">Winkel in Grad</param>
        /// <returns>Winkel in Bogenmaß</returns>
        public static float degToRad(float degree)
        {
            float rad = degree * (float)Math.PI / 180;

            return rad;
        }

        /// <summary>
        /// Diese Funktion konvertiert einen Winkel in Bogenmaß zu einem Winkel in Grad
        /// </summary>
        /// <param name="degree">Winkel in Bogenmaß</param>
        /// <returns>Winkel in Grad</returns>
        public static float radToDeg(float rad)
        {
            float degree = rad * 180 / (float)Math.PI;

            return degree;
        }

        /// <summary>
        /// Berechnet den sinus auf basis eines winkels in grad
        /// </summary>
        /// <param name="angle">Winkel in grad</param>
        /// <returns>Sinus des Winkels</returns>
        public static float Sin(float angle)
        {
            return (float)Math.Sin(degToRad(angle));
        }

        /// <summary>
        /// Berechnet den cosinus auf basis eines winkels in grad
        /// </summary>
        /// <param name="angle">Winkel in grad</param>
        /// <returns>cosinus des Winkels</returns>
        public static float Cos(float angle)
        {
            return (float)Math.Cos(degToRad(angle));
        }

        /// <summary>
        /// Berechnet den tangens auf basis eines winkels in grad
        /// </summary>
        /// <param name="angle">Winkel in grad</param>
        /// <returns>tangens des Winkels</returns>
        public static float Tan(float angle)
        {
            return (float)Math.Tan(degToRad(angle));
        }


        /// <summary>
        /// Die Distanz Funktion gibt die Entfernung von zwei Positionen als Floatwert zurück.</summary>
        /// <param name="A"> RectangleShape, CircleShape oder Sprite</param>
        /// <param name="B"> weiteres RectangleShape, CircleShape oder Sprite</param>
        public static float distance(Vector2f A, Vector2f B)
        {
            Vector2f diff = A - B;

            return lengthOfVector(diff);
        }


        /// <summary>
        /// Gibt die Länge(in Pixeln) eines Vektors als float zurück</summary>
        /// <param name="vector"> Vektor, dessen Länge man wissen will</param>
        public static float lengthOfVector(Vector2f vector)
        {
            return (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }

        /// <summary>
        /// Gibt den Einheitsvektor(oder Richtungsvektor) eines Vektoren zurück</summary>
        /// <param name="vector"> Vektor, dessen Einheitsvektor man wissen will</param>
        public static Vector2f getUnitVector(Vector2f vector)
        {
            float length = lengthOfVector(vector);
            if (length == 0.0f) return new Vector2f(0, 0);
            Vector2f unit = new Vector2f(vector.X / length,
                                         vector.Y / length);
            return unit;
        }

        /// <summary>
        /// Gibt den Einheitsvektor(oder Richtungsvektor) eines Winkels zurück</summary>
        /// <param name="angle"> Winkel aus dem der Einheitsvektor generiert wird</param>
        public static Vector2f getUnitVector(float angle)
        {

            Vector2f unit = new Vector2f(Cos(angle),
                                         Sin(angle));
            return unit;
        }


        /// <summary>
        /// Gibt die Richtung eines Vektors als Winkel(in Grad) durch einen float zurück.
        /// <para />Dabei zeigt 0° nach rechts und der positive Drehsinn ist mit dem Uhrzeigersinn.</summary>
        /// <param name="vector"> Vektor, dessen Winkel man wissen will</param>
        public static float getAngle(Vector2f vector)
        {
            float angle = radToDeg((float)Math.Atan2(vector.Y, vector.X));
            return angle;
        }

        /// <summary>
        /// Dreht einen Vector um eine angegebene Gradzahl(in Grad). Positiver Drehsinn ist in mit dem Uhrzeigersinn
        /// </summary>
        /// <param name="vector">Vector der gedreht wird</param>
        /// <param name="angle">Winkel in Grad um die gedreht werden soll</param>
        /// <returns>Den gedrehten Vector</returns>
        public static Vector2f rotateVectorByAngle(Vector2f vector, float angle)
        {
            float length = lengthOfVector(vector);
            float alpha = getAngle(vector) + angle;
            Vector2f result = new Vector2f(Cos(alpha) * length, Sin(alpha) * length);

            return result;
        }
    }
}
