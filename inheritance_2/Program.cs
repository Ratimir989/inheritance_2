using System;
using System.Collections.Generic;

namespace inheritance_2
{
    class ClassRoom
    {
        private List<Pupil> pupils = new List<Pupil>();

        public List<Pupil> Pupils
        {
            get { return pupils; }
        }

        public ClassRoom() { }
        public ClassRoom(Pupil firstPupil, Pupil secondPupil)
        {
            Pupils.Add(firstPupil);
            Pupils.Add(secondPupil);
        }
        public ClassRoom(Pupil firstPupil, Pupil secondPupil, Pupil thirdPupil)
        {
            Pupils.Add(firstPupil);
            Pupils.Add(secondPupil);
            Pupils.Add(thirdPupil);
        }
        public ClassRoom(Pupil firstPupil, Pupil secondPupil, Pupil thirdPupil, Pupil fourthPupil)
        {
            Pupils.Add(firstPupil);
            Pupils.Add(secondPupil);
            Pupils.Add(thirdPupil);
            Pupils.Add(fourthPupil);
        }
    }
    class Pupil
    {
        public virtual void Study()
        {

        }

        public virtual void Read()
        {

        }

        public virtual void Write()
        {

        }

        public virtual void Relax()
        {

        }
    }
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Я отличный ученик, у меня одни пятерки!");
        }

        public override void Read()
        {
            Console.WriteLine("Я отличный ученик, я много читаю!");
        }

        public override void Write()
        {
            Console.WriteLine("Я отличный ученик, я красиво пишу!");
        }

        public override void Relax()
        {
            Console.WriteLine("Я отличный ученик, я не отдыхаю!");
        }
    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Я хороший ученик, нормально так учусь.");
        }

        public override void Read()
        {
            Console.WriteLine("Я хороший ученик, читаю достаточно выразительно.");
        }

        public override void Write()
        {
            Console.WriteLine("Я хороший ученик, пишу быстро.");
        }

        public override void Relax()
        {
            Console.WriteLine("Я хороший ученик, но люблю отдохнуть.");
        }
    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Что? Какая учеба?");
        }

        public override void Read()
        {
            Console.WriteLine("Я умею читать по слогам.");
        }

        public override void Write()
        {
            Console.WriteLine("Пишу криво, но пишу.");
        }

        public override void Relax()
        {
            Console.WriteLine("Релакс - моё любимое состояние!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pupil firstPupil = new ExcelentPupil();
            Pupil secondPupil = new GoodPupil();
            Pupil thirdPupil = new GoodPupil();
            Pupil fourthPupil = new BadPupil();

            ClassRoom classRoom = new ClassRoom(firstPupil, secondPupil, thirdPupil, fourthPupil);

            foreach (Pupil p in classRoom.Pupils)
            {
                p.Study();
                p.Read();
                p.Write();
                p.Relax();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
