using System.Collections.Generic;
using System.Xml.Linq;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*IntArrayList list = new IntArrayList();
            list.Add(1);
            list.Add(12);
            list.Add(13);
            list.Add(25);
            list.Add(32);
            list.Add(0);
            //list.GetElements();
            Console.WriteLine(list);*/
            /*StringArrayList strs=new StringArrayList();
            strs.Add("Salam");
            strs.Add("Aleykum");
            strs.GetElements();
            ObjectArrayList objs = new ObjectArrayList(typeof(Int32));
            objs.Add(12);
            *//*objs.Add(true);
            objs.Add("Salam");*//*
             objs.GetElements(); */
            GenericList<Student> intArr = new GenericList<Student>();
            intArr.Add(new Student);
            {
                Name = "Nurlan";
                Surname = "Abbasov";

            }
            intArr.Add(new Student);
            {
                Name = "ali";
                Surname = "qurbanov";
            }
        }
    }
    class Student
    {
        public string Name { get; set};
        public string Surname {  get; set; }

        public override string ToString()
        {
          return Name+  " " + Surname
        }
        class GenericList<Garib>
    {
        Object[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        public GenericList()
        {
            
            _arr = new Garib[Capacity];
        }
        public GenericList(int capacity)
        {
            Capacity = capacity;
            _arr = new Garib[Capacity];
            
        public void Add(Garib value)
        {
            if (value.GetType().Name == _listType.Name)
            {
                if (_arr.Length == Count)
                {
                    Array.Resize(ref _arr, Count + Capacity);
                }
                Count++;
                _arr[Count] = value;
            }
            else
            {
                throw new ArrayTypeMismatchException();
            }
        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
    class IntArrayList
    {
        int[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        public IntArrayList()
        {
            
            _arr = new int[Capacity];
        }
        public IntArrayList(int capacity)
        {
            Capacity = capacity;
            _arr = new int[Capacity];
        }
        public void Add(int value) 
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            Count++;
            _arr[Count] = value;
           
        }
        public void GetElements()
        {
            for(int i= 0;i< Count;i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
    class ObjectArrayList
    {
        Object[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        public ObjectArrayList(Type listType)
        {
            _listType = listType;
            _arr = new object [Capacity];
        }
        public ObjectArrayList(int capacity, Type listType)
        {
            Capacity = capacity;
            _arr = new Object[Capacity];
            _listType = listType;
        }
        public void Add(Object value) 
        {
            if (value.GetType().Name == _listType.Name)
            {
                if (_arr.Length == Count)
                {
                    Array.Resize(ref _arr, Count + Capacity);
                }
                Count++;
                _arr[Count] = value;
            }
            else
            { 
              throw new ArrayTypeMismatchException();
            }
        }
        public void GetElements()
        {
            for(int i= 0;i< Count;i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
    class StringArrayList
    {
        string[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        public StringArrayList()
        {
            
            _arr = new string[Capacity];
        }
        public StringArrayList(int capacity)
        {
            Capacity = capacity;
            _arr = new string[Capacity];
        }
        public void Add(string value) 
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            Count++;
            _arr[Count] = value;
           
        }
        public void GetElements()
        {
            for(int i= 0;i< Count;i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
}
