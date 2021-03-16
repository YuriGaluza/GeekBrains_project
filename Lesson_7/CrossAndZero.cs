using System;

namespace Level_1.Lesson_7
{
    class CrossAndZero
    {
        private static int SIZE_WIN = 4; //кол-во заполненных подряд полей для победы
        private static int FiELD_SIZE = SIZE_WIN + 1;

        private char[,] field = new char[FiELD_SIZE, FiELD_SIZE];

        private char PLAYER_DOT = 'X';
        private char AI_DOT = 'O';
        private char EMPTY_DOT = '.';

        Random random = new Random();

        private void InitField()
        {
            for (int i = 0; i < FiELD_SIZE; i++)
            {
                for (int j = 0; j < FiELD_SIZE; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        private void PrintField()
        {
            Console.Clear();
            Console.WriteLine("-----------");
            for (int i = 0; i < FiELD_SIZE; i++)
            {
                Console.Write("|");
                for (int j = 0; j < FiELD_SIZE; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
        }

        private void SetSymbol(int y, int x, char symbol)
        {
            field[y, x] = symbol;
        }

        private bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > FiELD_SIZE - 1 || y > FiELD_SIZE - 1)
            {
                return false;
            }
            return field[y, x] == EMPTY_DOT;
        }

        private bool IsFieldFull()
        {
            for (int i = 0; i < FiELD_SIZE; i++)
            {
                for (int j = 0; j < FiELD_SIZE; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        //Ход человева
        private void PlayerMove()
        {
            int x, y;
            do
            {
                Console.WriteLine("Введите координаты вашего хода в диапазоне от 1 до " + FiELD_SIZE);
                Console.WriteLine("Координат по строке ");
                x = Int32.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Координат по столбцу ");
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSymbol(y, x, PLAYER_DOT);
        }
        //Ход компьютера
        private void AiMove()
        {
            int x, y;
            //блокировка ходов человека
            for (int v = 0; v < FiELD_SIZE; v++)
            {
                for (int h = 0; h < FiELD_SIZE; h++)
                {
                    //анализ наличия поля для проверки
                    if (h + SIZE_WIN <= FiELD_SIZE)
                    {                           //по горизонтали
                        if (CheckLineHorisont(v, h, PLAYER_DOT) == SIZE_WIN - 1)
                        {
                            if (MoveAiLineHorisont(v, h, AI_DOT)) return;
                        }

                        if (v - SIZE_WIN > -2)
                        {                            //вверх по диагонали
                            if (CheckDiaUp(v, h, PLAYER_DOT) == SIZE_WIN - 1)
                            {
                                if (MoveAiDiaUp(v, h, AI_DOT)) return;
                            }
                        }
                        if (v + SIZE_WIN <= FiELD_SIZE)
                        {                       //вниз по диагонали
                            if (CheckDiaDown(v, h, PLAYER_DOT) == SIZE_WIN - 1)
                            {
                                if (MoveAiDiaDown(v, h, AI_DOT)) return;
                            }
                        }
                    }
                    if (v + SIZE_WIN <= FiELD_SIZE)
                    {                       //по вертикали
                        if (CheckLineVertical(v, h, PLAYER_DOT) == SIZE_WIN - 1)
                        {
                            if (MoveAiLineVertical(v, h, AI_DOT)) return;
                        }
                    }
                }
            }
            //игра на победу
            for (int v = 0; v < FiELD_SIZE; v++)
            {
                for (int h = 0; h < FiELD_SIZE; h++)
                {
                    //анализ наличия поля для проверки
                    if (h + SIZE_WIN <= FiELD_SIZE)
                    {                           //по горизонтали
                        if (CheckLineHorisont(v, h, AI_DOT) == SIZE_WIN - 1)
                        {
                            if (MoveAiLineHorisont(v, h, AI_DOT)) return;
                        }

                        if (v - SIZE_WIN > -2)
                        {                            //вверх по диагонали
                            if (CheckDiaUp(v, h, AI_DOT) == SIZE_WIN - 1)
                            {
                                if (MoveAiDiaUp(v, h, AI_DOT)) return;
                            }
                        }
                        if (v + SIZE_WIN <= FiELD_SIZE)
                        {                       //вниз по диагонали
                            if (CheckDiaDown(v, h, AI_DOT) == SIZE_WIN - 1)
                            {
                                if (MoveAiDiaDown(v, h, AI_DOT)) return;
                            }
                        }
                    }
                    if (v + SIZE_WIN <= FiELD_SIZE)
                    {                       //по вертикали
                        if (CheckLineVertical(v, h, AI_DOT) == SIZE_WIN - 1)
                        {
                            if (MoveAiLineVertical(v, h, AI_DOT)) return;
                        }
                    }
                }
            }

            //случайный ход
            do
            {
                x = random.Next(0, FiELD_SIZE);
                y = random.Next(0, FiELD_SIZE);
            } while (!IsCellValid(y, x));
            SetSymbol(y, x, AI_DOT);
        }

        //ход компьютера по горизонтали
        private bool MoveAiLineHorisont(int v, int h, char dot)
        {
            for (int j = h; j < SIZE_WIN; j++)
            {
                if ((field[v, j] == EMPTY_DOT))
                {
                    field[v, j] = dot;
                    return true;
                }
            }
            return false;
        }

        //ход компьютера по вертикали
        private bool MoveAiLineVertical(int v, int h, char dot)
        {
            for (int i = v; i < SIZE_WIN; i++)
            {
                if ((field[i, h] == EMPTY_DOT))
                {
                    field[i, h] = dot;
                    return true;
                }
            }
            return false;
        }

        //проверка заполнения всей линии по диагонали вверх
        private bool MoveAiDiaUp(int v, int h, char dot)
        {
            for (int i = 0, j = 0; j < SIZE_WIN; i--, j++)
            {
                if ((field[v + i, h + j] == EMPTY_DOT))
                {
                    field[v + i, h + j] = dot;
                    return true;
                }
            }
            return false;
        }

        //проверка заполнения всей линии по диагонали вниз
        private bool MoveAiDiaDown(int v, int h, char dot)
        {
            for (int i = 0; i < SIZE_WIN; i++)
            {
                if ((field[i + v, i + h] == EMPTY_DOT))
                {
                    field[i + v, i + h] = dot;
                    return true;
                }
            }
            return false;
        }

        //проверка победы
        //2. Переделать проверку победы, чтобы она не была реализована просто набором условий,
        //например, с использованием циклов.
        private bool CheckWin(char dot)
        {
            for (int v = 0; v < FiELD_SIZE; v++)
            {
                for (int h = 0; h < FiELD_SIZE; h++)
                {
                    //анализ наличие поля для проверки
                    if (h + SIZE_WIN <= FiELD_SIZE)
                    {                           //по горизонтали
                        if (CheckLineHorisont(v, h, dot) >= SIZE_WIN) return true;

                        if (v - SIZE_WIN > -2)
                        {                            //вверх по диагонали
                            if (CheckDiaUp(v, h, dot) >= SIZE_WIN) return true;
                        }
                        if (v + SIZE_WIN <= FiELD_SIZE)
                        {                       //вниз по диагонали
                            if (CheckDiaDown(v, h, dot) >= SIZE_WIN) return true;
                        }
                    }
                    if (v + SIZE_WIN <= FiELD_SIZE)
                    {                       //по вертикали
                        if (CheckLineVertical(v, h, dot) >= SIZE_WIN) return true;
                    }
                }
            }
            return false;
        }

        //проверка заполнения всей линии по диагонали вверх
        private int CheckDiaUp(int v, int h, char dot)
        {
            int count = 0;
            for (int i = 0, j = 0; j < SIZE_WIN; i--, j++)
            {
                if ((field[v + i, h + j] == dot)) count++;
            }
            return count;
        }

        //проверка заполнения всей линии по диагонали вниз
        private int CheckDiaDown(int v, int h, char dot)
        {
            int count = 0;
            for (int i = 0; i < SIZE_WIN; i++)
            {
                if ((field[i + v, i + h] == dot)) count++;
            }
            return count;
        }

        private int CheckLineHorisont(int v, int h, char dot)
        {
            int count = 0;
            for (int j = h; j < SIZE_WIN + h; j++)
            {
                if (field[v, j] == dot) count++;
            }
            return count;
        }

        //проверка заполнения всей линии по вертикали
        private int CheckLineVertical(int v, int h, char dot)
        {
            int count = 0;
            for (int i = v; i < SIZE_WIN + v; i++)
            {
                if ((field[i, h] == dot)) count++;
            }
            return count;
        }

        public void StartGame()
        {
            InitField();
            PrintField();
            do
            {
                PlayerMove();
                Console.WriteLine("Ваш ход на поле");
                PrintField();
                if (CheckWin(PLAYER_DOT))
                {
                    Console.WriteLine("Вы выиграли");
                    break;
                }
                else if (IsFieldFull()) break;
                AiMove();
                Console.WriteLine("Ход Компа на поле");
                PrintField();
                if (CheckWin(AI_DOT))
                {
                    Console.WriteLine("Выиграли Комп");
                    break;
                }
                else if (IsFieldFull()) break;
            } while (true);
            Console.WriteLine("!Конец игры!");
        }
    }
}