using System;
using System.Collections.Generic;

namespace B3
{
    // Delegate for menu selection event
    public delegate void MenuSelectEventHandler(int choice);

    // Generic Console Menu class
    public class ConsoleMenu
    {
        // Khởi tạo Field
        protected string title;
        protected List<string> items;

        // Khởi tạo Event hỗ trợ mở rộng
        public event MenuSelectEventHandler? Choose;

        // Khởi tạo Default Constructor
        public ConsoleMenu()
        {
            title = "Menu";
            items = new List<string>();
        }

        // Khởi tạo Constructor có tham số
        public ConsoleMenu(string title)
        {
            this.title = title;
            items = new List<string>();
        }

        // Khởi tạo Methods
        public void AddItem(string item)
        {
            items.Add(item);
        }

        public virtual void Display()
        {
            Console.WriteLine($"\n{title}");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]}");
            }
            Console.WriteLine("0. Exit program\n");
        }

        public virtual void Execute(int choice)
        {
            Choose?.Invoke(choice);
        }

        public void Run()
        {
            int choice = -1;
            do
            {
                Display();
                Console.Write("Action: ");
                int.TryParse(Console.ReadLine(), out choice);

                if (choice == 0)
                {
                    Console.WriteLine("Exit program successfully.");
                    break;
                }

                if (choice > 0 && choice <= items.Count)
                {
                    Console.WriteLine($"You executed action {choice}\n");
                    Execute(choice);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please input again!\n");
                }
            } while (choice != 0);
        }
    }

    // Đổi tên lớp thành Array1D_B3_4 kế thừa ConsoleMenu
    public class Array1D_B3_4 : ConsoleMenu
    {
        // Khởi tạo Field
        private double a;
        private double b;
        private double c;
        private bool hasInput;

        // Khởi tạo Default Constructor
        public Array1D_B3_4() : base("Menu")
        {
            a = 0;
            b = 0;
            c = 0;
            hasInput = false;

            AddItem("Input coefficients a, b, c");
            AddItem("Solve quadratic equation");
        }

        // Khởi tạo Constructor có tham số
        public Array1D_B3_4(double a, double b, double c) : base("Menu")
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.hasInput = true;

            AddItem("Input coefficients a, b, c");
            AddItem("Solve quadratic equation");
        }

        // Khởi tạo Methods
        public void Input()
        {
            Console.Write("Input coefficient a = ");
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("Input coefficient b = ");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("Input coefficient c = ");
            double.TryParse(Console.ReadLine(), out c);

            hasInput = true;
            Console.WriteLine($"Equation: {a}x^2 + {b}x + {c} = 0\n");
        }

        public void Output()
        {
            if (!hasInput)
            {
                Console.WriteLine("Please input coefficients first!\n");
                return;
            }

            Console.WriteLine($"Solving equation: {a}x^2 + {b}x + {c} = 0");

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0) Console.WriteLine("The equation has infinitely many solutions.\n");
                    else Console.WriteLine("The equation has no solution.\n");
                }
                else
                {
                    Console.WriteLine($"Linear equation root: x = {-c / b}\n");
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("The equation has no real roots.\n");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"The equation has a double root: x1 = x2 = {x}\n");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"The equation has two distinct roots: x1 = {x1}, x2 = {x2}\n");
                }
            }
        }

        // Ghi đè phương thức Execute
        public override void Execute(int choice)
        {
            base.Execute(choice); // Kích hoạt sự kiện Choose nếu có

            if (choice == 1)
            {
                Input();
            }
            else if (choice == 2)
            {
                Output();
            }
        }

        public void MainB3()
        {
            Run();
        }
    }
}