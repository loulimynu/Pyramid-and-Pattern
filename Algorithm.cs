using System;

namespace ConsoleApp2
{
    class Algorithm
    {
        static void Main(string[] args)
        {
            int chose, n = 10, num;

            while (true)
            {
                Console.WriteLine("[1] - Meia piramide\n[2] - Meia piramide inversa" +
                    "\n[3] - Piramide\n[4] - Piramede númerica inversa\n[5] - Meia piramide espelho\n[6] - Meia piramede numerica" +
                    "\n[7] - Piramide padrão númerico\n[0] - Exit");
                escolha = int.Parse(Console.ReadLine());

                switch (chose)
                {
                    case 1:
                        {
                            Console.Out.WriteLine();
                            for (int i = 0; i < n; i++)
                            {
                                for (int a = 0; a <= i; a++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.Out.WriteLine();
                            for (int i = 0; i < n; i++)
                            {

                                for (int a = 2 * (n - i); a >= 0; a--)
                                {
                                    Console.Write(" ");
                                }
                                for (int a = 0; a <= i; a++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Out.WriteLine();
                            for (int i = 0; i < n; i++)
                            {
                                for(int a = (n - i); a > 1; a--)
                                {
                                    Console.Write(" ");
                                }
                                for (int a = 0; a <= i; a++)
                                {
                                    Console.Write("* ");
                                }
                                Console.Out.WriteLine();
                            }
                        }
                        break;
                    case 4:
                        {
                            n = 6;

                            Console.Out.WriteLine();
                            for (int i = 1; i <= n; i++)
                            {
                                for(int a = 1; a < i; a++)
                                {
                                    Console.Write(" ");
                                }
                                for(int a = i; a <= n; a++)
                                {
                                    Console.Write(a + " ");
                                }
                                Console.Out.WriteLine();
                            }
                        }
                        break;
                    case 5:
                        {
                            n = 7;

                            Console.Out.WriteLine();
                            for (int i = 1; i <= n; i++)
                            {
                                for (int a = 1; a < i; a++)
                                {
                                    Console.Write(" ");
                                }
                                for (int a = i; a <= n; a++)
                                {
                                    Console.Write(a + " ");
                                }
                                Console.Out.WriteLine();
                            }
                            for (int i = n - 1; i >= 1; i--)
                        {
                                for (int a = 1; a < i; a++)
                                {
                                    Console.Write(" ");
                                }
                                for (int j = i; j <= n; j++)
                                {
                                    Console.Write(j + " ");
                                }
                                Console.Out.WriteLine();
                            }
                        }
                        break;
                    case 6:
                        {
                            Console.Out.WriteLine();
                            for (int i = 0; i < n; i++)
                            {
                                num = 1;
                                for (int a = 0; a <= i; a++)
                                {
                                    Console.Write(num + " ");
                                    num++;
                                }
                                Console.Out.WriteLine();
                            }
                        }
                        break;
                    case 7:
                        {
                            num = 1;

                            Console.Out.WriteLine();
                            for (int i = 0; i < n; i++)
                            {
                                for (int a = 0; a <= i; a++)
                                {
                                    Console.Write(num + " ");
                                    num = (num + 1);
                                }
                                Console.Out.WriteLine();
                            }
                        }
                        break;
                    case 0:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        {
                            Console.Out.WriteLine();
                            Console.Write("Valor invalido\n ");
                        }
                        break;
                }
            }
        }
   }
}
