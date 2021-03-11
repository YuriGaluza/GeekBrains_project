using System;

namespace Level_1.Lesson_6
{
    public class MyArraySizeException : Exception
    {
        public MyArraySizeException(string message)
            : base(message)
        { }
    }
}