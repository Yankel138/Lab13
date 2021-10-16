using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building build = new Building("Ялтинская 10", 10, 8, 69);
            build.Print();
            Console.ReadKey();
        }
    }

    class Building
    {
        string address;
        double length;
        double width;
        double height;

        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }

        public string Address
        {
            set 
            {
                this.address = value;
            }
            get
            {
                return address;

            }
        }
        
        public double Length
        {
            set
            {
                if (value >= 0)
                {
                    this.length = value;
                }
                else
                {
                    Console.WriteLine("Длина здания не может быть отрицательной");
                }
            }
            get
            {
                return length;
            }
        }

        public double Width
        {
            set
            {
                if (value >= 0)
                {
                    this.width = value;
                }
                else
                {
                    Console.WriteLine("Ширина здания не может быть отрицательной");
                }
            }
            get
            {
                return width;
            }
        }

        public double Height
        {
            set
            {
                if (value >= 0)
                {
                    this.height = value;
                }
                else
                {
                    Console.WriteLine("Высота здания не может быть отрицательной");
                }
            }
            get
            {
                return height;
            }
        }
        public void Print()
        {
        Console.WriteLine($"Информация о здании:\nАдрес:{address}\nДлина:{length}\nШирина:{width}\nВысота:{height}");
        }
    }

    sealed class MultiBuilding : Building
    {
        int level;

        public int Level
        {
            set
            {
                if (value > 0)
                {
                    this.level = value;
                }
                else
                {
                    Console.WriteLine("Этажность здания не может быть отрицательной");
                }
            }
            get
            {
                return level;
            }
        }

        public MultiBuilding(string address, double length, double width, double height, int level)
            : base(address, length, width, height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
            Level = level;
        }

    }
}
