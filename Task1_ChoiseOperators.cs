using System;

namespace SP3C_EVMbz18_1_ChalovAL_zkXX42_v6_Task1_ChoiseOperators
{
    class Program
    {
        // Зададим константу "корень из 2", т.к. она используется во всех выражениях
        static readonly Double sqrt2 = Math.Sqrt(2);

        static void Main(string[] args)
        {
            // Начало программы. Инициализация переменных.
            Int32 TaskNum = 0;
            Double LegA = 0.0d, HypotenuseC = 0.0d, HeightH = 0.0d, AreaS = 0.0d;


            // Ввод значений
            while (true)
            {
                Console.WriteLine("Введите номер известного элемента равностроеннего прямоугольного треугольника (1 - 4):\n" +
                    "1. Катет - a \n" +
                    "2. Гипотенуза - c \n" +
                    "3. Высота - h\n" +
                    "4. Площадь - S\n" +
                    "Ваше значение:"
                    );
                TaskNum = Convert.ToInt32(Console.ReadLine());

                // Проверка корректности вводимого значения
                if (TaskNum >= 1 && TaskNum <= 4) break;
                Console.WriteLine("Пожалуйста, введите корректное значение от 1, 2, 3 или 4");
            }

            // Вычисление значений элементов треугольника.
            switch (TaskNum)
            {
                case 1: // По известному катету
                    {
                        while (true)
                        {
                            Console.WriteLine("Введите длину катета a и нажмите Enter\n" +
                                "Ваше значение катета: ");
                            String Input = Console.ReadLine();
                            LegA = Double.Parse(Input, System.Globalization.CultureInfo.InvariantCulture);

                            // Проверка корректности вводимого значения
                            if (LegA > 0 && LegA <= 1.3e154d && LegA >= 1.3e-154d) break;
                            Console.WriteLine("Пожалуйста, введите корректное значение величины катета\n" +
                                "от 1.3E-154 до 1.3E154 и не равное 0.");
                        }

                        HypotenuseC = sqrt2 * LegA;
                        Console.WriteLine("Гипотенуза c равна " + OutputValue(HypotenuseC));

                        HeightH = (sqrt2 / 2) * LegA;
                        Console.WriteLine("Высота h равна " + OutputValue(HeightH));

                        AreaS = (LegA * LegA) / 2;
                        Console.WriteLine("Площадь S равна " + OutputValue(AreaS));

                    }
                    break;

                case 2: // По известной гипотенузе
                    {
                        while (true)
                        {
                            Console.WriteLine("Введите длину гипотенузы с и нажмите Enter\n" +
                                "Ваше значение гипотенузы: ");
                            String Input = Console.ReadLine();
                            HypotenuseC = Double.Parse(Input, System.Globalization.CultureInfo.InvariantCulture);

                            // Проверка корректности вводимого значения
                            if (HypotenuseC > 0 && HypotenuseC <= 1.3e154d && HypotenuseC >= 1.3e-154d) break;
                            Console.WriteLine("Пожалуйста, введите корректное значение величины гипотенузы\n" +
                                "от 1.3E-154 до 1.3E154 и не равное 0.");
                        }

                        LegA = HypotenuseC / sqrt2;
                        Console.WriteLine("Катет a равен " + OutputValue(LegA));

                        HeightH = HypotenuseC / 2;
                        Console.WriteLine("Высота h равна " + OutputValue(HeightH));

                        AreaS = HypotenuseC * HypotenuseC / 4;
                        Console.WriteLine("Площадь S равна " + OutputValue(AreaS));

                    }
                    break;

                case 3: // По известной высоте
                    {
                        while (true)
                        {
                            Console.WriteLine("Введите длину высоты h и нажмите Enter\n" +
                                "Ваше значение высоты: ");
                            String Input = Console.ReadLine();
                            HeightH = Double.Parse(Input, System.Globalization.CultureInfo.InvariantCulture);

                            // Проверка корректности вводимого значения
                            if (HeightH > 0 && HeightH <= 1.3e154d && HeightH >= 1.3e-154d) break;
                            Console.WriteLine("Пожалуйста, введите корректное значение величины высоты\n" +
                                "от 1.3E-154 до 1.3E154 и не равное 0.");
                        }

                        LegA = HeightH * 2 / sqrt2;
                        Console.WriteLine("Катет a равен " + OutputValue(LegA));

                        HypotenuseC = HeightH * 2;
                        Console.WriteLine("Гипотенуза c равна " + OutputValue(HypotenuseC));

                        AreaS = HeightH * HeightH;
                        Console.WriteLine("Площадь S равна " + OutputValue(AreaS));

                    }
                    break;

                case 4: // По известной площади
                    {
                        while (true)
                        {
                            Console.WriteLine("Введите площадь S и нажмите Enter\n" +
                                "Ваше значение площади: ");
                            String Input = Console.ReadLine();
                            AreaS = Double.Parse(Input, System.Globalization.CultureInfo.InvariantCulture);

                            // Проверка корректности вводимого значения
                            if (AreaS > 0 && AreaS <= 4.25e307d && AreaS >= 4.25e-307d) break;
                            Console.WriteLine("Пожалуйста, введите корректное значение величины площади\n" +
                                "от 4.25E-307 до 4.25E307 и не равное 0.");
                        }

                        LegA = Math.Sqrt(AreaS * 2);
                        Console.WriteLine("Катет a равен " + OutputValue(LegA));

                        HypotenuseC = Math.Sqrt(AreaS * 4);
                        Console.WriteLine("Гипотенуза c равна " + OutputValue(HypotenuseC));

                        HeightH = Math.Sqrt(AreaS);
                        Console.WriteLine("Высота h равна " + OutputValue(HeightH));

                    }
                    break;


                default:
                    {
                        Console.WriteLine("Необходимо ввести правильный номер - 1, 2 или 3");
                        Console.WriteLine("Завершите программу и повторите её выполнение снова");
                    }
                    break;
            }
            Console.WriteLine("Нажмите любую клавишу для завершения программы");
            Console.ReadKey();

        }


        // Форматирующая вывод функция
        private static String OutputValue(Double Input)
        {
            if (Input >= 0.0001 && Input <= 10000.0)
            {
                if (Math.Abs(Math.Round(Input, 2) - Math.Round(Input, 0)) < 0.005)
                {
                    return string.Format("{0:F0}", Input);
                }
                else
                {
                    return string.Format("{0:F2}", Input);
                }
            }
            else
            {
                return (string.Format("{0:0.##E+00}", Input));

            }

        }
    }

}