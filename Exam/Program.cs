using System;

namespace Ex_2 
{
    interface Lamp
    {
        string typel();
        string producerlamp();
        string power { get; }
        string viewl();
        string number { get; }

        void Printlamp();
    }
    interface Camera
    {
        string typecamera();
        string producercamera();
        string lightsensitivity { get; }
        void Printcamera();
    }
    class PhotoStudio : Lamp, Camera
    {
        protected int p { get; set; }
        protected int k { get; set; }
        protected int l { get; set; }
        public PhotoStudio(int p, int k, int l)
        {
            this.p = p;
            this.k = k;
            this.l = l;
        }

        public string typel()
        {
            return "Type lamp: E40";
        }
        public string producerlamp()
        {
            return "Producer lamp: China";
        }
        public string power
        {
            get
            {
                return $"Power in lumen:{p} ";
            }
        }
        public string viewl()
        {
            return "View: Luminescent";
        }

        public string number
        {
            get
            {
                return $"Numbers: {k} ";
            }
        }
        public string typecamera()
        {
            return "Type camera: ADD ";
        }
        public string producercamera()
        {
            return "Producer camera: China";
        }
        public string lightsensitivity
        {
            get
            {
                return $"Light sensitivity:{l} ";
            }
        }
        public void Printlamp()
        {
            Console.WriteLine($"{typel()}\n{producerlamp()}\n{power}\n{viewl()}\n");
        }
        public void Printcamera()
        {
            Console.WriteLine($"{typecamera()}\n{producercamera()}\n{lightsensitivity}\n");
        }
        static void Main(string[] args)
        {
            PhotoStudio[] foto = { new PhotoStudio(1200, 3, 200), new PhotoStudio(1600, 1, 1600) };
            foreach (PhotoStudio p in foto)
            {
                p.Printlamp();
                p.Printcamera();
                
            }
        }
    }
}
