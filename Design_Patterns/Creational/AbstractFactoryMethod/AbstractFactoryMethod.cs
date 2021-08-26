using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.AbstractFactoryMethod
{
    public interface IProfession
    {
        void WhoAmI();
    }

    public class Teacher : IProfession
    {
        public void WhoAmI()
        {
            Console.WriteLine("I am a Teacher");
        }
    }

    public class Engineer : IProfession
    {
        public void WhoAmI()
        {
            Console.WriteLine("I am a Engineer");
        }
    }

    public class TraineeTeacher : IProfession
    {
        public void WhoAmI()
        {
            Console.WriteLine("I am a Trainee Teacher");
        }
    }

    public class TraineeEngineer : IProfession
    {
        public void WhoAmI()
        {
            Console.WriteLine("I am a Trainee Engineer");
        }
    }

    public interface IProfessionalfactory
    {
        IProfession getSubFactory(string profession);

    }

    public class ExperiencedProfessionFactory: IProfessionalfactory
    {
        public IProfession getSubFactory(string profession)
        {
            if(profession == "Teacher")
            {
                return new Teacher();
            }
            else
            {
                return new Engineer();
            }
        }
    }

    public class TraineeProfessionFactory: IProfessionalfactory
    {
        public IProfession getSubFactory(string profession)
        {
            if (profession == "Teacher")
            {
                return new TraineeTeacher();
            }
            else
            {
                return new TraineeEngineer();
            }
        }
    }

    public class ProfessionalFactory
    {
        public IProfessionalfactory getProfessionalFactory(bool isExp)
        {
            if(isExp)
            {
                return new ExperiencedProfessionFactory();
            }
            else
            {
                return new TraineeProfessionFactory();
            }
        }
    }


    public class ProfessionalFactory1
    {
        public IProfession getProfession(string profession, bool isExp)
        {
            if (isExp)
            {
                if(profession == "Teacher")
                {
                    return new Teacher();
                }else
                {
                    return new Engineer();
                }
            }
            else
            {
                if (profession == "Teacher")
                {
                    return new TraineeTeacher();
                }
                else
                {
                    return new TraineeEngineer();
                }
            }
        }
    }

}
