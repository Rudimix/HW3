using System;


namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания для проверки:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    MyStack s = new MyStack();
                    bool flag = true;
                    while (flag)
                    {
                        string[] input = Console.ReadLine().Split(' ');
                        string command = input[0];
                        if (command == "push")
                        {
                            int n = int.Parse(input[1]);
                            s.Push(n);
                            Console.WriteLine("ok");
                        }
                        else if (command == "pop")
                        {
                            if (s.Count > 0)
                            {
                                Console.WriteLine(s.Pop());
                            }
                            else
                            {
                                Console.WriteLine("Стек пустой, удалять нечего...");
                            }
                        }
                        else if (command == "back")
                        {
                            if (s.Count > 0)
                            {
                                Console.WriteLine(s.Back());
                            }
                            else
                            {
                                Console.WriteLine("Стек пустой...");
                            }
                        }
                        else if (command == "size")
                        {
                            Console.WriteLine(s.Count);
                        }
                        else if (command == "clear")
                        {
                            s.Clear();
                            Console.WriteLine("ok");
                        }
                        else if (command == "exit")
                        {
                            Console.WriteLine("bye");
                            flag = false;
                        }
                    }
                    break;
                case 2:
                    MyOrder o = new MyOrder();
                    flag = true;
                    while (flag)
                    {
                        string[] input = Console.ReadLine().Split(' ');
                        string command = input[0];
                        if (command == "push")
                        {
                            int n = int.Parse(input[1]);
                            o.Push(n);
                            Console.WriteLine("ok");
                        }
                        else if (command == "pop")
                        {
                            if (o.Count > 0)
                            {
                                Console.WriteLine(o.Pop());
                            }
                            else
                            {
                                Console.WriteLine("Стек пустой, удалять нечего...");
                            }
                        }
                        else if (command == "back")
                        {
                            if (o.Count > 0)
                            {
                                Console.WriteLine(o.Front());
                            }
                            else
                            {
                                Console.WriteLine("Стек пустой...");
                            }
                        }
                        else if (command == "size")
                        {
                            Console.WriteLine(o.Count);
                        }
                        else if (command == "clear")
                        {
                            o.Clear();
                            Console.WriteLine("ok");
                        }
                        else if (command == "exit")
                        {
                            Console.WriteLine("bye");
                            flag = false;
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите текст: ");
                    string text = Console.ReadLine();
                    int open = 0, close = 0;
                    bool error = false;
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] == '(')
                            open++;
                        if (text[i] == ')')
                            close++;
                        if (close > open)
                        {
                            Console.WriteLine("Скобки расставлены неправильно: лишняя закрывающая скобка на позиции {0}", i);
                            error = true;
                            break;
                        }
                    }
                    if (!error)
                    {
                        if (open > close)
                            Console.WriteLine("Скобки расставлены неправильно: количество лишних открывающих скобок - {0}", open - close);
                        else
                            Console.WriteLine("Скобки расставлены правильно");
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    MyDeque<int> deq = new MyDeque<int>();
                    deq.AddFront(1);
                    deq.AddFront(2);
                    deq.AddFront(3);
                    deq.Print();
                    Console.WriteLine("Удаляем первый элемент: " + deq.RemoveFront());
                    Console.WriteLine("Удаляем последний элемент: " + deq.RemoveBack());
                    deq.Print();
                    break;
            }
        }
    }
}
