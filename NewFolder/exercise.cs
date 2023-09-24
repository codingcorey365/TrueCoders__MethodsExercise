using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise.NewFolder
{
    internal class exercise
    {
        //-----Exercise 1------
        //---------------------

        public static void ExerciseOne()
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Hi, What is your first name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, what is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
            string band = Console.ReadLine();
            
            Console.WriteLine("\r\n\r\nNow will all of these answers, I will write you a story. Please give me you kind feedback. Enjoy!\r\n\r\n");

            Console.WriteLine($"Once upon a time in a quaint little village, there lived a girl named {name}. {name} was known throughout the land for her vibrant {color} cloak, a hue so vivid it could brighten even the gloomiest of days.\r\n\r\nOne peaceful afternoon, while {name} was wandering through the lush meadows outside the village, she stumbled upon a mysterious, injured {animal}. Its fur was soft, and its eyes filled with a palpable sadness. With tender care, {name} nursed the creature back to health, feeding it fresh berries and clean water from the sparkling stream nearby.\r\n\r\nIn the magical embrace of the wild, under the sun's warm rays, a bond was forged between {name} and the {animal}. They spent their days exploring the stunning landscapes, playing amidst the blooming wildflowers, and laying under the starlit sky sharing dreams of exciting adventures.\r\n\r\nOne starry night, while {name} and the {animal} were nestled under the velvety sky, the soft sound of music wafted through the air. It was {band}, the famous group known for their ethereal melodies, playing in the village square. The harmonious strains of music, carried by the breeze, gently enveloped them, intertwining with the sweet scent of the meadow's flowers.\r\n\r\nAs {name} listened, her heart swelled with the purest joy, her soul dancing alongside the notes. The {animal} seemed entranced as well, its eyes filled with the light of a thousand stars. They made their way to the village, the melody leading them through the winding paths.\r\n\r\nArriving at the village square, {name} and the {animal} were greeted by the jubilant faces of the villagers, all gathered to relish the music of {band}. Bathed in the gentle glow of the moonlight, {name} and the {animal} danced amidst the crowd, their spirits soaring on the wings of the melodious tunes.\r\n\r\nThe delightful night wore on, a harmonious blend of laughter, music, and dance. As the first light of dawn began to brush the horizon with strokes of pinks and golds, {name} and the {animal} bade farewell to the villagers and {band}.\r\n\r\nAs they ventured back to the meadow, the memories of the enchanted night warmed their hearts, the sweet music of {band} forever etched in their souls. They continued their journey, exploring the boundless beauty of the world together, their spirits forever intertwined under the vast expanse of the celestial tapestry.\r\n\r\nAnd thus, in the embrace of the wild, with the {animal} by her side and the echo of {band}’s music in her heart, {name} found the boundless joy of friendship and adventure, a radiant beacon of {color} illuminating her path through the tapestry of life.");



        }

        //-----Exercise 2------
        //---------------------

        //  +   Addition Adds together two values x + y	
        //  -   Subtraction Subtracts one value from another    x - y
        //  *   Multiplication  Multiplies two values x * y	
        //  /   Division Divides one value by another    x / y	
        //  %   Modulus Returns the division remainder x % y	
        //  ++  Increment Increases the value of a variable by 1	x++	
        //  --  Decrement Decreases the value of a variable by 1	x--

        //Sum(2,4) would return 6
        //Sum(2,4,6) would return 12.
        //Sum(1,1,1,1,1) would return 5.

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public static int Add(int num1, int num2, int num3, int num4, int num5)
        {
            return num1 + num2 + num3 + num4 + num5;
        }



        //  -   Subtraction Subtracts one value from another    x - y
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Subtrac(int num1, int num2, int num3)
        {
            return num1 - num2 - num3;
        }

        //  *   Multiplication  Multiplies two values x * y	
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        //  /   Division Divides one value by another    x / y	
        public static int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Division(int num1, int num2, int num3)
        {
            return num1 / num2 / num3;
        }

        //  %   Modulus Returns the division remainder x % y
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
        public static int Modulus(int num1, int num2, int num3)
        {
            return num1 % num2 % num3;
        }

        //  ++  Increment Increases the value of a variable by 1	x++	
        public static int Increment(int num1)
        {
            return num1++;
        }

        // --  Decrement Decreases the value of a variable by 1	x--
        public static int Decrement(int num1)
        {
            return num1--;
        }
    }

}
