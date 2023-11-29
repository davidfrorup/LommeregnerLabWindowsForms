using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace LabWindowsForms.Logic
{
    public class Calc
    {


        public int PerformCalculation(CalcType type, int tal1, int tal2)
        {
            int result = 0;

            switch (type)
            {
                case CalcType.Addition:
                    result = tal1 + tal2;
                    break;
                case CalcType.Subtraction:
                    result = tal1 - tal2;
                    break;
                case CalcType.Multiplication:
                    result = tal1 * tal2;
                    break;
                case CalcType.Division:
                    result = tal1 / tal2;
                    break;
                case CalcType.Modulos:
                    result = tal1 % tal2;
                    break;
            }

            return result;
        }
    }

    public enum CalcType
    {
        None = 0,
        Addition = 1,
        Subtraction = 2,
        Multiplication = 3,
        Division = 4,
        Modulos = 5
    }
}
